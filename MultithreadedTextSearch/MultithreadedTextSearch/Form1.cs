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
        Boolean button_flag = false;

        public Form1()
        {
            InitializeComponent();
            b_worker = new BackgroundWorker();

            b_worker.DoWork += new DoWorkEventHandler(b_worker_Scan_File);
            b_worker.WorkerSupportsCancellation = true;
            b_worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(b_worker_RunWorkerCompleted);
            b_worker.ProgressChanged += new ProgressChangedEventHandler(b_worker_ProgressChanged);
            listView1.View = View.Details;
            toolStripStatusLabel1.Text = "Ready for operation";
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
                toolStripStatusLabel1.Text = "Search cancelled";
                statusStrip1.Invalidate();
                statusStrip1.Refresh();
            }

            else if(e.Error != null)
            {
                toolStripStatusLabel1.Text = "Error while performing search";
                statusStrip1.Invalidate();
                statusStrip1.Refresh();
            }

            else
            {
                toolStripStatusLabel1.Text = "Search finished";
                statusStrip1.Invalidate();
                statusStrip1.Refresh();
            }
        }


        async void b_worker_Scan_File(object sender, DoWorkEventArgs e)
        {
            List<String []> strList = new List<string []>();
            string line;
            int lineNumber = 0;
            System.IO.StreamReader file1 = new System.IO.StreamReader(file);
            while((line = file1.ReadLine()) != null)
            {
                if(b_worker.CancellationPending == true)
                {
                    e.Cancel = true;
                    break;
                }

                else
                {
                    if(line.ToLowerInvariant().Contains(searchWord.Text))
                    {
                        string[] foundInstance = {(lineNumber + 1).ToString()};
                        ListViewItem lstitem = new ListViewItem(foundInstance);
                        lstitem.SubItems.Add(line);
                        BeginInvoke
                        ((MethodInvoker)delegate
                            {
                                listView1.Items.Add(lstitem);                                
                            }
                        );
                    }
                }
                lineNumber++;
                await Task.Delay(1);
            }
            BeginInvoke
                ((MethodInvoker)delegate
                    {
                        searchButton.Text = "Search";
                        button_flag = !(button_flag);
                        clearButton.Enabled = true;
                        instancesFoundBox.Text = listView1.Items.Count.ToString();
                    }
                );           
        }

        private void b_worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }


        private void searchButton_Click(object sender, EventArgs e)
        {
            if (button_flag == false)
            {
                b_worker.RunWorkerAsync();
                searchButton.Text = "Abort";
                button_flag = true;
                toolStripStatusLabel1.Text = "Performing search...";
                clearButton.Enabled = false;
            }
            else
            {
                b_worker.CancelAsync();
                searchButton.Text = "Search";
                button_flag = false;
                toolStripStatusLabel1.Text = "Ready for operation";
                clearButton.Enabled = true;
                instancesFoundBox.Text = (listView1.Items.Count).ToString();
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            instancesFoundBox.Text = "";
        }


        private void openFileDialog2_FileOk_1(object sender, CancelEventArgs e)
        {

        }
    }
}
