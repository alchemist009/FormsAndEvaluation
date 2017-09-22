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

        private void Submit_Click(object sender, EventArgs e)
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
                Proof = Proof.SelectedIndex == 0? true: false,
                DateReceived = string.IsNullOrEmpty(dateBox.Text)? DateTime.Now.ToString("yyyy-MM-dd") : dateBox.Text
            };
           // ls.Add(p);
            FileStream fs = new FileStream(filename, FileMode.Append);
            StreamWriter stream = new StreamWriter(fs);
            stream.WriteLine(p);
            stream.Close();
           // MessageBox.Show("Person added", "RebateForm");

            listBox1.Items.Add(p.GetInfo());
        }

        private void Clear_Click(object sender, EventArgs e) {
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
            dateBox.Clear();
            Proof.Items.Clear();
            Proof.Items.Add("Yes");
            Proof.Items.Add("No");
        }

        private void Delete_Click(object sender, EventArgs e) {

        }

        private void RebateForm_Load(object sender, EventArgs e)
        {
            int iHeight = Screen.PrimaryScreen.WorkingArea.Height - this.Height;
            this.Height += iHeight;
            this.CenterToScreen();

            Proof.Items.Add("Yes");
            Proof.Items.Add("No");
            try {
                using (System.IO.StreamReader sr = new System.IO.StreamReader(@"person.txt"))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        string[] info = line.Split(new char[]{'\t'});
                        Person p = new Person(){
                            FirstName = info[0],
                            MiddleInitial = info[1][0],
                            LastName = info[2],
                            AddressLine1 = info[3],
                            AddressLine2 = info[4],
                            City = info[5],
                            State = info[6],
                            ZipCode = info[7],
                            Email = info[9],
                            PhoneNumber = info[8],
                            Proof = info[10] == "True"? true: false,
                            DateReceived = info[11]
                        };
                        listBox1.Items.Add(p.GetInfo());
                    }
                }
            } catch (FileNotFoundException ex) {
                File.Create(@"person.txt");
            }
        }

        private void RebateForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Closing form.", "Goodbye");
        }

        private void Box_populator(object sender, DoWorkEventArgs e) {
            //ThreadSafe(listBox1.Items.Clear);
            //listBox1.Items.Clear();
            using (System.IO.StreamReader sr = new System.IO.StreamReader(@"person.txt"))
            {
                while (!sr.EndOfStream)
                {
                    string[] info = sr.ReadLine().Split(new char[]{'\t'});
                    Person p = new Person(){
                        FirstName = info[0],
                        MiddleInitial = info[1][0],
                        LastName = info[2],
                        AddressLine1 = info[3],
                        AddressLine2 = info[4],
                        City = info[5],
                        State = info[6],
                        ZipCode = info[7],
                        Email = info[8],
                        PhoneNumber = info[9],
                        Proof = Convert.ToBoolean(info[9]),
                        //DateReceived = Convert.ToDateTime(info[10])
                    };
                    listBox1.Items.Add(p.GetInfo());
                }
            }
        }
    }
}
