using System.ComponentModel;

namespace Horizon_Call_Recordings_Viewer {
    partial class SelectPersonDialog {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.peopleDataGridView = new System.Windows.Forms.DataGridView();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelectPersonColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.resultsPanel = new System.Windows.Forms.Panel();
            this.actionPanel = new System.Windows.Forms.Panel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.importButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.peopleDataGridView)).BeginInit();
            this.resultsPanel.SuspendLayout();
            this.actionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // peopleDataGridView
            // 
            this.peopleDataGridView.AllowUserToAddRows = false;
            this.peopleDataGridView.AllowUserToDeleteRows = false;
            this.peopleDataGridView.AllowUserToResizeRows = false;
            this.peopleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.peopleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.FirstName, this.LastName, this.PhoneNoColumn, this.SelectPersonColumn});
            this.peopleDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.peopleDataGridView.Location = new System.Drawing.Point(0, 0);
            this.peopleDataGridView.Name = "peopleDataGridView";
            this.peopleDataGridView.ReadOnly = true;
            this.peopleDataGridView.Size = new System.Drawing.Size(442, 255);
            this.peopleDataGridView.TabIndex = 0;
            this.peopleDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.peopleDataGridView_CellContentClick);
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "First Name";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Last Name";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // PhoneNoColumn
            // 
            this.PhoneNoColumn.HeaderText = "Phone No.";
            this.PhoneNoColumn.Name = "PhoneNoColumn";
            this.PhoneNoColumn.ReadOnly = true;
            // 
            // SelectPersonColumn
            // 
            this.SelectPersonColumn.HeaderText = "";
            this.SelectPersonColumn.Name = "SelectPersonColumn";
            this.SelectPersonColumn.ReadOnly = true;
            // 
            // resultsPanel
            // 
            this.resultsPanel.Controls.Add(this.peopleDataGridView);
            this.resultsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultsPanel.Location = new System.Drawing.Point(0, 0);
            this.resultsPanel.Name = "resultsPanel";
            this.resultsPanel.Size = new System.Drawing.Size(442, 255);
            this.resultsPanel.TabIndex = 1;
            // 
            // actionPanel
            // 
            this.actionPanel.Controls.Add(this.importButton);
            this.actionPanel.Controls.Add(this.cancelButton);
            this.actionPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.actionPanel.Location = new System.Drawing.Point(0, 226);
            this.actionPanel.Name = "actionPanel";
            this.actionPanel.Size = new System.Drawing.Size(442, 29);
            this.actionPanel.TabIndex = 1;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Location = new System.Drawing.Point(364, 3);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // importButton
            // 
            this.importButton.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.importButton.Location = new System.Drawing.Point(3, 3);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(75, 23);
            this.importButton.TabIndex = 1;
            this.importButton.Text = "Import Users";
            this.importButton.UseVisualStyleBackColor = true;
            this.importButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // SelectPersonDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 255);
            this.Controls.Add(this.actionPanel);
            this.Controls.Add(this.resultsPanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectPersonDialog";
            this.Text = "Company Directory";
            this.Load += new System.EventHandler(this.SelectPersonDialog_Load);
            ((System.ComponentModel.ISupportInitialize) (this.peopleDataGridView)).EndInit();
            this.resultsPanel.ResumeLayout(false);
            this.actionPanel.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button importButton;

        private System.Windows.Forms.Button cancelButton;

        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNoColumn;
        private System.Windows.Forms.DataGridViewButtonColumn SelectPersonColumn;

        private System.Windows.Forms.DataGridView peopleDataGridView;

        private System.Windows.Forms.Panel actionPanel;
        private System.Windows.Forms.Panel resultsPanel;

        #endregion
    }
}