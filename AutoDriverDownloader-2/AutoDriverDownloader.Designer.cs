namespace AutoDriverDownloader_2
{
    partial class AutoDriverDownloader
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutoDriverDownloader));
            this.Title = new System.Windows.Forms.Label();
            this.infoBox = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.driverListBox = new System.Windows.Forms.CheckedListBox();
            this.driverListLbl = new System.Windows.Forms.Label();
            this.downloadBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(240, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(301, 29);
            this.Title.TabIndex = 0;
            this.Title.Text = "Auto Driver Downloader 2";
            // 
            // infoBox
            // 
            this.infoBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.infoBox.Location = new System.Drawing.Point(29, 94);
            this.infoBox.MinimumSize = new System.Drawing.Size(285, 310);
            this.infoBox.Name = "infoBox";
            this.infoBox.Padding = new System.Windows.Forms.Padding(3);
            this.infoBox.Size = new System.Drawing.Size(285, 310);
            this.infoBox.TabIndex = 1;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(28, 60);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(110, 31);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // driverListBox
            // 
            this.driverListBox.FormattingEnabled = true;
            this.driverListBox.Location = new System.Drawing.Point(586, 94);
            this.driverListBox.Margin = new System.Windows.Forms.Padding(0);
            this.driverListBox.MinimumSize = new System.Drawing.Size(202, 310);
            this.driverListBox.Name = "driverListBox";
            this.driverListBox.Size = new System.Drawing.Size(202, 310);
            this.driverListBox.TabIndex = 3;
            // 
            // driverListLbl
            // 
            this.driverListLbl.AutoSize = true;
            this.driverListLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driverListLbl.Location = new System.Drawing.Point(581, 66);
            this.driverListLbl.Name = "driverListLbl";
            this.driverListLbl.Size = new System.Drawing.Size(181, 25);
            this.driverListLbl.TabIndex = 4;
            this.driverListLbl.Text = "Detected Driver List";
            // 
            // downloadBtn
            // 
            this.downloadBtn.Location = new System.Drawing.Point(586, 410);
            this.downloadBtn.Margin = new System.Windows.Forms.Padding(0);
            this.downloadBtn.Name = "downloadBtn";
            this.downloadBtn.Size = new System.Drawing.Size(202, 28);
            this.downloadBtn.TabIndex = 5;
            this.downloadBtn.Text = "Download Selected";
            this.downloadBtn.UseVisualStyleBackColor = true;
            this.downloadBtn.Click += new System.EventHandler(this.downloadBtn_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(332, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 310);
            this.label1.TabIndex = 6;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // AutoDriverDownloader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(814, 457);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.downloadBtn);
            this.Controls.Add(this.driverListLbl);
            this.Controls.Add(this.driverListBox);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.infoBox);
            this.Controls.Add(this.Title);
            this.Name = "AutoDriverDownloader";
            this.Text = "Auto Driver Downloader 2";
            this.Load += new System.EventHandler(this.AutoDriverDownloader_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label infoBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.CheckedListBox driverListBox;
        private System.Windows.Forms.Label driverListLbl;
        private System.Windows.Forms.Button downloadBtn;
        private System.Windows.Forms.Label label1;
    }
}

