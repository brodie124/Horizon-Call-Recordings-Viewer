using System;
using System.IO;
using Horizon_Call_Recordings_Viewer.Properties;

namespace Horizon_Call_Recordings_Viewer {
    public class Setup {
        public static bool SetupTempFolder() {
            var tempDir = Settings.Default.CallRecordingsTemp;

            if(Directory.Exists(tempDir))
                return false;

            try {
                Directory.CreateDirectory(tempDir);
                return true;
            } catch (IOException ex) {
                Console.WriteLine(ex);
                return false;
            }
        }
    }
}