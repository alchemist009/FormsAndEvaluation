namespace WindowsFormsApp2
{
    partial class RebateForm
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
            this.Add = new System.Windows.Forms.Button();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Middleinitial = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AddLine1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Lastname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AddLine2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.City = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.State = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Zip = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dateBox = new System.Windows.Forms.TextBox();
            this.Proof = new System.Windows.Forms.ComboBox();
            this.Clear = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Submit
            // 
            this.Add.Location = new System.Drawing.Point(545, 412);
            this.Add.Margin = new System.Windows.Forms.Padding(2);
            this.Add.Name = "Submit";
            this.Add.Size = new System.Drawing.Size(56, 19);
            this.Add.TabIndex = 13;
            this.Add.Text = "Submit";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Submit_Click);
            // 
            // FirstName
            // 
            this.FirstName.Location = new System.Drawing.Point(545, 32);
            this.FirstName.Margin = new System.Windows.Forms.Padding(2);
            this.FirstName.MaxLength = 20;
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(103, 20);
            this.FirstName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(542, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "First Name";
            // 
            // Middleinitial
            // 
            this.Middleinitial.Location = new System.Drawing.Point(709, 32);
            this.Middleinitial.Margin = new System.Windows.Forms.Padding(2);
            this.Middleinitial.MaxLength = 1;
            this.Middleinitial.Name = "Middleinitial";
            this.Middleinitial.Size = new System.Drawing.Size(24, 20);
            this.Middleinitial.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(706, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Middle Initial";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(542, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Address line 1";
            // 
            // AddLine1
            // 
            this.AddLine1.Location = new System.Drawing.Point(545, 97);
            this.AddLine1.Margin = new System.Windows.Forms.Padding(2);
            this.AddLine1.MaxLength = 35;
            this.AddLine1.Name = "AddLine1";
            this.AddLine1.Size = new System.Drawing.Size(103, 20);
            this.AddLine1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(802, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Last Name";
            // 
            // Lastname
            // 
            this.Lastname.Location = new System.Drawing.Point(805, 32);
            this.Lastname.Margin = new System.Windows.Forms.Padding(2);
            this.Lastname.MaxLength = 20;
            this.Lastname.Name = "Lastname";
            this.Lastname.Size = new System.Drawing.Size(76, 20);
            this.Lastname.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(706, 72);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Address line 2";
            // 
            // AddLine2
            // 
            this.AddLine2.Location = new System.Drawing.Point(709, 97);
            this.AddLine2.Margin = new System.Windows.Forms.Padding(2);
            this.AddLine2.MaxLength = 35;
            this.AddLine2.Name = "AddLine2";
            this.AddLine2.Size = new System.Drawing.Size(76, 20);
            this.AddLine2.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(802, 72);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "City";
            // 
            // City
            // 
            this.City.Location = new System.Drawing.Point(805, 97);
            this.City.Margin = new System.Windows.Forms.Padding(2);
            this.City.MaxLength = 25;
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(56, 20);
            this.City.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(542, 145);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "State";
            // 
            // State
            // 
            this.State.Location = new System.Drawing.Point(545, 170);
            this.State.Margin = new System.Windows.Forms.Padding(2);
            this.State.MaxLength = 2;
            this.State.Name = "State";
            this.State.Size = new System.Drawing.Size(76, 20);
            this.State.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(706, 145);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Zip Code";
            // 
            // Zip
            // 
            this.Zip.Location = new System.Drawing.Point(709, 170);
            this.Zip.Margin = new System.Windows.Forms.Padding(2);
            this.Zip.MaxLength = 9;
            this.Zip.Name = "Zip";
            this.Zip.Size = new System.Drawing.Size(76, 20);
            this.Zip.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(707, 213);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Phone Number";
            // 
            // Phone
            // 
            this.Phone.Location = new System.Drawing.Point(710, 240);
            this.Phone.Margin = new System.Windows.Forms.Padding(2);
            this.Phone.MaxLength = 21;
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(75, 20);
            this.Phone.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(542, 213);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Email";
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(545, 240);
            this.Email.Margin = new System.Windows.Forms.Padding(2);
            this.Email.MaxLength = 60;
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(103, 20);
            this.Email.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(542, 294);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Proof of Purchase";
            // 
            // dateBox
            // 
            this.dateBox.Location = new System.Drawing.Point(709, 320);
            this.dateBox.Margin = new System.Windows.Forms.Padding(2);
            this.dateBox.MaxLength = 10;
            this.dateBox.Name = "dateBox";
            this.dateBox.Size = new System.Drawing.Size(150, 20);
            this.dateBox.TabIndex = 12;
            
            // 
            // Proof
            // 
            this.Proof.AllowDrop = true;
            this.Proof.FormattingEnabled = true;
            this.Proof.Location = new System.Drawing.Point(545, 319);
            this.Proof.Margin = new System.Windows.Forms.Padding(2);
            this.Proof.Name = "Proof";
            this.Proof.Size = new System.Drawing.Size(92, 21);
            this.Proof.TabIndex = 11;
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(677, 412);
            this.Clear.Margin = new System.Windows.Forms.Padding(2);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(56, 19);
            this.Clear.TabIndex = 14;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(805, 412);
            this.Delete.Margin = new System.Windows.Forms.Padding(2);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(56, 19);
            this.Delete.TabIndex = 15;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(38, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(439, 459);
            this.listBox1.TabIndex = 16;
            // 
            // RebateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 466);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Proof);
            this.Controls.Add(this.dateBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Zip);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.State);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.City);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AddLine2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Lastname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AddLine1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Middleinitial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.Add);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RebateForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RebateForm_FormClosing);
            this.Load += new System.EventHandler(this.RebateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Middleinitial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AddLine1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Lastname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox AddLine2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox City;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox State;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Zip;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Phone;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox dateBox;
        private System.Windows.Forms.ComboBox Proof;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.ListBox listBox1;
    }
}

