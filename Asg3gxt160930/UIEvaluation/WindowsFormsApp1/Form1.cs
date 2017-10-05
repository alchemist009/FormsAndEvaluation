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
            //int size = -1;
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
            string backline = File.ReadLines(file).Skip(lineCount - 1).Take(1).First();                 //Read line for number of backspaces
            TimeSpan minTime = TimeSpan.MaxValue, maxTime = TimeSpan.MinValue, avgTime = TimeSpan.Zero, 
            sumTime = TimeSpan.Zero, interdiff, maxInterDiff = TimeSpan.MinValue, minInterDiff = TimeSpan.MaxValue;
            List<TimeSpan> timeList = new List<TimeSpan>();
            List<DateTime> timeList2 = new List<DateTime>();
            List<DateTime> timeList3 = new List<DateTime>();
            List<DateTime> timeList4 = new List<DateTime>();
            string[] records = File.ReadAllLines(file);
            int recordsFileLength = records.Length;

            for (int i=0; i < recordsFileLength - 1; i++)
            {
                string[] temp = records[i].Split('\t');
                //MessageBox.Show(temp.Length + " ", "Show");
                DateTime startTime = Convert.ToDateTime(temp[12]);
                DateTime endTime = Convert.ToDateTime(temp[13]);
                timeList2.Add(startTime);
                timeList3.Add(endTime);
                TimeSpan diff1 = endTime - startTime;
                maxTime = (diff1 > maxTime) ? diff1 : maxTime;
                minTime = (diff1 < minTime) ? diff1 : minTime;
                timeList.Add(diff1);
            }

            for(int i=1; i < records.Length-1; i++)
            {
                interdiff = timeList2[i] - timeList3[i - 1];
                maxInterDiff = (interdiff > maxInterDiff) ? interdiff : maxInterDiff;
                minInterDiff = (interdiff < minInterDiff) ? interdiff : minInterDiff;
                timeList4.Add(interdiff);
            }



            double doubleAverageTicks = timeList.Average(timeSpan => timeSpan.Ticks);
            long longAverageTicks = Convert.ToInt64(doubleAverageTicks);
            avgTime = new TimeSpan(longAverageTicks);

            double doubleAverageTicks2 = timeList.Average(timeSpan => timeSpan.Ticks);
            long longAverageTicks2 = Convert.ToInt64(doubleAverageTicks);
            avgTime = new TimeSpan(longAverageTicks);

            string[] details = new string[9];
            //details[2] = records[3];
            details[0] = ("No. of records: " + (recordsFileLength - 1));
            details[1] = ("Max time is: " + maxTime);
            details[2] = ("Min time is: " + minTime);
            details[3] = ("Average time is: " + avgTime);
            details[8] = backline;
            File.WriteAllLines(DETAILS_FILE, details);

        }
    }
}
