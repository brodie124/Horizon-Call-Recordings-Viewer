using System.ComponentModel;

namespace Horizon_Call_Recordings_Viewer {
    partial class LoadingScreen {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
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
            this.loadedProgressBar = new System.Windows.Forms.ProgressBar();
            this.loadedLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loadedProgressBar
            // 
            this.loadedProgressBar.Location = new System.Drawing.Point(12, 49);
            this.loadedProgressBar.MarqueeAnimationSpeed = 20;
            this.loadedProgressBar.Name = "loadedProgressBar";
            this.loadedProgressBar.Size = new System.Drawing.Size(518, 23);
            this.loadedProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.loadedProgressBar.TabIndex = 0;
            // 
            // loadedLabel
            // 
            this.loadedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.loadedLabel.Location = new System.Drawing.Point(12, 9);
            this.loadedLabel.Name = "loadedLabel";
            this.loadedLabel.Size = new System.Drawing.Size(518, 37);
            this.loadedLabel.TabIndex = 1;
            this.loadedLabel.Text = "Loaded: 0 / 0";
            this.loadedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoadingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 78);
            this.Controls.Add(this.loadedLabel);
            this.Controls.Add(this.loadedProgressBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoadingScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Horizon: Call Recordings Viewer";
            this.Load += new System.EventHandler(this.LoadingScreen_Load);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label loadedLabel;
        private System.Windows.Forms.ProgressBar loadedProgressBar;

        #endregion
    }
}