namespace Horizon_Call_Recordings_Viewer {
    partial class HorizonCallRecordingsViewer {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HorizonCallRecordingsViewer));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.selectCallRecordingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectTemporaryFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.setExportNameFormatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectedToolStripDropDown = new System.Windows.Forms.ToolStripDropDownButton();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectNoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.showAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportSingleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.playSelectedFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.extractToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cleanUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resultsGridView = new System.Windows.Forms.DataGridView();
            this.resultsPanel = new System.Windows.Forms.Panel();
            this.callerSelectionDialogButton = new System.Windows.Forms.Button();
            this.dateToCheckBox = new System.Windows.Forms.CheckBox();
            this.timeToCheckBox = new System.Windows.Forms.CheckBox();
            this.timeFromCheckBox = new System.Windows.Forms.CheckBox();
            this.dateFromCheckBox = new System.Windows.Forms.CheckBox();
            this.applySearchButton = new System.Windows.Forms.Button();
            this.recipientNumberTextbox = new System.Windows.Forms.TextBox();
            this.callerNumberTextbox = new System.Windows.Forms.TextBox();
            this.directionPanel = new System.Windows.Forms.Panel();
            this.callerDirectionBothRadioButton = new System.Windows.Forms.RadioButton();
            this.callerDirectionOutboundRadioButton = new System.Windows.Forms.RadioButton();
            this.callerDirectionInboundRadioButton = new System.Windows.Forms.RadioButton();
            this.timeFromDatePicker = new System.Windows.Forms.DateTimePicker();
            this.timeToDatePicker = new System.Windows.Forms.DateTimePicker();
            this.dateToDatePicker = new System.Windows.Forms.DateTimePicker();
            this.dateFromDatePicker = new System.Windows.Forms.DateTimePicker();
            this.recipientNumberLabel = new System.Windows.Forms.Label();
            this.callerNumberLabel = new System.Windows.Forms.Label();
            this.callDirectionLabel = new System.Windows.Forms.Label();
            this.timeToLabel = new System.Windows.Forms.Label();
            this.timeFromLabel = new System.Windows.Forms.Label();
            this.dateToLabel = new System.Windows.Forms.Label();
            this.dateFromLabel = new System.Windows.Forms.Label();
            this.miniToolStrip = new System.Windows.Forms.StatusStrip();
            this.statusToolStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.versionStatusStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.resultsGridContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.playSelectedFileContextMenuToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.exportSelectedFileContextMenuToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.resultsGridView)).BeginInit();
            this.resultsPanel.SuspendLayout();
            this.directionPanel.SuspendLayout();
            this.miniToolStrip.SuspendLayout();
            this.resultsGridContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.CanOverflow = false;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.toolStripButton1, this.selectedToolStripDropDown, this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStrip1.Size = new System.Drawing.Size(612, 21);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.TabStop = true;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.selectCallRecordingsToolStripMenuItem, this.selectTemporaryFolderToolStripMenuItem, this.toolStripSeparator3, this.setExportNameFormatToolStripMenuItem, this.toolStripSeparator2, this.exitToolStripMenuItem});
            this.toolStripButton1.Image = ((System.Drawing.Image) (resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(38, 18);
            this.toolStripButton1.Text = "File";
            // 
            // selectCallRecordingsToolStripMenuItem
            // 
            this.selectCallRecordingsToolStripMenuItem.Name = "selectCallRecordingsToolStripMenuItem";
            this.selectCallRecordingsToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.selectCallRecordingsToolStripMenuItem.Text = "Select Call Recordings";
            this.selectCallRecordingsToolStripMenuItem.Click += new System.EventHandler(this.selectCallRecordingsToolStripMenuItem_Click);
            // 
            // selectTemporaryFolderToolStripMenuItem
            // 
            this.selectTemporaryFolderToolStripMenuItem.Name = "selectTemporaryFolderToolStripMenuItem";
            this.selectTemporaryFolderToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.selectTemporaryFolderToolStripMenuItem.Text = "Select Temporary Folder";
            this.selectTemporaryFolderToolStripMenuItem.Click += new System.EventHandler(this.selectTemporaryFolderToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(200, 6);
            // 
            // setExportNameFormatToolStripMenuItem
            // 
            this.setExportNameFormatToolStripMenuItem.Name = "setExportNameFormatToolStripMenuItem";
            this.setExportNameFormatToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.setExportNameFormatToolStripMenuItem.Text = "Set Export Name Format";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(200, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // selectedToolStripDropDown
            // 
            this.selectedToolStripDropDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.selectedToolStripDropDown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.selectAllToolStripMenuItem, this.selectNoneToolStripMenuItem, this.toolStripSeparator4, this.showAllToolStripMenuItem, this.viewToolStripMenuItem, this.toolStripSeparator1, this.exportToolStripMenuItem, this.exportSingleToolStripMenuItem, this.toolStripSeparator5, this.playSelectedFileToolStripMenuItem});
            this.selectedToolStripDropDown.Image = ((System.Drawing.Image) (resources.GetObject("selectedToolStripDropDown.Image")));
            this.selectedToolStripDropDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.selectedToolStripDropDown.Name = "selectedToolStripDropDown";
            this.selectedToolStripDropDown.Size = new System.Drawing.Size(81, 18);
            this.selectedToolStripDropDown.Text = "Selected (0)";
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.selectAllToolStripMenuItem.Text = "Select All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // selectNoneToolStripMenuItem
            // 
            this.selectNoneToolStripMenuItem.Name = "selectNoneToolStripMenuItem";
            this.selectNoneToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.selectNoneToolStripMenuItem.Text = "Select None";
            this.selectNoneToolStripMenuItem.Click += new System.EventHandler(this.selectNoneToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(175, 6);
            // 
            // showAllToolStripMenuItem
            // 
            this.showAllToolStripMenuItem.Name = "showAllToolStripMenuItem";
            this.showAllToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.showAllToolStripMenuItem.Text = "Show All";
            this.showAllToolStripMenuItem.Click += new System.EventHandler(this.showAllToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.viewToolStripMenuItem.Text = "Show Only Selected";
            this.viewToolStripMenuItem.Click += new System.EventHandler(this.viewToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(175, 6);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.exportToolStripMenuItem.Text = "Export Archive";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // exportSingleToolStripMenuItem
            // 
            this.exportSingleToolStripMenuItem.Name = "exportSingleToolStripMenuItem";
            this.exportSingleToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.exportSingleToolStripMenuItem.Text = "Export Audio File";
            this.exportSingleToolStripMenuItem.Click += new System.EventHandler(this.exportSingleToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(175, 6);
            // 
            // playSelectedFileToolStripMenuItem
            // 
            this.playSelectedFileToolStripMenuItem.Enabled = false;
            this.playSelectedFileToolStripMenuItem.Name = "playSelectedFileToolStripMenuItem";
            this.playSelectedFileToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.playSelectedFileToolStripMenuItem.Text = "Play Selected File";
            this.playSelectedFileToolStripMenuItem.Click += new System.EventHandler(this.playSelectedFileToolStripMenuItem_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.extractToolStripMenuItem, this.cleanUpToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image) (resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(60, 18);
            this.toolStripDropDownButton1.Text = "Control";
            this.toolStripDropDownButton1.Visible = false;
            // 
            // extractToolStripMenuItem
            // 
            this.extractToolStripMenuItem.Name = "extractToolStripMenuItem";
            this.extractToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.extractToolStripMenuItem.Text = "Extract";
            this.extractToolStripMenuItem.Click += new System.EventHandler(this.extractToolStripMenuItem_Click);
            // 
            // cleanUpToolStripMenuItem
            // 
            this.cleanUpToolStripMenuItem.Name = "cleanUpToolStripMenuItem";
            this.cleanUpToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.cleanUpToolStripMenuItem.Text = "Clean Up";
            this.cleanUpToolStripMenuItem.Click += new System.EventHandler(this.cleanUpToolStripMenuItem_Click);
            // 
            // resultsGridView
            // 
            this.resultsGridView.AllowUserToAddRows = false;
            this.resultsGridView.AllowUserToDeleteRows = false;
            this.resultsGridView.AllowUserToOrderColumns = true;
            this.resultsGridView.AllowUserToResizeRows = false;
            this.resultsGridView.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.resultsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.resultsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultsGridView.Location = new System.Drawing.Point(12, 195);
            this.resultsGridView.MultiSelect = false;
            this.resultsGridView.Name = "resultsGridView";
            this.resultsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.resultsGridView.Size = new System.Drawing.Size(585, 347);
            this.resultsGridView.TabIndex = 2;
            this.resultsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.resultsGridView_CellContentClick);
            this.resultsGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.resultsGridView_CellEndEdit);
            this.resultsGridView.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.resultsGridView_CellMouseUp);
            // 
            // resultsPanel
            // 
            this.resultsPanel.Controls.Add(this.callerSelectionDialogButton);
            this.resultsPanel.Controls.Add(this.dateToCheckBox);
            this.resultsPanel.Controls.Add(this.timeToCheckBox);
            this.resultsPanel.Controls.Add(this.timeFromCheckBox);
            this.resultsPanel.Controls.Add(this.dateFromCheckBox);
            this.resultsPanel.Controls.Add(this.applySearchButton);
            this.resultsPanel.Controls.Add(this.recipientNumberTextbox);
            this.resultsPanel.Controls.Add(this.callerNumberTextbox);
            this.resultsPanel.Controls.Add(this.directionPanel);
            this.resultsPanel.Controls.Add(this.timeFromDatePicker);
            this.resultsPanel.Controls.Add(this.timeToDatePicker);
            this.resultsPanel.Controls.Add(this.dateToDatePicker);
            this.resultsPanel.Controls.Add(this.dateFromDatePicker);
            this.resultsPanel.Controls.Add(this.recipientNumberLabel);
            this.resultsPanel.Controls.Add(this.callerNumberLabel);
            this.resultsPanel.Controls.Add(this.callDirectionLabel);
            this.resultsPanel.Controls.Add(this.timeToLabel);
            this.resultsPanel.Controls.Add(this.timeFromLabel);
            this.resultsPanel.Controls.Add(this.dateToLabel);
            this.resultsPanel.Controls.Add(this.dateFromLabel);
            this.resultsPanel.Controls.Add(this.miniToolStrip);
            this.resultsPanel.Controls.Add(this.resultsGridView);
            this.resultsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultsPanel.Location = new System.Drawing.Point(0, 21);
            this.resultsPanel.Name = "resultsPanel";
            this.resultsPanel.Size = new System.Drawing.Size(612, 591);
            this.resultsPanel.TabIndex = 4;
            // 
            // callerSelectionDialogButton
            // 
            this.callerSelectionDialogButton.Location = new System.Drawing.Point(244, 97);
            this.callerSelectionDialogButton.Name = "callerSelectionDialogButton";
            this.callerSelectionDialogButton.Size = new System.Drawing.Size(30, 20);
            this.callerSelectionDialogButton.TabIndex = 26;
            this.callerSelectionDialogButton.Text = "...";
            this.callerSelectionDialogButton.UseVisualStyleBackColor = true;
            this.callerSelectionDialogButton.Click += new System.EventHandler(this.callerSelectionDialogButton_Click);
            // 
            // dateToCheckBox
            // 
            this.dateToCheckBox.Location = new System.Drawing.Point(576, 22);
            this.dateToCheckBox.Name = "dateToCheckBox";
            this.dateToCheckBox.Size = new System.Drawing.Size(15, 20);
            this.dateToCheckBox.TabIndex = 25;
            this.dateToCheckBox.UseVisualStyleBackColor = true;
            this.dateToCheckBox.CheckStateChanged += new System.EventHandler(this.ControlStatusCheckBox_CheckedChanged);
            // 
            // timeToCheckBox
            // 
            this.timeToCheckBox.Location = new System.Drawing.Point(576, 60);
            this.timeToCheckBox.Name = "timeToCheckBox";
            this.timeToCheckBox.Size = new System.Drawing.Size(15, 20);
            this.timeToCheckBox.TabIndex = 24;
            this.timeToCheckBox.UseVisualStyleBackColor = true;
            this.timeToCheckBox.CheckStateChanged += new System.EventHandler(this.ControlStatusCheckBox_CheckedChanged);
            // 
            // timeFromCheckBox
            // 
            this.timeFromCheckBox.Location = new System.Drawing.Point(259, 60);
            this.timeFromCheckBox.Name = "timeFromCheckBox";
            this.timeFromCheckBox.Size = new System.Drawing.Size(15, 20);
            this.timeFromCheckBox.TabIndex = 23;
            this.timeFromCheckBox.UseVisualStyleBackColor = true;
            this.timeFromCheckBox.CheckStateChanged += new System.EventHandler(this.ControlStatusCheckBox_CheckedChanged);
            // 
            // dateFromCheckBox
            // 
            this.dateFromCheckBox.Location = new System.Drawing.Point(259, 22);
            this.dateFromCheckBox.Name = "dateFromCheckBox";
            this.dateFromCheckBox.Size = new System.Drawing.Size(15, 21);
            this.dateFromCheckBox.TabIndex = 22;
            this.dateFromCheckBox.UseVisualStyleBackColor = true;
            this.dateFromCheckBox.CheckStateChanged += new System.EventHandler(this.ControlStatusCheckBox_CheckedChanged);
            // 
            // applySearchButton
            // 
            this.applySearchButton.Location = new System.Drawing.Point(476, 134);
            this.applySearchButton.Name = "applySearchButton";
            this.applySearchButton.Size = new System.Drawing.Size(94, 23);
            this.applySearchButton.TabIndex = 2;
            this.applySearchButton.Text = "Apply";
            this.applySearchButton.UseVisualStyleBackColor = true;
            this.applySearchButton.Click += new System.EventHandler(this.applySearchButton_Click);
            // 
            // recipientNumberTextbox
            // 
            this.recipientNumberTextbox.Location = new System.Drawing.Point(429, 97);
            this.recipientNumberTextbox.MaxLength = 30;
            this.recipientNumberTextbox.Name = "recipientNumberTextbox";
            this.recipientNumberTextbox.Size = new System.Drawing.Size(141, 20);
            this.recipientNumberTextbox.TabIndex = 21;
            this.recipientNumberTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormControl_KeyPress);
            // 
            // callerNumberTextbox
            // 
            this.callerNumberTextbox.Location = new System.Drawing.Point(112, 97);
            this.callerNumberTextbox.MaxLength = 30;
            this.callerNumberTextbox.Name = "callerNumberTextbox";
            this.callerNumberTextbox.Size = new System.Drawing.Size(126, 20);
            this.callerNumberTextbox.TabIndex = 20;
            this.callerNumberTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormControl_KeyPress);
            // 
            // directionPanel
            // 
            this.directionPanel.Controls.Add(this.callerDirectionBothRadioButton);
            this.directionPanel.Controls.Add(this.callerDirectionOutboundRadioButton);
            this.directionPanel.Controls.Add(this.callerDirectionInboundRadioButton);
            this.directionPanel.Location = new System.Drawing.Point(112, 134);
            this.directionPanel.Name = "directionPanel";
            this.directionPanel.Size = new System.Drawing.Size(241, 23);
            this.directionPanel.TabIndex = 19;
            // 
            // callerDirectionBothRadioButton
            // 
            this.callerDirectionBothRadioButton.Checked = true;
            this.callerDirectionBothRadioButton.Location = new System.Drawing.Point(0, 0);
            this.callerDirectionBothRadioButton.Name = "callerDirectionBothRadioButton";
            this.callerDirectionBothRadioButton.Size = new System.Drawing.Size(51, 24);
            this.callerDirectionBothRadioButton.TabIndex = 15;
            this.callerDirectionBothRadioButton.TabStop = true;
            this.callerDirectionBothRadioButton.Text = "Both";
            this.callerDirectionBothRadioButton.UseVisualStyleBackColor = true;
            // 
            // callerDirectionOutboundRadioButton
            // 
            this.callerDirectionOutboundRadioButton.Location = new System.Drawing.Point(168, 0);
            this.callerDirectionOutboundRadioButton.Name = "callerDirectionOutboundRadioButton";
            this.callerDirectionOutboundRadioButton.Size = new System.Drawing.Size(73, 24);
            this.callerDirectionOutboundRadioButton.TabIndex = 18;
            this.callerDirectionOutboundRadioButton.Text = "Outbound";
            this.callerDirectionOutboundRadioButton.UseVisualStyleBackColor = true;
            // 
            // callerDirectionInboundRadioButton
            // 
            this.callerDirectionInboundRadioButton.Location = new System.Drawing.Point(72, 0);
            this.callerDirectionInboundRadioButton.Name = "callerDirectionInboundRadioButton";
            this.callerDirectionInboundRadioButton.Size = new System.Drawing.Size(69, 24);
            this.callerDirectionInboundRadioButton.TabIndex = 16;
            this.callerDirectionInboundRadioButton.Text = "Inbound";
            this.callerDirectionInboundRadioButton.UseVisualStyleBackColor = true;
            // 
            // timeFromDatePicker
            // 
            this.timeFromDatePicker.CustomFormat = "HH:mm";
            this.timeFromDatePicker.Location = new System.Drawing.Point(112, 60);
            this.timeFromDatePicker.Name = "timeFromDatePicker";
            this.timeFromDatePicker.Size = new System.Drawing.Size(141, 20);
            this.timeFromDatePicker.TabIndex = 14;
            this.timeFromDatePicker.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormControl_KeyPress);
            // 
            // timeToDatePicker
            // 
            this.timeToDatePicker.CustomFormat = "HH:mm";
            this.timeToDatePicker.Location = new System.Drawing.Point(429, 60);
            this.timeToDatePicker.Name = "timeToDatePicker";
            this.timeToDatePicker.Size = new System.Drawing.Size(141, 20);
            this.timeToDatePicker.TabIndex = 13;
            this.timeToDatePicker.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormControl_KeyPress);
            // 
            // dateToDatePicker
            // 
            this.dateToDatePicker.Location = new System.Drawing.Point(429, 22);
            this.dateToDatePicker.Name = "dateToDatePicker";
            this.dateToDatePicker.Size = new System.Drawing.Size(141, 20);
            this.dateToDatePicker.TabIndex = 12;
            this.dateToDatePicker.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormControl_KeyPress);
            // 
            // dateFromDatePicker
            // 
            this.dateFromDatePicker.Location = new System.Drawing.Point(112, 22);
            this.dateFromDatePicker.Name = "dateFromDatePicker";
            this.dateFromDatePicker.Size = new System.Drawing.Size(141, 20);
            this.dateFromDatePicker.TabIndex = 11;
            this.dateFromDatePicker.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormControl_KeyPress);
            // 
            // recipientNumberLabel
            // 
            this.recipientNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.recipientNumberLabel.Location = new System.Drawing.Point(304, 95);
            this.recipientNumberLabel.Name = "recipientNumberLabel";
            this.recipientNumberLabel.Size = new System.Drawing.Size(110, 23);
            this.recipientNumberLabel.TabIndex = 10;
            this.recipientNumberLabel.Text = "Recipient No.";
            // 
            // callerNumberLabel
            // 
            this.callerNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.callerNumberLabel.Location = new System.Drawing.Point(15, 95);
            this.callerNumberLabel.Name = "callerNumberLabel";
            this.callerNumberLabel.Size = new System.Drawing.Size(80, 23);
            this.callerNumberLabel.TabIndex = 9;
            this.callerNumberLabel.Text = "Caller No.";
            // 
            // callDirectionLabel
            // 
            this.callDirectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.callDirectionLabel.Location = new System.Drawing.Point(15, 134);
            this.callDirectionLabel.Name = "callDirectionLabel";
            this.callDirectionLabel.Size = new System.Drawing.Size(128, 23);
            this.callDirectionLabel.TabIndex = 8;
            this.callDirectionLabel.Text = "Direction:";
            // 
            // timeToLabel
            // 
            this.timeToLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.timeToLabel.Location = new System.Drawing.Point(343, 61);
            this.timeToLabel.Name = "timeToLabel";
            this.timeToLabel.Size = new System.Drawing.Size(128, 23);
            this.timeToLabel.TabIndex = 7;
            this.timeToLabel.Text = "Time To:";
            // 
            // timeFromLabel
            // 
            this.timeFromLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.timeFromLabel.Location = new System.Drawing.Point(15, 61);
            this.timeFromLabel.Name = "timeFromLabel";
            this.timeFromLabel.Size = new System.Drawing.Size(128, 23);
            this.timeFromLabel.TabIndex = 6;
            this.timeFromLabel.Text = "Time From:";
            // 
            // dateToLabel
            // 
            this.dateToLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.dateToLabel.Location = new System.Drawing.Point(343, 22);
            this.dateToLabel.Name = "dateToLabel";
            this.dateToLabel.Size = new System.Drawing.Size(128, 23);
            this.dateToLabel.TabIndex = 5;
            this.dateToLabel.Text = "Date To:";
            // 
            // dateFromLabel
            // 
            this.dateFromLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.dateFromLabel.Location = new System.Drawing.Point(15, 22);
            this.dateFromLabel.Name = "dateFromLabel";
            this.dateFromLabel.Size = new System.Drawing.Size(128, 23);
            this.dateFromLabel.TabIndex = 4;
            this.dateFromLabel.Text = "Date From:";
            // 
            // miniToolStrip
            // 
            this.miniToolStrip.AutoSize = false;
            this.miniToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.statusToolStripLabel, this.versionStatusStripLabel});
            this.miniToolStrip.Location = new System.Drawing.Point(0, 569);
            this.miniToolStrip.Name = "miniToolStrip";
            this.miniToolStrip.Size = new System.Drawing.Size(612, 22);
            this.miniToolStrip.TabIndex = 3;
            // 
            // statusToolStripLabel
            // 
            this.statusToolStripLabel.Name = "statusToolStripLabel";
            this.statusToolStripLabel.Size = new System.Drawing.Size(39, 17);
            this.statusToolStripLabel.Text = "Ready";
            // 
            // versionStatusStripLabel
            // 
            this.versionStatusStripLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.versionStatusStripLabel.Name = "versionStatusStripLabel";
            this.versionStatusStripLabel.Size = new System.Drawing.Size(527, 17);
            this.versionStatusStripLabel.Spring = true;
            this.versionStatusStripLabel.Text = "v1.2";
            this.versionStatusStripLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // resultsGridContextMenuStrip
            // 
            this.resultsGridContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.playSelectedFileContextMenuToolStrip, this.exportSelectedFileContextMenuToolStrip});
            this.resultsGridContextMenuStrip.Name = "contextMenuStrip1";
            this.resultsGridContextMenuStrip.Size = new System.Drawing.Size(166, 48);
            // 
            // playSelectedFileContextMenuToolStrip
            // 
            this.playSelectedFileContextMenuToolStrip.Name = "playSelectedFileContextMenuToolStrip";
            this.playSelectedFileContextMenuToolStrip.Size = new System.Drawing.Size(165, 22);
            this.playSelectedFileContextMenuToolStrip.Text = "Play Recording";
            this.playSelectedFileContextMenuToolStrip.Click += new System.EventHandler(this.playSelectedFileContextMenuToolStrip_Click);
            // 
            // exportSelectedFileContextMenuToolStrip
            // 
            this.exportSelectedFileContextMenuToolStrip.Name = "exportSelectedFileContextMenuToolStrip";
            this.exportSelectedFileContextMenuToolStrip.Size = new System.Drawing.Size(165, 22);
            this.exportSelectedFileContextMenuToolStrip.Text = "Export Recording";
            this.exportSelectedFileContextMenuToolStrip.Click += new System.EventHandler(this.exportSelectedFileContextMenuToolStrip_Click);
            // 
            // HorizonCallRecordingsViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(612, 612);
            this.Controls.Add(this.resultsPanel);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(15, 15);
            this.MaximizeBox = false;
            this.Name = "HorizonCallRecordingsViewer";
            this.Text = "Horizon: Call Recordings Viewer";
            this.Load += new System.EventHandler(this.HorizonCallRecordingsViewer_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.resultsGridView)).EndInit();
            this.resultsPanel.ResumeLayout(false);
            this.resultsPanel.PerformLayout();
            this.directionPanel.ResumeLayout(false);
            this.miniToolStrip.ResumeLayout(false);
            this.miniToolStrip.PerformLayout();
            this.resultsGridContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ToolStripMenuItem exportSelectedFileContextMenuToolStrip;

        private System.Windows.Forms.ToolStripMenuItem playSelectedFileContextMenuToolStrip;

        private System.Windows.Forms.ContextMenuStrip resultsGridContextMenuStrip;

        private System.Windows.Forms.Button callerSelectionDialogButton;

        private System.Windows.Forms.ToolStripMenuItem playSelectedFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;

        private System.Windows.Forms.StatusStrip miniToolStrip;

        private System.Windows.Forms.ToolStripMenuItem showAllToolStripMenuItem;

        private System.Windows.Forms.ToolStripStatusLabel versionStatusStripLabel;

        private System.Windows.Forms.ToolStripMenuItem exportSingleToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem selectNoneToolStripMenuItem;

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;

        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;

        private System.Windows.Forms.ToolStripMenuItem setExportNameFormatToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem selectTemporaryFolderToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem selectCallRecordingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;

        private System.Windows.Forms.ToolStripDropDownButton selectedToolStripDropDown;

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;

        private System.Windows.Forms.DataGridView resultsGridView;

        private System.Windows.Forms.CheckBox dateFromCheckBox;
        private System.Windows.Forms.CheckBox dateToCheckBox;
        private System.Windows.Forms.CheckBox timeFromCheckBox;
        private System.Windows.Forms.CheckBox timeToCheckBox;

        private System.Windows.Forms.Button applySearchButton;

        private System.Windows.Forms.ToolStripMenuItem cleanUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extractToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;

        private System.Windows.Forms.TextBox callerNumberTextbox;
        private System.Windows.Forms.TextBox recipientNumberTextbox;

        private System.Windows.Forms.Panel directionPanel;

        private System.Windows.Forms.RadioButton callerDirectionBothRadioButton;
        private System.Windows.Forms.RadioButton callerDirectionInboundRadioButton;
        private System.Windows.Forms.RadioButton callerDirectionOutboundRadioButton;

        private System.Windows.Forms.Label callDirectionLabel;
        private System.Windows.Forms.Label callerNumberLabel;
        private System.Windows.Forms.DateTimePicker dateFromDatePicker;
        private System.Windows.Forms.DateTimePicker dateToDatePicker;
        private System.Windows.Forms.Label dateToLabel;
        private System.Windows.Forms.Label recipientNumberLabel;
        private System.Windows.Forms.DateTimePicker timeFromDatePicker;
        private System.Windows.Forms.Label timeFromLabel;
        private System.Windows.Forms.DateTimePicker timeToDatePicker;
        private System.Windows.Forms.Label timeToLabel;

        private System.Windows.Forms.Label dateFromLabel;

        private System.Windows.Forms.ToolStripStatusLabel statusToolStripLabel;

        private System.Windows.Forms.Panel resultsPanel;

        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButton1;

        #endregion
    }
}