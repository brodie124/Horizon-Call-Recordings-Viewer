using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

namespace Horizon_Call_Recordings_Viewer {
    public class Recording {
        public const long BIT_RATE = 24;
        
        private string _fileFormat = "mp3";

        public const string DATE_FORMAT = "dd/MM/yyyy HH:mm";

        public string Path;

        public string ZipPath;

        public string CallerNumber;

        public string RecipientNumber;

        public int CallLength;

        public DateTime DateTime;

        public RecordingDirection Direction;

        public bool IsSelected;

        public int ListIndex = -1;


        public Recording(string path, string zipPath) {

            this.Path = path;
            this.ZipPath = zipPath;
            
            this.ProcessRecordingName(this.Path.Split('\\').Last());
            this.Sanitise();
        }


        private void ProcessRecordingName(string name) {
            if (name.Contains(@"\"))
                name = name.Split('\\').Last();


            var regex = new Regex(@"^(\d+|withheld)_(\d+)_(\d+)_(\d+)_([a-zA-Z]).*$");
            var match = regex.Match(name);

            if (match.Groups.Count == 6) {
                //Correct number of groups matched

                this.CallerNumber = match.Groups[1].Value;
                this.RecipientNumber = match.Groups[2].Value;

                var date = match.Groups[3].Value;
                var time = match.Groups[4].Value;

                this.DateTime = DateTime.ParseExact(date + " " + time, "yyyyMMdd HHmmss", CultureInfo.InvariantCulture);

                this.Direction = (match.Groups[5].Value.ToLower() == "i")
                    ? RecordingDirection.INBOUND
                    : RecordingDirection.OUTBOUND;
            }
            else {

                Console.WriteLine("Invalid name...");
                Console.WriteLine(name);

                Console.WriteLine("");
            }
            
        }


        /**
         * {CALLER}    = Caller Number
         * {RECIPIENT} = Recipient Number
         * {DATE}      = Call Date
         * {TIME}      = Call Time
         * {DIRECTION} = Call Direction
         * {LENGTH}    = Call Length
         */
        public string FormatFileName(string format) {

            var keys = new Dictionary<string, string>();
            keys.Add("{CALLER}", this.CallerNumber);
            keys.Add("{RECIPIENT}", this.RecipientNumber);
            keys.Add("{DATE}", this.DateTime.ToString("ddMMyyyy"));
            keys.Add("{TIME}", this.DateTime.ToString("hhmmss"));
            keys.Add("{DIRECTION}", (this.Direction == RecordingDirection.INBOUND) ? "I" : "O");
            keys.Add("{LENGTH}", this.CallerNumber);

            foreach(var entry in keys) {
                format = format.Replace(entry.Key, entry.Value);
            }
            
            return format;
        }

        private void Sanitise() {
            if (this.CallerNumber != null) {
                if (this.CallerNumber.ToLower().Equals("withheld")) {
                    this.CallerNumber = "WITHHELD";
                } else if (this.CallerNumber.StartsWith("44")) {
                    this.CallerNumber = "0" + this.CallerNumber.Substring(2);
                }
                else if (!this.CallerNumber.StartsWith("0")) {
                    this.CallerNumber = "0" + this.CallerNumber;
                }
            }

            if (this.RecipientNumber != null) {
                if (this.RecipientNumber.StartsWith("44")) {
                    this.RecipientNumber = "0" + this.RecipientNumber.Substring(2);
                }
                else if (!this.RecipientNumber.StartsWith("0")) {
                    this.RecipientNumber = "0" + this.RecipientNumber;
                }
            }
        }

        public enum RecordingDirection {
            INBOUND,
            OUTBOUND,
            BOTH
        }

        protected bool Equals(Recording other) {
            return CallerNumber == other.CallerNumber && RecipientNumber == other.RecipientNumber && DateTime.Equals(other.DateTime) && Direction == other.Direction;
        }

        public override bool Equals(object obj) {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(Recording)) return false;
            return Equals((Recording) obj);
        }

        public override int GetHashCode() {
            unchecked {
                var hashCode = (CallerNumber != null ? CallerNumber.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (RecipientNumber != null ? RecipientNumber.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ DateTime.GetHashCode();
                hashCode = (hashCode * 397) ^ (int) Direction;
                return hashCode;
            }
        }
    }
}