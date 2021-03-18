using System;
using System.Runtime.CompilerServices;
using Horizon_Call_Recordings_Viewer.Properties;

namespace Horizon_Call_Recordings_Viewer {
    public static class TempFolder {

        public static string Directory {
            get {
                return Settings.Default.DefaultCallRecordingsTemp
                    .Replace("%temp%", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
            }
        }


        public static string ArchivesDirectory {
            get {
                return TempFolder.Directory + @"\archives\";
            }
        }
        
    }
}