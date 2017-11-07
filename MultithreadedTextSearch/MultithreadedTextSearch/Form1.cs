using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MultithreadedTextSearch
{
    public partial class Form1 : Form
    {
        string file;
        string TEXT_FILE;
        int lineCount;
        public Form1()
        {
            InitializeComponent();
        }


        private void browseButton_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog2.ShowDialog();
            if(result == DialogResult.OK)
            {
                file = openFileDialog2.FileName;
                try
                {
                    lineCount = File.ReadAllLines(file).Count();
                    selectedFile.Text = file;
                }
                catch(IOException)
                {

                }
            }
                
        }


        private void openFileDialog2_FileOk_1(object sender, CancelEventArgs e)
        {

        }
    }
}
