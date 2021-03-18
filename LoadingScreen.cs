using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Horizon_Call_Recordings_Viewer.Properties;

namespace Horizon_Call_Recordings_Viewer {
    public partial class LoadingScreen : Form {
        private RecordingsManager _recordingsManager;

        private int _totalRecordingsToLoad = 0;
        private int _totalRecordingsLoaded = 0;

        private int _currentZipLoaded = 0;
        private int _currentZipPreviousLoaded = 0;

        public LoadingScreen() {
            InitializeComponent();

            _recordingsManager = new RecordingsManager();
            _recordingsManager.StatusUpdated += RecordingsManagerOnStatusUpdated;


            if(string.IsNullOrWhiteSpace(Settings.Default.CallRecordingsSource)) {
                Console.WriteLine("-- Updating CallRecordingsSource to DEFAULT value");
                Settings.Default.CallRecordingsSource = Settings.Default.DefaultCallRecordingsSource;
            }

            if(string.IsNullOrWhiteSpace(Settings.Default.CallRecordingsTemp)) {
                Console.WriteLine("-- Updating CallRecordingsTemp to DEFAULT value");
                Settings.Default.CallRecordingsTemp = TempFolder.Directory;
                if(Setup.SetupTempFolder()) {
                    Console.WriteLine("Created Temp Dir: " + Settings.Default.CallRecordingsTemp);
                }
            }
        }

        private void RecordingsManagerOnStatusUpdated(int total, int loaded, bool isNewFile) {
            if(this.InvokeRequired || this.loadedLabel.InvokeRequired || this.loadedProgressBar.InvokeRequired) {
                this.BeginInvoke(new Action(() => { UpdateUI(total, loaded, isNewFile); }));
            } else {
                UpdateUI(total, loaded, isNewFile);
            }
        }


        private void UpdateUI(int total, int loaded, bool isNewFile) {
            this._currentZipPreviousLoaded = this._currentZipLoaded;
            this._currentZipLoaded = loaded;

            if(isNewFile)
                this._totalRecordingsToLoad += total;

            this._totalRecordingsLoaded += (this._currentZipLoaded - this._currentZipPreviousLoaded);

            this.loadedLabel.Text = $"Loaded: {this._totalRecordingsToLoad} / {this._totalRecordingsToLoad}";
        }

        private async void LoadingScreen_Load(object sender, EventArgs e) {
            if(!string.IsNullOrWhiteSpace(Settings.Default.CallRecordingsSource)) {
                await Task.Run(() => {
                    this._recordingsManager.ImportRecordings(Settings.Default.CallRecordingsSource);

                });
            }

            this._recordingsManager.StatusUpdated -= RecordingsManagerOnStatusUpdated;

            this.loadedLabel.Text = "Loading Viewer";
            this.loadedProgressBar.Style = ProgressBarStyle.Blocks;
            this.Update();

            var callViewer = new HorizonCallRecordingsViewer(this._recordingsManager);
            callViewer.Closed += (s, args) => this.Close();
            callViewer.Shown += (s, args) => this.Hide();

            callViewer.Show();
        }
    }
}