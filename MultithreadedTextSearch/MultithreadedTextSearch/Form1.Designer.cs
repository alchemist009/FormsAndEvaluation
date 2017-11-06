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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.occurrenceList = new System.Windows.Forms.ListBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.fileName = new System.Windows.Forms.Label();
            this.findWord = new System.Windows.Forms.Label();
            this.instancesFoundBox = new System.Windows.Forms.TextBox();
            this.instanceLabel = new System.Windows.Forms.Label();
            this.totalTimeLabel = new System.Windows.Forms.Label();
            this.totalTimeBox = new System.Windows.Forms.TextBox();
            this.abortButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(98, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(633, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(98, 101);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(633, 20);
            this.textBox2.TabIndex = 1;
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(769, 42);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 2;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            // 
            // occurrenceList
            // 
            this.occurrenceList.FormattingEnabled = true;
            this.occurrenceList.Location = new System.Drawing.Point(30, 183);
            this.occurrenceList.Name = "occurrenceList";
            this.occurrenceList.Size = new System.Drawing.Size(624, 394);
            this.occurrenceList.TabIndex = 4;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(701, 201);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(156, 80);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // fileName
            // 
            this.fileName.AutoSize = true;
            this.fileName.Location = new System.Drawing.Point(30, 48);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(54, 13);
            this.fileName.TabIndex = 6;
            this.fileName.Text = "File Name";
            // 
            // findWord
            // 
            this.findWord.AutoSize = true;
            this.findWord.Location = new System.Drawing.Point(30, 104);
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
            this.instanceLabel.Location = new System.Drawing.Point(660, 482);
            this.instanceLabel.Name = "instanceLabel";
            this.instanceLabel.Size = new System.Drawing.Size(89, 13);
            this.instanceLabel.TabIndex = 9;
            this.instanceLabel.Text = "Instances found :";
            // 
            // totalTimeLabel
            // 
            this.totalTimeLabel.AutoSize = true;
            this.totalTimeLabel.Location = new System.Drawing.Point(660, 539);
            this.totalTimeLabel.Name = "totalTimeLabel";
            this.totalTimeLabel.Size = new System.Drawing.Size(92, 13);
            this.totalTimeLabel.TabIndex = 10;
            this.totalTimeLabel.Text = "Total time taken : ";
            // 
            // totalTimeBox
            // 
            this.totalTimeBox.Location = new System.Drawing.Point(769, 539);
            this.totalTimeBox.Name = "totalTimeBox";
            this.totalTimeBox.Size = new System.Drawing.Size(100, 20);
            this.totalTimeBox.TabIndex = 11;
            // 
            // abortButton
            // 
            this.abortButton.Location = new System.Drawing.Point(701, 333);
            this.abortButton.Name = "abortButton";
            this.abortButton.Size = new System.Drawing.Size(156, 80);
            this.abortButton.TabIndex = 12;
            this.abortButton.Text = "Abort";
            this.abortButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 606);
            this.Controls.Add(this.abortButton);
            this.Controls.Add(this.totalTimeBox);
            this.Controls.Add(this.totalTimeLabel);
            this.Controls.Add(this.instanceLabel);
            this.Controls.Add(this.instancesFoundBox);
            this.Controls.Add(this.findWord);
            this.Controls.Add(this.fileName);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.occurrenceList);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.ListBox occurrenceList;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label fileName;
        private System.Windows.Forms.Label findWord;
        private System.Windows.Forms.TextBox instancesFoundBox;
        private System.Windows.Forms.Label instanceLabel;
        private System.Windows.Forms.Label totalTimeLabel;
        private System.Windows.Forms.TextBox totalTimeBox;
        private System.Windows.Forms.Button abortButton;
    }
}

