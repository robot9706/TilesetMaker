namespace TilesetMaker
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.imageSourceFolder = new System.Windows.Forms.TextBox();
            this.imageSourceFolderBrowse = new System.Windows.Forms.Button();
            this.imageSourceFolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.includedFiles = new System.Windows.Forms.ListBox();
            this.entryWInfo = new System.Windows.Forms.Label();
            this.entryHInfo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.excludedFiles = new System.Windows.Forms.ListBox();
            this.generateXML = new System.Windows.Forms.CheckBox();
            this.generate = new System.Windows.Forms.Button();
            this.saveOutput = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Image source folder:";
            // 
            // imageSourceFolder
            // 
            this.imageSourceFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imageSourceFolder.BackColor = System.Drawing.Color.White;
            this.imageSourceFolder.Location = new System.Drawing.Point(154, 12);
            this.imageSourceFolder.Name = "imageSourceFolder";
            this.imageSourceFolder.ReadOnly = true;
            this.imageSourceFolder.Size = new System.Drawing.Size(627, 22);
            this.imageSourceFolder.TabIndex = 1;
            // 
            // imageSourceFolderBrowse
            // 
            this.imageSourceFolderBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imageSourceFolderBrowse.Location = new System.Drawing.Point(787, 11);
            this.imageSourceFolderBrowse.Name = "imageSourceFolderBrowse";
            this.imageSourceFolderBrowse.Size = new System.Drawing.Size(75, 24);
            this.imageSourceFolderBrowse.TabIndex = 2;
            this.imageSourceFolderBrowse.Text = "Browse";
            this.imageSourceFolderBrowse.UseVisualStyleBackColor = true;
            this.imageSourceFolderBrowse.Click += new System.EventHandler(this.imageSourceFolderBrowse_Click);
            // 
            // includedFiles
            // 
            this.includedFiles.FormattingEnabled = true;
            this.includedFiles.ItemHeight = 16;
            this.includedFiles.Location = new System.Drawing.Point(9, 21);
            this.includedFiles.Name = "includedFiles";
            this.includedFiles.Size = new System.Drawing.Size(233, 324);
            this.includedFiles.TabIndex = 4;
            // 
            // entryWInfo
            // 
            this.entryWInfo.AutoSize = true;
            this.entryWInfo.Location = new System.Drawing.Point(6, 31);
            this.entryWInfo.Name = "entryWInfo";
            this.entryWInfo.Size = new System.Drawing.Size(81, 16);
            this.entryWInfo.TabIndex = 8;
            this.entryWInfo.Tag = "Entry width: {0}";
            this.entryWInfo.Text = "Entry width: -";
            // 
            // entryHInfo
            // 
            this.entryHInfo.AutoSize = true;
            this.entryHInfo.Location = new System.Drawing.Point(6, 59);
            this.entryHInfo.Name = "entryHInfo";
            this.entryHInfo.Size = new System.Drawing.Size(87, 16);
            this.entryHInfo.TabIndex = 9;
            this.entryHInfo.Tag = "Entry height: {0}";
            this.entryHInfo.Text = "Entry height: -";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.entryWInfo);
            this.groupBox1.Controls.Add(this.entryHInfo);
            this.groupBox1.Location = new System.Drawing.Point(541, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 100);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Atlas info";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.includedFiles);
            this.groupBox2.Location = new System.Drawing.Point(21, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(254, 355);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Included files";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.excludedFiles);
            this.groupBox3.Location = new System.Drawing.Point(281, 40);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(254, 355);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Excluded files";
            // 
            // excludedFiles
            // 
            this.excludedFiles.FormattingEnabled = true;
            this.excludedFiles.ItemHeight = 16;
            this.excludedFiles.Location = new System.Drawing.Point(9, 21);
            this.excludedFiles.Name = "excludedFiles";
            this.excludedFiles.Size = new System.Drawing.Size(233, 324);
            this.excludedFiles.TabIndex = 4;
            // 
            // generateXML
            // 
            this.generateXML.AutoSize = true;
            this.generateXML.Location = new System.Drawing.Point(636, 322);
            this.generateXML.Name = "generateXML";
            this.generateXML.Size = new System.Drawing.Size(142, 20);
            this.generateXML.TabIndex = 4;
            this.generateXML.Text = "Generate data XML";
            this.generateXML.UseVisualStyleBackColor = true;
            // 
            // generate
            // 
            this.generate.Enabled = false;
            this.generate.Location = new System.Drawing.Point(634, 348);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(147, 36);
            this.generate.TabIndex = 13;
            this.generate.Text = "Create atlas";
            this.generate.UseVisualStyleBackColor = true;
            this.generate.Click += new System.EventHandler(this.generate_Click);
            // 
            // saveOutput
            // 
            this.saveOutput.Filter = "Image files|*.png;*.jpg;*.bmp|Png files|*.png|Bmp files|*.bmp|Jpg files|*.jpg|All" +
    " files|*.*";
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(876, 402);
            this.Controls.Add(this.generateXML);
            this.Controls.Add(this.generate);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.imageSourceFolderBrowse);
            this.Controls.Add(this.imageSourceFolder);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tileset maker";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox imageSourceFolder;
        private System.Windows.Forms.Button imageSourceFolderBrowse;
        private System.Windows.Forms.FolderBrowserDialog imageSourceFolderBrowser;
        private System.Windows.Forms.ListBox includedFiles;
        private System.Windows.Forms.Label entryWInfo;
        private System.Windows.Forms.Label entryHInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox excludedFiles;
        private System.Windows.Forms.CheckBox generateXML;
        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.SaveFileDialog saveOutput;
    }
}

