using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Horizon_Call_Recordings_Viewer.Properties;
using Ionic.Zip;

namespace Horizon_Call_Recordings_Viewer {
    public partial class HorizonCallRecordingsViewer : Form {
        private string _callRecordingsFolder;

        private RecordingsManager _recordingsManager;
        private List<Recording> _displayedRecordings;
        private List<Recording> _selectedRecordings;

        public HorizonCallRecordingsViewer(RecordingsManager recordingsManager) {
            InitializeComponent();

            // MOVED TO LoadingScreen.cs
            // if(string.IsNullOrWhiteSpace(Settings.Default.CallRecordingsSource)) {
            //     Console.WriteLine("-- Updating CallRecordingsSource to DEFAULT value");
            //     Settings.Default.CallRecordingsSource = Settings.Default.DefaultCallRecordingsSource;
            // }
            //
            // if(string.IsNullOrWhiteSpace(Settings.Default.CallRecordingsTemp)) {
            //     Console.WriteLine("-- Updating CallRecordingsTemp to DEFAULT value");
            //     Settings.Default.CallRecordingsTemp = TempFolder.Directory;
            //     if(Setup.SetupTempFolder()) {
            //         Console.WriteLine("Created Temp Dir: " + Settings.Default.CallRecordingsTemp);
            //     }
            // }


            this._recordingsManager = recordingsManager;
            this._recordingsManager.StatusUpdated += RecordingsManagerOnStatusUpdated;

            this._selectedRecordings = new List<Recording>();

            //Set the date format for the date-based pickers
            this.dateFromDatePicker.Format = this.dateToDatePicker.Format = DateTimePickerFormat.Long;
            // this.dateFromDatePicker.CustomFormat = this.dateToDatePicker.CustomFormat = "dd/mm/yyyy";
            // this.dateFromDatePicker.ShowUpDown = this.dateToDatePicker.ShowUpDown = true;


            //Set the date format for the time-based pickers
            this.timeFromDatePicker.Format = this.timeToDatePicker.Format = DateTimePickerFormat.Custom;
            this.timeFromDatePicker.CustomFormat = this.timeToDatePicker.CustomFormat = "HH:mm";
            this.timeFromDatePicker.ShowUpDown = this.timeToDatePicker.ShowUpDown = true;


            if(!string.IsNullOrWhiteSpace(Settings.Default.CallRecordingsSource)) {
                this._callRecordingsFolder = Settings.Default.CallRecordingsSource;
                ShowCallRecordings();
            }


            Math.Floor(1.32);
        }

        private void RecordingsManagerOnStatusUpdated(int total, int loaded, bool isNewFile) {
            statusToolStripLabel.Text = "Available Files: " + this._recordingsManager.AvailableFilesList.Count;
            this.Update();
        }


        private void applySearchButton_Click(object sender, EventArgs e) {
            //Piece together the two date and time pickers into one DateTime object
            //Firstly, DateFrom
            var dateFromDate = this.dateFromDatePicker.Value;
            var dateFromTime = this.timeFromDatePicker.Value;
            var dateFromStr = dateFromDate.ToString("dd/MM/yyyy") + " " + dateFromTime.ToString("HH:mm");
            var dateFrom = DateTime.ParseExact(dateFromStr, Recording.DATE_FORMAT, CultureInfo.InvariantCulture);
            if(!dateFromCheckBox.Checked)
                dateFrom = DateTime.MinValue;

            //Secondly, DateTo
            var dateToDate = this.dateToDatePicker.Value;
            var dateToTime = this.timeToDatePicker.Value;
            var dateToStr = dateToDate.ToString("dd/MM/yyyy") + " " + dateToTime.ToString("HH:mm");
            var dateTo = DateTime.ParseExact(dateToStr, Recording.DATE_FORMAT, CultureInfo.InvariantCulture);
            if(!dateToCheckBox.Checked)
                dateTo = DateTime.MinValue;

            var filteredList = this._recordingsManager.Filter(
                Recording.SanitiseNumber(this.callerNumberTextbox.Text),
                Recording.SanitiseNumber(this.recipientNumberTextbox.Text),
                dateFrom, dateTo,
                (this.callerDirectionBothRadioButton.Checked) ? Recording.RecordingDirection.BOTH :
                (this.callerDirectionInboundRadioButton.Checked) ? Recording.RecordingDirection.INBOUND :
                Recording.RecordingDirection.OUTBOUND
            );


            // int i = 0;
            // foreach (DataGridViewRow row in this.resultsGridView.Rows) {
            //     var checkBoxCell = (DataGridViewCheckBoxCell) row.Cells[0];
            //
            //     // this.
            //
            //     i++;
            // }

            MergeSelectedRecordings(filteredList);
            
            UpdateDataGridView(filteredList);
            // foreach (DataGridViewColumn column in this.resultsGridView.Columns) {
            //     if (column.HeaderText.ToLower().Equals("selected"))
            //         continue;
            //
            //     column.CellTemplate.
            //     break;
            // }
            // this.dataGridView1.Refresh();
        }

