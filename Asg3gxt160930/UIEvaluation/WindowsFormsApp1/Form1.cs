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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string file;
        int lineCount;
        string DETAILS_FILE = @"Details.txt";
        public Form1()
        {
            InitializeComponent();
        }
        

        private void browse_Click(object sender, EventArgs e)
        {
            int size = -1;
            DialogResult result = openFileDialog1.ShowDialog();
            if(result == DialogResult.OK)
            {
                file = openFileDialog1.FileName;
                try
                {
                    lineCount = File.ReadLines(file).Count();
                    //string text = File.ReadAllText(file);
                    //size = text.Length;
                }
                catch(IOException)
                {

                }
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void runButton_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(DETAILS_FILE, FileMode.Append);
            StreamWriter stream = new StreamWriter(fs);

            string line = File.ReadLines(file).Skip(lineCount - 1).Take(1).First();

            stream.Write(line);

            stream.Close();

        }
    }
}
