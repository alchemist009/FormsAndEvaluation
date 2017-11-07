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

        BackgroundWorker b_worker;

        public Form1()
        {
            InitializeComponent();
            b_worker = new BackgroundWorker();

            b_worker.DoWork += new DoWorkEventHandler(b_worker_DoWork);
            b_worker.WorkerSupportsCancellation = true;
            b_worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(b_worker_RunWorkerCompleted);
        }


        void b_worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            if(e.Cancelled)
            {
                statusStrip1.Text = "Search cancelled";
                statusStrip1.Invalidate();
                statusStrip1.Refresh();
            }

            else if(e.Error != null)
            {
                statusStrip1.Text = "Error while performing search";
                statusStrip1.Invalidate();
                statusStrip1.Refresh();
            }

            else
            {
                statusStrip1.Text = "Search completed";
                statusStrip1.Invalidate();
                statusStrip1.Refresh();
            }

            searchButton.Enabled = true;
            abortButton.Enabled = false;
        }


        void b_worker_DoWork(object sender, DoWorkEventArgs e)
        {
            for(int i = 0; i < lineCount; i++)
            {
                /*
                 * 
                 * Finish this
                */
            }
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

        private void searchButton_Click(object sender, EventArgs e)
        {

        }


        private void openFileDialog2_FileOk_1(object sender, CancelEventArgs e)
        {

        }
    }
}
