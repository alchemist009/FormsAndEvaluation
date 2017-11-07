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
using System.Text.RegularExpressions;

namespace MultithreadedTextSearch
{
    public partial class Form1 : Form
    {
        string file;
        string TEXT_FILE;
        int lineCount;
        private System.ComponentModel.BackgroundWorker b_worker;

        public Form1()
        {
            InitializeComponent();
            b_worker = new BackgroundWorker();

            b_worker.DoWork += new DoWorkEventHandler(b_worker_Scan_File);
            b_worker.WorkerSupportsCancellation = true;
            b_worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(b_worker_RunWorkerCompleted);
            b_worker.ProgressChanged += new ProgressChangedEventHandler(b_worker_ProgressChanged);
           // b_worker.RunWorkerAsync(listView1);
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog2.ShowDialog();
            if (result == DialogResult.OK)
            {
                file = openFileDialog2.FileName;
                try
                {
                    lineCount = File.ReadAllLines(file).Count();
                    selectedFile.Text = file;
                }
                catch (IOException)
                {
                    statusStrip1.Text = "File read error";
                }
            }

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


        void b_worker_Scan_File(object sender, DoWorkEventArgs e)
        {
            List<String []> strList = new List<string []>();
            string line;
            int lineNumber = 0;
            System.IO.StreamReader file1 = new System.IO.StreamReader(file);
            while((line = file1.ReadLine()) != null)
            {
                lineNumber++;
                if(b_worker.CancellationPending == true)
                {
                    e.Cancel = true;
                    break;
                }

                else
                {
                    if(line.ToLowerInvariant().Contains(searchWord.Text))
                    {
                        string[] foundInstance = { lineNumber.ToString(), line };
                        var listViewItem = new ListViewItem(foundInstance);
                        listView1.Items.Add(listViewItem);
                        // strList.Add(foundInstance);
                        // b_worker.ReportProgress(0, strList[0]);
                    }
                }
            }
        }

        private void b_worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
           // var listViewItem = new ListViewItem();

        }


        private void searchButton_Click(object sender, EventArgs e)
        {
            searchButton.Enabled = false;
            abortButton.Enabled = true;
            b_worker.RunWorkerAsync();
        }

        private void abortButton_Click(object sender, EventArgs e)
        {
            this.b_worker.CancelAsync();

            abortButton.Enabled = false;
        }


        private void openFileDialog2_FileOk_1(object sender, CancelEventArgs e)
        {

        }
    }
}