        private void ControlStatusCheckBox_CheckedChanged(object sender, EventArgs e) {
            if(!(sender is CheckBox))
                return;

            var senderCheckBox = (CheckBox) sender;
            var state = senderCheckBox.Checked;

            switch (senderCheckBox.Name) {
                case "dateFromCheckBox":
                case "timeFromCheckBox":
                    this.dateFromDatePicker.Enabled = state;
                    this.timeFromDatePicker.Enabled = state;

                    this.dateFromCheckBox.Checked = state;
                    this.timeFromCheckBox.Checked = state;

                    break;

                case "dateToCheckBox":
                case "timeToCheckBox":
                    this.dateToDatePicker.Enabled = state;
                    this.timeToDatePicker.Enabled = state;

                    this.dateToCheckBox.Checked = state;
                    this.timeToCheckBox.Checked = state;
                    break;
            }
        }

        private void FormControl_KeyPress(object sender, KeyPressEventArgs e) {
            if(e.KeyChar != (char) Keys.Enter)
                return;

            this.applySearchButton.PerformClick();
        }

        private void UpdateSelectedToolStrip() {
            this.selectedToolStripDropDown.Text = $"Selected ({this._selectedRecordings.Count})";

            if(this._selectedRecordings.Count > 0) {
                this.exportToolStripMenuItem.Enabled = true;
                this.exportSingleToolStripMenuItem.Enabled = true;
            } else {
                this.exportToolStripMenuItem.Enabled = false;
                this.exportSingleToolStripMenuItem.Enabled = false;
            }
            
        }

        private void UpdateSelectedRecordings() {
            for (var i = 0; i < this.resultsGridView.Rows.Count; i++) {
                var checkboxCell = (DataGridViewCheckBoxCell) this.resultsGridView.Rows[i]
                    .Cells[GetColumnIndex(RecordingsManager.Columns.Selected)];
                var cellValue = (bool) checkboxCell.Value;

                var indexCellValue = (int) this.resultsGridView.Rows[i]
                    .Cells[GetColumnIndex(RecordingsManager.Columns.Index)].Value;

                var recording = GetRecording(indexCellValue);

                var indexOf = this._selectedRecordings.IndexOf(recording);
                if(indexOf != -1) {
                    this._selectedRecordings[indexOf].IsSelected = cellValue;
                } else {
                    if(cellValue) {
                        recording.IsSelected = true;
                        this._selectedRecordings.Add(recording);
                    }
                }
            }


            UpdateSelectedToolStrip();
        }

        private void MergeSelectedRecordings(List<Recording> newList) {
            for (var i = 0; i < newList.Count; i++) {
                var newRecording = newList[i];

                var indexOf = 0;
                if((indexOf = this._selectedRecordings.IndexOf(newRecording)) != -1)
                    newRecording.IsSelected = this._selectedRecordings[indexOf].IsSelected;
            }
        }

        private int GetColumnIndex(string headerText) {
            for (var i = 0; i < this.resultsGridView.Columns.Count; i++) {
                var column = this.resultsGridView.Columns[i];
                if(column.HeaderText.ToLower().Equals(headerText.ToLower()))
                    return i;
            }

            return -1;
        }

        private Recording GetRecording(int index) {
            if(index < 0 || index >= _recordingsManager.AvailableFilesList.Count)
                return null;

            return _recordingsManager.AvailableFilesList[index];
        }

        private void resultsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            var senderGrid = (DataGridView) sender;


            if(e.ColumnIndex == GetColumnIndex(RecordingsManager.Columns.Selected) && e.RowIndex >= 0) {
                senderGrid.EndEdit();

                var recordingIndex = (int) senderGrid.Rows[e.RowIndex].Cells[GetColumnIndex(RecordingsManager.Columns.Index)]
                    .Value;
                var recording = GetRecording(recordingIndex);
                
                
                var value = (bool) senderGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                var alreadySelected = recording.IsSelected;
                var alreadyContains = this._selectedRecordings.Contains(recording);

                if(value && !alreadySelected) {
                    recording.IsSelected = true;
                    if(!alreadyContains)
                        this._selectedRecordings.Add(recording);
                } else if(!value && alreadySelected) {
                    this._selectedRecordings.Remove(recording);
                    recording.IsSelected = false;
                }

                UpdateSelectedToolStrip();
            }
        }


        private void viewToolStripMenuItem_Click(object sender, EventArgs e) {
            var temp = new Recording[this._selectedRecordings.Count];
            this._selectedRecordings.CopyTo(temp);

            var list = new List<Recording>(temp);
            this.UpdateDataGridView(list);
        }


