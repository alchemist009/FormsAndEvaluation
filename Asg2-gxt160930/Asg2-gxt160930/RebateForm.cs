/**
 * Submission for CS6326 Assignment 2: Rebate Form
 * 
 * @author: Gunjan Tomer
 * 
 * Main file: RebateForm.cs
 * Object creation: Person.cs
 * 
 * Program interface consists of all the requisite text boxes for data input along with two more to keep track of start
 * and end times during data entry.
 * Every instance of data entered gets saved in a Person object and written to a text file
 * All fields have consraints for the type of input allowed e.g. only letters in names, numbers in Zip codes and phone numbers etc
 * The Names and Phone numbers for each record are displayed in the listBox to the left every time the Submit button is clicked
 * Clicking on an item in the listBox populates all the fields after fetching the corresponding record from the records file
 * Clicking the Clear button clears out all the fields and sets the DateReceived to today's date
 * All fields in the record populated from the listBox can be modified and written back to the file.
 * A new record with the same Name as an existing record can't be added whether new or modification of an old one.
 * The Delete button deletes the selected record from the listBox and the text file.
 * Limits on string lengths are set as required by the assignment question
 * 
 * 
 * 
 * Some guidelines for using the form:
 * 
 * Clicking on Delete without any previously existing records will throw an error.
 * Clicking on the Submit button after first clicking on a listBox entry to populate the text fields and then deleting it will cause a crash.
 * 
**/

using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Asg2
{
    public partial class RebateForm : Form
    {
        bool modifyFlag = false;                        //Flag used to check if user wants to modify existing record or add a new one
        string FILE_NAME = @"CS6326Asg2.txt";           //Text file to store records

        public RebateForm()
        {
            InitializeComponent();
            FirstName.TextChanged += new EventHandler(this.FirstName_TextChanged);      //Event handler for text change in First Name text box
            Phone.KeyPress += new KeyPressEventHandler(this.Phone_KeyPress);            //Event handler for validation of phone number
            Zip.KeyPress += new KeyPressEventHandler(this.Zip_KeyPress);                //Event handler for validation of Zip
            FirstName.KeyPress += new KeyPressEventHandler(this.FirstName_KeyPress);        //Event handler for validation of FirstName
            Lastname.KeyPress += new KeyPressEventHandler(this.LastName_KeyPress);          //Event handler for validation of LastName
            Middleinitial.KeyPress += new KeyPressEventHandler(this.MiddleInitial_KeyPress);        //Event handler for validation of MiddleInitial
            State.KeyPress += new KeyPressEventHandler(this.State_KeyPress);            //Event handler for validation of State
        }

        /**
         * 
         * Save user data to object and write to text file using Streamreader and streamwriter
         * Checks for duplicate record using the complete name
         * Regex used to validate email before allowing submit
         * listBox entries used to populate text boxes based on SelectedIndex
         * End Time registered and written to object on Submit click
         * 
         * 
         * */
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
                EndText.Text = DateTime.Now.ToString();
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
                    DateReceived = date.Value.ToString(),
                    TimeStarted = StartText.Text,
                    TimeEnded = EndText.Text
                };
                // ls.Add(p);
                FileStream fs = new FileStream(FILE_NAME, FileMode.Append);
                StreamWriter stream = new StreamWriter(fs);

                if (rgx.IsMatch(Email.Text))
                {
                    stream.WriteLine(p);
                    Records.Items.Add(p.GetInfo());

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
                int index = Records.SelectedIndex;
                string[] lines = File.ReadAllLines(FILE_NAME);
                string[] newlines = new string[lines.Length - 1];
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

        /**
         * Clear button to remove entries from all text boxes
         * Also sets the date back to the default in the DateTimePicker
         * Repopulates the Proof of Purchase listbox with Yes/No values
         * 
         * */
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
            StartText.Clear();
            EndText.Clear();
            modifyFlag = false;                   //Reset flag if data is cleared and can no longer be used to add modified entry
        }

        /**
         * Delete a record from the ones displayed in the listbox
         * Reads all lines except the one to be deleted and writes to new file
         * Refreshes the listBox
         * 
         **/
        private void Delete_Click(object sender, EventArgs e)
        {

            int index = Records.SelectedIndex;
            string[] lines = File.ReadAllLines(FILE_NAME);
            string[] newlines = new string[lines.Length - 1];
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
        /**
         * Function to display updated entries in the listBox
         * 
         **/
        private void RefreshListBox()
        {
            Records.Items.Clear();
            string[] lines = File.ReadAllLines(FILE_NAME);
            for (int i = 0; i < lines.Length; ++i)
            {
                Person p = Person.GetObject(lines[i].Split(new char[] { '\t' }));
                Records.Items.Add(p.GetInfo());
            }
        }

        /**
         * Centers the form to the middle of screen
         * Adjusts height based on working area height
         * Checks if the records text file exist or not
         * Creates a new file if not found
         **/
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

        /**
         * Populates the text boxes in the form from text file records
         * Uses object of class Person
         * 
         **/
        private void listBox1_IndexChanged(object sender, EventArgs e)
        {
            int index = Records.SelectedIndex;
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
            StartText.Text = p.TimeStarted;
            EndText.Text = p.TimeEnded;
        }

        /**
         * Track when the user starts entering text in the FirstName box
         * Display the start time in StartText box
         * 
         **/
        private void FirstName_TextChanged(object sender, EventArgs e)
        {
            StartText.Text = DateTime.Now.ToString();
        }

        //Validation function allowing only numbers in Phone field
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

        //Validation function allowing only numbers in Zip field

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
        // Validate FirstName field to allow only A-Z characters
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

        // Validate MiddleInitial field to allow only A-Z characters
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

        // Validate LastName field to allow only A-Z characters
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

        // Validate State field to allow only A-Z characters
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

    }
}

