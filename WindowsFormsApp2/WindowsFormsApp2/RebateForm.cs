using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApp2
{
    public partial class RebateForm : Form
    {
        bool modifyFlag = false;
        string FILE_NAME = @"person.txt";

        public RebateForm()
        {
            InitializeComponent();
            FirstName.TextChanged += new EventHandler(this.FirstName_TextChanged);
            Phone.KeyPress += new KeyPressEventHandler(this.Phone_KeyPress);
            Zip.KeyPress += new KeyPressEventHandler(this.Zip_KeyPress);
            FirstName.KeyPress += new KeyPressEventHandler(this.FirstName_KeyPress);
            Lastname.KeyPress += new KeyPressEventHandler(this.LastName_KeyPress);
            Middleinitial.KeyPress += new KeyPressEventHandler(this.MiddleInitial_KeyPress);
            State.KeyPress += new KeyPressEventHandler(this.State_KeyPress);
        }

        //List<Person> ls = new List<Person>();

        private void Submit_Click(object sender, EventArgs e)
        {
            Regex rgx = new Regex(@"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+.[a-zA-Z]{2,4}$");

            bool foundFlag = false;
            string testString = FirstName.Text + "\t" + Middleinitial.Text + "\t" + Lastname.Text;
            if (File.ReadAllText(FILE_NAME).Contains(testString))
            {
                foundFlag = true;
            }

            if (!foundFlag || modifyFlag)
            {
                Person p = new Person()
                {
                    FirstName = FirstName.Text,
                    LastName = Lastname.Text,
                    MiddleInitial = Middleinitial.Text[0],
                    AddressLine1 = AddLine1.Text,
                    AddressLine2 = AddLine2.Text,
                    City = City.Text,
                    State = State.Text,
                    ZipCode = Zip.Text,
                    PhoneNumber = Phone.Text,
                    Email = Email.Text,
                    Proof = Proof.SelectedIndex == 0 ? true : false,
                    DateReceived = date.Value.ToString()
                };
                // ls.Add(p);
                FileStream fs = new FileStream(FILE_NAME, FileMode.Append);
                StreamWriter stream = new StreamWriter(fs);

                if (rgx.IsMatch(Email.Text))
                {
                    stream.WriteLine(p);
                    EndTime.Text = "End Time: " + DateTime.Now.ToString();
                    listBox1.Items.Add(p.GetInfo());

                }

                else
                {
                    MessageBox.Show("Please enter a valid Email", "Error");

                }

                stream.Close();

            }
            else
            {
                MessageBox.Show("Record already exists", "Error");
            }

            if (modifyFlag)
            {
                int index = listBox1.SelectedIndex;
                string[] lines = File.ReadAllLines(FILE_NAME);
                string[] newlines = new string[lines.Length - 1];
                //iint lineCount = lines.Length;
                int j = 0;
                for (int i = 0; i < lines.Length; i++)
                {
                    if (i != index)
                    {
                        newlines[j++] = lines[i];
                    }

                }
                File.WriteAllLines(FILE_NAME, newlines);
                RefreshListBox();
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            FirstName.Clear();
            Middleinitial.Clear();
            Lastname.Clear();
            AddLine1.Clear();
            AddLine2.Clear();
            City.Clear();
            State.Clear();
            Zip.Clear();
            Email.Clear();
            Phone.Clear();
            date.Value = DateTime.Today;
            Proof.Items.Clear();
            Proof.Items.Add("Yes");
            Proof.Items.Add("No");

            modifyFlag = false;
        }

        private void Delete_Click(object sender, EventArgs e)
        {

            int index = listBox1.SelectedIndex;
            string[] lines = File.ReadAllLines(FILE_NAME);
            string[] newlines = new string[lines.Length - 1];
            //iint lineCount = lines.Length;
            int j = 0;
            for (int i = 0; i < lines.Length; i++)
            {
                if (i != index)
                {
                    newlines[j++] = lines[i];
                }

            }
            File.WriteAllLines(FILE_NAME, newlines);
            RefreshListBox();
        }

        private void RefreshListBox()
        {
            listBox1.Items.Clear();
            string[] lines = File.ReadAllLines(FILE_NAME);
            for (int i = 0; i < lines.Length; ++i)
            {
                Person p = Person.GetObject(lines[i].Split(new char[] { '\t' }));
                listBox1.Items.Add(p.GetInfo());
            }
        }

        private void RebateForm_Load(object sender, EventArgs e)
        {
            int iHeight = Screen.PrimaryScreen.WorkingArea.Height - this.Height;
            this.Height += iHeight;
            this.CenterToScreen();

            Proof.Items.Add("Yes");
            Proof.Items.Add("No");
            if (File.Exists(FILE_NAME))
            {
                RefreshListBox();
            }
            else
            {
                File.Create(FILE_NAME).Close();
            }
        }

        private void RebateForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //MessageBox.Show("Closing form.", "Goodbye");
        }

        private void listBox1_IndexChanged(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            modifyFlag = true;
            string line = File.ReadAllLines(FILE_NAME)[index];
            string[] split = line.Split(new char[] { '\t' });
            Person p = Person.GetObject(split);
            FirstName.Text = p.FirstName;
            Middleinitial.Text = p.MiddleInitial + "";
            Lastname.Text = p.LastName;
            AddLine1.Text = p.AddressLine1;
            AddLine2.Text = p.AddressLine2;
            City.Text = p.City;
            State.Text = p.State;
            Zip.Text = p.ZipCode;
            Email.Text = p.Email;
            Phone.Text = p.PhoneNumber;
            Proof.SelectedIndex = p.Proof ? 0 : 1;
            date.Text = p.DateReceived;

        }

        private void FirstName_TextChanged(object sender, EventArgs e)
        {
            StartTime.Text = "Start time: " + DateTime.Now.ToString();
        }

        private void Phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == '\b') //The  character represents a backspace
            {
                e.Handled = false; //Do not reject the input
            }
            else
            {
                e.Handled = true; //Reject the input
            }

        }


        private void Zip_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == '\b') //The  character represents a backspace
            {
                e.Handled = false; //Do not reject the input
            }
            else
            {
                e.Handled = true; //Reject the input
            }
        }

        private void FirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar)) //The  character represents a backspace
            {
                e.Handled = true; //Do not reject the input
            }
            else
            {
                e.Handled = false; //Reject the input
            }
        }

        private void MiddleInitial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar)) //The  character represents a backspace
            {
                e.Handled = true; //Do not reject the input
            }
            else
            {
                e.Handled = false; //Reject the input
            }
        }


        private void LastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar)) //The  character represents a backspace
            {
                e.Handled = true; //Do not reject the input
            }
            else
            {
                e.Handled = false; //Reject the input
            }
        }

        private void State_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar)) //The  character represents a backspace
            {
                e.Handled = true; //Do not reject the input
            }
            else
            {
                e.Handled = false; //Reject the input
            }
        }


        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

    }
}