        private void callerSelectionDialogButton_Click(object sender, EventArgs e) {
            var selectPersonDialog = new SelectPersonDialog();

            var dialogResult = selectPersonDialog.ShowDialog();

            if(dialogResult != DialogResult.OK || selectPersonDialog.SelectedPerson == null)
                return;

            this.callerNumberTextbox.Text = selectPersonDialog.SelectedPerson.PhoneNo;
        }

        private void HorizonCallRecordingsViewer_Load(object sender, EventArgs e) {
            this.ControlStatusCheckBox_CheckedChanged(this.dateFromCheckBox, EventArgs.Empty);
            this.ControlStatusCheckBox_CheckedChanged(this.dateToCheckBox, EventArgs.Empty);
        }

        private void resultsGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e) {
            if(GetColumnIndex(RecordingsManager.Columns.Selected) == e.ColumnIndex)
                return;

            ((DataGridView) sender).CancelEdit();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void selectCallRecordingsToolStripMenuItem_Click(object sender, EventArgs e) {
            if(ChangeCallRecordingSource())
                ShowCallRecordings();
        }

        private void selectTemporaryFolderToolStripMenuItem_Click(object sender, EventArgs e) {
            ChangeCallRecordingTemp();
        }

        private void ShowCallRecordings() {
            // this._recordingsManager.ImportRecordings(this._callRecordingsFolder);

            var availableRecordingsCount = this._recordingsManager.AvailableFilesList.Count;
            this.RecordingsManagerOnStatusUpdated(availableRecordingsCount, availableRecordingsCount, true);
            
            UpdateDataGridView(null);
            // this.dataGridView1.Columns[2].DefaultCellStyle.Format = Recording.DATE_FORMAT;

            UpdateSelectedRecordings();
        }


        private bool ChangeCallRecordingSource() {
            var folderDialog = new FolderBrowserDialog();
            if(!string.IsNullOrWhiteSpace(Settings.Default.CallRecordingsSource)) {
                Console.WriteLine("Setting Folder Dialog Selected Path (Source)");
                folderDialog.SelectedPath = Settings.Default.CallRecordingsSource;
            }

            var folderResult = folderDialog.ShowDialog();

            if(folderResult != DialogResult.OK)
                return false;

            this._callRecordingsFolder = folderDialog.SelectedPath;
            Settings.Default.CallRecordingsSource = folderDialog.SelectedPath;
            Settings.Default.Save();

            return true;
        }

        private bool ChangeCallRecordingTemp() {
            var folderDialog = new FolderBrowserDialog();
            if(!string.IsNullOrWhiteSpace(Settings.Default.CallRecordingsTemp)) {
                Console.WriteLine("Setting Folder Dialog Selected Path (Temp)");
                folderDialog.SelectedPath = Settings.Default.CallRecordingsTemp;
            }

            var folderResult = folderDialog.ShowDialog();

            if(folderResult != DialogResult.OK)
                return false;

            // this._callRecordingsFolder = folderDialog.SelectedPath;
            Settings.Default.CallRecordingsTemp = folderDialog.SelectedPath;
            Settings.Default.Save();

            return true;
        }

        private void cleanUpToolStripMenuItem_Click(object sender, EventArgs e) {
            var resultA = MessageBox.Show(this,
                "This will delete EVERY file within the temp directory (" + Settings.Default.CallRecordingsTemp +
                "). Are you sure you want to do this?",
                "Horizon: Call Recordings Viewer", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if(resultA != DialogResult.Yes)
                return;

            var resultB = MessageBox.Show(this,
                "Are you definitely sure? This is your last opportunity to change your mind.",
                "Horizon: Call Recordings Viewer", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if(resultB != DialogResult.Yes)
                return;

            var directories = Directory.GetDirectories(Settings.Default.CallRecordingsTemp);
            var files = Directory.GetFiles(Settings.Default.CallRecordingsTemp);

            foreach (var directory in directories) {
                Console.WriteLine("Will delete... " + directory);
            }

            foreach (var file in files) {
                Console.WriteLine("Will delete... " + file);
            }
        }

        private void extractToolStripMenuItem_Click(object sender, EventArgs e) {
            this._recordingsManager.ExtractRecordings(this._selectedRecordings);
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e) {
            var selectedColIndex = GetColumnIndex(RecordingsManager.Columns.Selected);
            var indexColIndex = GetColumnIndex(RecordingsManager.Columns.Index);
            
            for (var i = 0; i < this.resultsGridView.Rows.Count; i++) {
                var recordingIndex = (int) this.resultsGridView.Rows[i].Cells[indexColIndex].Value;
                var recording = GetRecording(recordingIndex);
                
                this.resultsGridView.Rows[i].Cells[selectedColIndex].Value = true;

                // if(!this._selectedRecordings.Contains(recording))
                    // this._selectedRecordings.Add(this._displayedRecordings[i]);
                // this.resultsGridView_CellContentClick(this.resultsGridView, new DataGridViewCellEventArgs(colIndex, i));
            }

            this.UpdateSelectedRecordings();
        }

        private void selectNoneToolStripMenuItem_Click(object sender, EventArgs e) {
            var selectedColIndex = GetColumnIndex(RecordingsManager.Columns.Selected);
            
            for (var i = 0; i < this._selectedRecordings.Count; i++) {
                var selectedRecording = this._selectedRecordings[i];

                var indexOf = 0;
                if((indexOf = _displayedRecordings.IndexOf(selectedRecording)) != -1) {
                    this.resultsGridView.Rows[indexOf].Cells[selectedColIndex].Value = false;
                    selectedRecording.IsSelected = false;
                }

                this._selectedRecordings.RemoveAt(i);
                i--;
            }

            //
            UpdateSelectedToolStrip();
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e) {
            var saveDialog = new SaveFileDialog();
            saveDialog.Filter = "ZIP (*.zip)|*.zip";


            if(!string.IsNullOrWhiteSpace(Settings.Default.LastSaveLocation))
                saveDialog.InitialDirectory = Settings.Default.LastSaveLocation;

            var saveResult = saveDialog.ShowDialog();
            if(saveResult != DialogResult.OK)
                return;

            if(File.Exists(saveDialog.FileName)) {
                var failureResult = MessageBox.Show("Cannot export to a file that already exists!",
                    "Horizon: Call Recordings Viewer",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

                if(failureResult == DialogResult.OK)
                    this.exportToolStripMenuItem_Click(sender, e);

                return;
            }

            var extractedRecordings = this._recordingsManager.ExtractRecordings(this._selectedRecordings);

            var zipFile = new ZipFile(saveDialog.FileName);
            zipFile.AddFiles(extractedRecordings, false, "");

            zipFile.Save();

            MessageBox.Show("Exports saved at " + saveDialog.FileName, "Horizon: Call Recordings Viewer",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exportSingleToolStripMenuItem_Click(object sender, EventArgs e) {
            var extractedRecordings = this._recordingsManager.ExtractRecordings(this._selectedRecordings);
            var failMessage = "";


            if(this._selectedRecordings.Count > 1) {
                //Handle multiple recordings
                var folderDialog = new FolderBrowserDialog();

                if(!string.IsNullOrWhiteSpace(Settings.Default.LastSaveLocation))
                    folderDialog.SelectedPath = Settings.Default.LastSaveLocation;

                var folderResult = folderDialog.ShowDialog();
                if(folderResult != DialogResult.OK)
                    return;

                foreach (var recording in extractedRecordings) {
                    var recordingFileName = recording.Split('\\').Last();
                    var recordingPath = Path.Combine(folderDialog.SelectedPath, recordingFileName);

                    try {
                        File.Copy(recording, recordingPath);
                    } catch (IOException ex) {
                        Console.WriteLine("Failed to extract individual call recording from batch... " +
                                          recordingFileName);
                        Console.WriteLine(ex);

                        failMessage += "Failed to extract " + recordingFileName + "\n";
                    }
                }
            } else if(this._selectedRecordings.Count > 0) {
                //Handle single recording
                var saveDialog = new SaveFileDialog();
                saveDialog.Filter = "MP3 (*.mp3)|*.mp3";

                var recording = extractedRecordings[0];
                var recordingFileName = recording.Split('\\').Last();

                saveDialog.FileName = recordingFileName;

                if(!string.IsNullOrWhiteSpace(Settings.Default.LastSaveLocation))
                    saveDialog.InitialDirectory = Settings.Default.LastSaveLocation;

                var saveResult = saveDialog.ShowDialog();
                if(saveResult != DialogResult.OK)
                    return;

                try {
                    File.Copy(recording, saveDialog.FileName);
                } catch (IOException ex) {
                    Console.WriteLine("Failed to extract individual call recording... " + recordingFileName);
                    Console.WriteLine(ex);
                    failMessage += "Failed to extract " + recordingFileName + "\n";
                }
            }
        }


        private void UpdateDataGridView(List<Recording> list) {
            this._displayedRecordings = (list != null) ? list : this._recordingsManager.AvailableFilesList;
            this.resultsGridView.DataSource = this._recordingsManager.CreateDataSet(list);
            this.resultsGridView.Columns[0].Visible = false;
        }

        private void showAllToolStripMenuItem_Click(object sender, EventArgs e) {
            UpdateDataGridView(null);
        }
    }
}