namespace AuxiliarySensors
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.b_configLocation = new System.Windows.Forms.Button();
            this.tb_configLocation = new System.Windows.Forms.TextBox();
            this.configBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.lb_ConfigFiles = new System.Windows.Forms.ListBox();
            this.rtb_ConfigFile = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // b_configLocation
            // 
            this.b_configLocation.Location = new System.Drawing.Point(241, 12);
            this.b_configLocation.Name = "b_configLocation";
            this.b_configLocation.Size = new System.Drawing.Size(101, 23);
            this.b_configLocation.TabIndex = 0;
            this.b_configLocation.Text = "Select Config";
            this.b_configLocation.UseVisualStyleBackColor = true;
            this.b_configLocation.Click += new System.EventHandler(this.b_configLocation_Click);
            // 
            // tb_configLocation
            // 
            this.tb_configLocation.Location = new System.Drawing.Point(348, 13);
            this.tb_configLocation.Name = "tb_configLocation";
            this.tb_configLocation.Size = new System.Drawing.Size(440, 23);
            this.tb_configLocation.TabIndex = 1;
            this.tb_configLocation.TextChanged += new System.EventHandler(this.tb_configLocation_TextChanged);
            // 
            // configBrowserDialog
            // 
            this.configBrowserDialog.RootFolder = System.Environment.SpecialFolder.UserProfile;
            // 
            // lb_ConfigFiles
            // 
            this.lb_ConfigFiles.FormattingEnabled = true;
            this.lb_ConfigFiles.ItemHeight = 15;
            this.lb_ConfigFiles.Location = new System.Drawing.Point(12, 12);
            this.lb_ConfigFiles.Name = "lb_ConfigFiles";
            this.lb_ConfigFiles.Size = new System.Drawing.Size(223, 424);
            this.lb_ConfigFiles.TabIndex = 3;
            this.lb_ConfigFiles.SelectedIndexChanged += new System.EventHandler(this.lb_ConfigFiles_SelectedIndexChanged);
            // 
            // rtb_ConfigFile
            // 
            this.rtb_ConfigFile.Location = new System.Drawing.Point(243, 47);
            this.rtb_ConfigFile.Name = "rtb_ConfigFile";
            this.rtb_ConfigFile.Size = new System.Drawing.Size(545, 389);
            this.rtb_ConfigFile.TabIndex = 4;
            this.rtb_ConfigFile.Text = "";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtb_ConfigFile);
            this.Controls.Add(this.lb_ConfigFiles);
            this.Controls.Add(this.tb_configLocation);
            this.Controls.Add(this.b_configLocation);
            this.Name = "Main";
            this.Text = "AuxiliarySensors";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button b_configLocation;
        private TextBox tb_configLocation;
        private FolderBrowserDialog configBrowserDialog;
        private ListBox lb_ConfigFiles;
        private RichTextBox rtb_ConfigFile;
    }
}