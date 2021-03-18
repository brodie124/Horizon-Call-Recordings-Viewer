using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Ionic.Zip;

namespace Horizon_Call_Recordings_Viewer {
    public class RecordingsManager {
        private List<Recording> _availableFilesList;


        public List<Recording> AvailableFilesList => _availableFilesList;


        public delegate void StatusUpdatedHandler(int totalToLoad, int totalLoaded, bool isNewFile = false);

        public event StatusUpdatedHandler StatusUpdated;


        public RecordingsManager() {
            _availableFilesList = new List<Recording>();
        }

        /**
         * Searches the provided directory for all usable Horizon call recordings.
         */
        public void ImportRecordings(string path, bool recursive = true) {
            //If the given directory doesn't exist, don't bother.
            if (!Directory.Exists(path))
                return;

            var uiUpdatedFreq = 100;
            var uiCounter = 0;
            


            var zipFiles = Directory.GetFiles(path, "*.zip");
            foreach (var zipFile in zipFiles) {
                using (var zip = ZipFile.Read(zipFile)) {
                    var totalZipEntries = zip.Entries.Count;
                    var zipEntriesLoaded = 0;
                    bool isNewFile = true;
                    foreach (var zipEntry in zip.Entries) {

                        var recording = new Recording(zipEntry.FileName, zip.Name);
                        recording.CallLength =
                            (int) Math.Ceiling((double) ((zipEntry.UncompressedSize * 8) /
                                                         (Recording.BIT_RATE * 1024)));

                        if(!this._availableFilesList.Contains(recording)) {
                            _availableFilesList.Add(recording);
                            recording.ListIndex = _availableFilesList.Count - 1;
                        }


                        zipEntriesLoaded++;


                        if (uiCounter < uiUpdatedFreq && zipEntriesLoaded != totalZipEntries) {
                            uiCounter++;
                        }  else {
                            uiCounter = 0;

                            this.StatusUpdated(totalZipEntries, zipEntriesLoaded, isNewFile);
                            if(isNewFile)
                                isNewFile = false;
                        }
                    }
                }
            }


            //If recursion is  turned on, get a list of all sub directories of this path and pass it back into ImportRecordings
            if (recursive) {
                Directory.GetDirectories(path).ToList().ForEach((subPath) => this.ImportRecordings(subPath, true));
            }
        }


        public List<Recording> Filter(string callerNo, string recipientNo, DateTime dateFrom = new DateTime(),
            DateTime dateTo = new DateTime(),
            Recording.RecordingDirection direction = Recording.RecordingDirection.BOTH) {
            var list = new List<Recording>();

            foreach (var recording in _availableFilesList) {
                //Firstly... Caller No. match
                if (!string.IsNullOrEmpty(callerNo) && !recording.CallerNumber.Contains(callerNo)) {
                    continue;
                }

                if (!string.IsNullOrEmpty(recipientNo) && !recording.RecipientNumber.Contains(recipientNo)) {
                    continue;
                }

                if (dateFrom != DateTime.MinValue) {
                    if (DateTime.Compare(dateFrom, recording.DateTime) > 0) {
                        //Date From is greater than the Recording's DateTime so discard
                        continue;
                    }
                }

                if (dateTo != DateTime.MinValue) {
                    if (DateTime.Compare(dateTo, recording.DateTime) < 0) {
                        //Date To is less than the Recording's DateTime so discard
                        continue;
                    }
                }

                if (direction != Recording.RecordingDirection.BOTH && recording.Direction != direction) {
                    continue;
                }

                list.Add(recording);
            }

            return list;
        }

