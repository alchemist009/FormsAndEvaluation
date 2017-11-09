namespace MultithreadedTextSearch
{
    partial class Form1
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
            this.selectedFile = new System.Windows.Forms.TextBox();
            this.searchWord = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.fileName = new System.Windows.Forms.Label();
            this.findWord = new System.Windows.Forms.Label();
            this.instancesFoundBox = new System.Windows.Forms.TextBox();
            this.instanceLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.listView1 = new System.Windows.Forms.ListView();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectedFile
            // 
            this.selectedFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selectedFile.Location = new System.Drawing.Point(83, 42);
            this.selectedFile.Name = "selectedFile";
            this.selectedFile.Size = new System.Drawing.Size(633, 20);
            this.selectedFile.TabIndex = 0;
            // 
            // searchWord
            // 
            this.searchWord.Location = new System.Drawing.Point(83, 98);
            this.searchWord.Name = "searchWord";
            this.searchWord.Size = new System.Drawing.Size(633, 20);
            this.searchWord.TabIndex = 1;
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(748, 42);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 2;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(694, 199);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(156, 80);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // fileName
            // 
            this.fileName.AutoSize = true;
            this.fileName.Location = new System.Drawing.Point(12, 42);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(63, 13);
            this.fileName.TabIndex = 6;
            this.fileName.Text = "File Name : ";
            // 
            // findWord
            // 
            this.findWord.AutoSize = true;
            this.findWord.Location = new System.Drawing.Point(12, 101);
            this.findWord.Name = "findWord";
            this.findWord.Size = new System.Drawing.Size(65, 13);
            this.findWord.TabIndex = 7;
            this.findWord.Text = "Search for : ";
            // 
            // instancesFoundBox
            // 
            this.instancesFoundBox.Location = new System.Drawing.Point(769, 475);
            this.instancesFoundBox.Name = "instancesFoundBox";
            this.instancesFoundBox.Size = new System.Drawing.Size(100, 20);
            this.instancesFoundBox.TabIndex = 8;
            // 
            // instanceLabel
            // 
            this.instanceLabel.AutoSize = true;
            this.instanceLabel.Location = new System.Drawing.Point(663, 475);
            this.instanceLabel.Name = "instanceLabel";
            this.instanceLabel.Size = new System.Drawing.Size(89, 13);
            this.instanceLabel.TabIndex = 9;
            this.instanceLabel.Text = "Instances found :";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(694, 331);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(156, 80);
            this.clearButton.TabIndex = 12;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            this.openFileDialog2.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog2_FileOk_1);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 584);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(878, 22);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.Location = new System.Drawing.Point(15, 183);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(603, 394);
            this.listView1.TabIndex = 14;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Tag = "Line no.";
            this.columnHeader1.Text = "Line no.";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Tag = "Phrase found";
            this.columnHeader2.Text = "Line found";
            this.columnHeader2.Width = 500;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 606);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.instanceLabel);
            this.Controls.Add(this.instancesFoundBox);
            this.Controls.Add(this.findWord);
            this.Controls.Add(this.fileName);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.searchWord);
            this.Controls.Add(this.selectedFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox selectedFile;
        private System.Windows.Forms.TextBox searchWord;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label fileName;
        private System.Windows.Forms.Label findWord;
        private System.Windows.Forms.TextBox instancesFoundBox;
        private System.Windows.Forms.Label instanceLabel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}

