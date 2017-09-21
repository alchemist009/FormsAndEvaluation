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

namespace WindowsFormsApp2
{
    public partial class RebateForm : Form
    {
        public RebateForm()
        {
            InitializeComponent();
        }

        //List<Person> ls = new List<Person>();
        string filename = @"person.txt";

        private void Add_Click(object sender, EventArgs e)
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
                Proof = true,
                DateReceived = default(DateTime)
            };
           // ls.Add(p);
            FileStream fs = new FileStream(filename, FileMode.Append);
            StreamWriter stream = new StreamWriter(fs);
            stream.WriteLine(p);
            stream.Close();
           // MessageBox.Show("Person added", "RebateForm");
        }

        private void RebateForm_Load(object sender, EventArgs e)
        {
            int iHeight = Screen.PrimaryScreen.WorkingArea.Height - this.Height;
            this.Height += iHeight;
            this.CenterToScreen();

            Proof.Items.Add("Yes");
            Proof.Items.Add("No");
        }

        private void RebateForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Closing form.", "Goodbye");
        }
    }
}
