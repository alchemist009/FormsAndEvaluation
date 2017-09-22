using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Threading;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class RebateForm : Form
    {

        BackgroundWorker worker;

        public RebateForm()
        {
            InitializeComponent();
            worker = new BackgroundWorker();
            worker.DoWork += new DoWorkEventHandler(Box_populator);
            worker.RunWorkerAsync();
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

        private void Clear_Click(object sender, EventArgs e) {
            FirstName.Clear();
            Middleinitial.Clear();
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
        }

        private void RebateForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Closing form.", "Goodbye");
        }

        private void Box_populator(object sender, DoWorkEventArgs e) {
            ThreadSafe(listBox1.Items.Clear);
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
                        DateReceived = Convert.ToDateTime(info[10])
                    };
                    listBox1.Items.Add(p.GetInfo());
                }
            }
        }

        public static void ThreadSafe(Action action) {
            Dispatcher.CurrentDispatcher.Invoke(DispatcherPriority.Normal, 
                new MethodInvoker(action));
        }
    }
}
