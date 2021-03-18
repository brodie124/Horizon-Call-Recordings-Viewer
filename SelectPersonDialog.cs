using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace Horizon_Call_Recordings_Viewer {
    public partial class SelectPersonDialog : Form {

        private List<Person> _peopleList;

        private int _selectedPerson;
        public Person SelectedPerson => _peopleList[_selectedPerson];

        public SelectPersonDialog() {
            InitializeComponent();

            _peopleList = new List<Person>();
            _peopleList.Add(new Person("Brodie", "Pestell", "01246932463"));
            _peopleList.Add(new Person("Pauline", "Hunt", "01246932935"));
            _peopleList.Add(new Person("Andy", "Allen", "01246932937"));
            _peopleList.Add(new Person("Warren", "Heather", "01246932938"));
            _peopleList.Add(new Person("Robyn", "Wilkinson", "01246932464"));
            _peopleList.Add(new Person("David", "Peel", "01134873060"));
        }

        private void RefreshPeopleList() {
            peopleDataGridView.Rows.Clear();
            
            foreach (var person in _peopleList) {
                peopleDataGridView.Rows.Add(new object[] {
                    person.FirstName,
                    person.LastName,
                    person.PhoneNo,
                    "Select"
                });
            }
        }

        private void SelectPersonDialog_Load(object sender, EventArgs e) {
            

        }

        private void PersonSelectButton_OnClick(object sender, int row) {
            this._selectedPerson = row;

            this.DialogResult = DialogResult.OK;

            this.Close();
        }

        private void peopleDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            //If button column was pressed, pass it on
            if(e.ColumnIndex == 3)
                PersonSelectButton_OnClick(sender, e.RowIndex);
        }

        private void cancelButton_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void importButton_Click(object sender, EventArgs e) {
            var fileDialog = new OpenFileDialog();
            fileDialog.Filter = "CSV (.csv)|*.csv";
            var dialogResult = fileDialog.ShowDialog();

            if (dialogResult != DialogResult.OK)
                return;

            if (!File.Exists(fileDialog.FileName)) {
                MessageBox.Show("Invalid file selected!", "Horizon - Call Recording Viewer", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            try {
                foreach (var line in File.ReadLines(fileDialog.FileName)) {
                    if (string.IsNullOrWhiteSpace(line.Trim()))
                        continue;

                    var segments = line.Split(',');
                    if (segments.Length != 3)
                        continue;

                    var person = new Person(segments[0].Trim(), segments[1].Trim(), segments[2].Trim());
                    this._peopleList.Add(person);
                }
            }
            catch (IOException ex) {
                MessageBox.Show("Unable to open the selected file! Is something else using it?", "Horizon - Call Recording Viewer", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            RefreshPeopleList();
        }
    }
}