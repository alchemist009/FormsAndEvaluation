/// =========================================================================================================================================
/// AUTHOR :        Gunjan Tomer
/// CREATE DATE :   11/10/2017
/// PURPOSE :       Multithreaded Text Search
/// 
/// DESCRIPTION :
///This program takes as input a plain text file and performs a search for a specific word or string in it.
///A browse button allows selecting a file from the disk and another box takes as input the string ti be searched in the file.
///There two buttons in the layout's right side, one to begin search and another to clear the search results once the search concludes 
///or the process is cancelled. Once the search button is clicked the backgroundworker starts searching the file line by line and
///populates the listview with the results. The search button now changes to "Abort" and can be clicked at any time to cancel the search.
///Once the search concludes a chime sound is played. The current status of the program is always displayed in the status bar at the 
///bottom. A text box is also provided to keep a count of the matching results found till that point in time.
///
///===========================================================================================================================================
///
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
using System.Media;

namespace MultithreadedTextSearch
{
    public partial class Form1 : Form
    {
        string file;
        int lineCount;
        private System.ComponentModel.BackgroundWorker b_worker;
        bool button_flag = false;
        private bool closePending;

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

        /**
         * Method to display an openFileDialog when the Browse button is clicked.
         * Reads a file from the disk an displays its path in the selectedFile 
         * text box.
         */
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

        /**
         * The main functionality of the backgroundworker. The file selected is stored in a 
         * StreamReader object and read line by line to find a match all the while updating
         * the listview and the instance count box.
         * 
         */ 
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
                                instancesFoundBox.Text = listView1.Items.Count.ToString();
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
                    }
                );
            SoundPlayer simpleSound = new SoundPlayer(MultithreadedTextSearch.Properties.Resources.chimes);
            simpleSound.Play();
            toolStripStatusLabel1.Text = "Search finished";
        }


        private void b_worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }


        /**
         * Method to implement the Search/Abort functionality. Each consecutive press of the button 
         * changes the mode of operation of the button.
         * The status bar is used to display the current mode od operation.
         */ 
        private void searchButton_Click(object sender, EventArgs e)
        {
            if(file == null)
            {
                MessageBox.Show("Please select a file before starting the search", "Error");
                
            }
            else
            {
                if (button_flag == false)
                {
                    listView1.Items.Clear();
                    b_worker.RunWorkerAsync();
                    searchButton.Text = "Abort";
                    button_flag = true;
                    toolStripStatusLabel1.Text = "Performing search...";
                    clearButton.Enabled = false;
                }
                else
                {
                    b_worker.CancelAsync();
                    button_flag = false;
                    searchButton.Text = "Search";
                    toolStripStatusLabel1.Text = "Ready for operation";
                    clearButton.Enabled = true;
                    instancesFoundBox.Text = (listView1.Items.Count).ToString();
                }
            }
           
        }


        /**
         * Method to implement Clear button functionality. 
         * Pressing the clear button either after search completion or after 
         * having aborted the search clears the listview and the instance count box
         * to get ready for a new search.
         */
        private void clearButton_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            instancesFoundBox.Text = "";
        }


        private void openFileDialog2_FileOk_1(object sender, CancelEventArgs e)
        {

        }

        /*
         *Method which runs once the backgroundworker finishes operations or  
         * is interrupted before search completion. 
         */
        void b_worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (closePending) this.Close();
            closePending = false;

            if (e.Cancelled)
            {
                toolStripStatusLabel1.Text = "Search cancelled";
                statusStrip1.Invalidate();
                statusStrip1.Refresh();
            }

            else if (e.Error != null)
            {
                toolStripStatusLabel1.Text = "Error while performing search";
                statusStrip1.Invalidate();
                statusStrip1.Refresh();
            }
        }

        /**
         * Method to handle the form closing event. If the form is closed in the midst of
         * a search operation, the backgroundworker is cancelled before closing the form.
         * 
         */
        protected override void OnFormClosing(FormClosingEventArgs e)
        {

            if (b_worker.IsBusy)
            {
                closePending = true;
                b_worker.CancelAsync();
                e.Cancel = true;
                this.Enabled = false;
                return;
            }
            base.OnFormClosing(e);
        }

    }
}