        public List<string> ExtractRecordings(List<Recording> recordings,
            string fileFormat = "{CALLER}_{RECIPIENT}_{DATE}_{TIME}_{DIRECTION}.mp3") {
            var recordingPaths = new List<string>();

            var stopwatch = new Stopwatch();


            //Step 1. Identify which files will be needed for the requested recordings.
            var neededArchives = new List<string>();
            foreach (var recording in recordings) {
                if (!neededArchives.Contains(recording.ZipPath)) {
                    neededArchives.Add(recording.ZipPath);
                }
            }

            //Step 2 & 3
            foreach (var neededArchive in neededArchives) {
                //Step 2. Generate the necessary folder structure for each of the archives.
                var neededArchiveDirectory =
                    TempFolder.ArchivesDirectory + (neededArchive.Split('\\').Last().Split('.').First());

                try {
                    Console.WriteLine("Attempting to create folder (temp archive)... " + neededArchiveDirectory);
                    Directory.CreateDirectory(neededArchiveDirectory);
                }
                catch (IOException ex) {
                    Console.WriteLine("Failed to create archive directory... " + neededArchiveDirectory);
                    Console.WriteLine(ex);
                    return null;
                }

                //Step 3. Extract the required archives into their respective folders.
                stopwatch.Start();
                using (var zip = ZipFile.Read(neededArchive)) {
                    foreach (var zipEntry in zip.Entries) {
                        try {
                            var matches = recordings.Where((r) => zipEntry.FileName.Contains(r.Path));
                            if (!matches.Any()) {
                                continue;
                            }

                            

                            var recording = matches.First();
                            var recordingFilePath =
                                Path.Combine(neededArchiveDirectory, recording.FormatFileName(fileFormat));
                            
                            Console.WriteLine("Located file. Extracting... " + recording.Path);

                            recordingPaths.Add(recordingFilePath);
                            
                            var stream = new FileStream(recordingFilePath, FileMode.Create);
                            zipEntry.Extract(stream);
                        }
                        catch (IOException ex) {
                            Console.WriteLine("Failed to extract call recording... " + zipEntry.FileName);
                            Console.WriteLine(ex);
                        }
                    }
                }

                stopwatch.Stop();
            }

            var totalTime = stopwatch.ElapsedMilliseconds;
            Console.WriteLine("Time to extract: " + totalTime + "ms");


            return recordingPaths;
        }

        public bool PlayRecording(Recording recording) {
            var extractedRecording = ExtractRecordings(new List<Recording>() {recording});
            if(extractedRecording.Count < 1)
                return false;

            Process.Start(extractedRecording.First());
            
            return true;
        }

        public DataTable CreateDataSet() {
            return CreateDataSet(null);
        }

        public DataTable CreateDataSet(List<Recording> recordingsList) {
            if(recordingsList == null)
                recordingsList = this._availableFilesList;

            var ds = new DataSet();

            var dt = new DataTable();

            dt.Columns.Add(Columns.Index);
            dt.Columns.Add(Columns.Selected);
            dt.Columns.Add(Columns.Caller);
            dt.Columns.Add(Columns.Recipient);
            dt.Columns.Add(Columns.DateTime);
            dt.Columns.Add(Columns.Duration);
            dt.Columns.Add(Columns.Direction);

            dt.Columns[0].DataType = typeof(int);
            dt.Columns[1].DataType = typeof(bool);
            dt.Columns[4].DataType = typeof(DateTime);
            dt.Columns[5].DataType = typeof(int);
            

            foreach (var recording in recordingsList) {
                dt.Rows.Add(new Object[] {
                    recording.ListIndex,
                    recording.IsSelected,
                    recording.CallerNumber,
                    recording.RecipientNumber,
                    recording.DateTime.ToString(Recording.DATE_FORMAT),
                    recording.CallLength,
                    recording.Direction == Recording.RecordingDirection.INBOUND ? "Inbound" : "Outbound"
                });
            }


            // dt.Columns[2].

            return dt;
        }


        public static class Columns {
            public const string Index = "Index";
            public const string Selected = "Selected";
            public const string Caller = "Caller No.";
            public const string Recipient = "Recipient No.";
            public const string DateTime = "Date & Time";
            public const string Duration = "Duration";
            public const string Direction = "Direction";
        }
    }
}