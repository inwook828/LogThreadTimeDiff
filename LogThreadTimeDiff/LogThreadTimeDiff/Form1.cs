using LogThreadTimeDiff.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogThreadTimeDiff
{
    public partial class TimeDiffLocator : Form
    {
        private string filePath = "";
        private string fileContent = "";
        private OpenFileDialog openFileDialog = new OpenFileDialog();
        private Dictionary<int, string> logCollection = new Dictionary<int, string>();

        public TimeDiffLocator()
        {
            InitializeComponent();

            InitializeOpenFileDialog();
        }

        private void InitializeOpenFileDialog()
        {
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = false;
            StartBtn.Enabled = false;
        }

        public async Task<bool> OpenFile()
        {
            bool status = false;
            InitializeData();        
            
            DisplayMessage("**** Opening File...****");
            OpenBtn.Enabled = false;
            StartBtn.Enabled = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                filePath = openFileDialog.FileName;
                FileDirectoryTxtBox.Text = filePath;

                Task<bool> loadFileTask = Task.Run(() => LoadFile());
                await loadFileTask;

                if(loadFileTask.Result)
                {
                    status = true;
                }
            }

            return status;
        }

        private void InitializeData()
        {
            filePath = "";
            fileContent = "";
            logCollection.Clear();
        }

        private bool LoadFile()
        {
            bool status = false;

            try
            {
                //Read the contents of the file into a stream
                var fileStream = openFileDialog.OpenFile();

                using (StreamReader reader = new StreamReader(fileStream))
                {
                    fileContent = reader.ReadToEnd();
                    status = true;
                }
            }
            catch(Exception ex)
            {
                DisplayMessage("**** Failed to Load File. ****");
                DisplayMessage(ex.Message);
            }

            return status;
           
        }

        private void DisplayMessage(string msg)
        {
            ResultTxtBox.AppendText(DateTime.Now + ": " +msg);
            ResultTxtBox.AppendText(Environment.NewLine);
        }

        private void OpenBtn_Click(object sender, EventArgs e)
        {
            BeginFileRead();           
        }

        private async Task BeginFileRead()
        {            
            var openFileTask = await OpenFile();

            if (openFileTask)
            {
                DisplayMessage("Successfully Read Log File");
                StartBtn.Enabled = true;
            }
            else
            {
                DisplayMessage("Failed to Read Log File");
                StartBtn.Enabled = false;
            }

            OpenBtn.Enabled = true;
        }

        private async void StartBtn_Click(object sender, EventArgs e)
        {
            DisplayMessage("**** Starting Analysis ****");
            StartBtn.Enabled = false;

            //Number each Log Message
            await BeginAnalysis();

            //Parse DateTime and Thread Number

            //Compare Each DateTime and get its Time Span

            //If TimeSpan is greater than Configured TimeSpan it will get the starting Line Number 


            StartBtn.Enabled = true;

            DisplayMessage("**** Finished Analysis ****");
        }

        private async Task FindAllThreadSwitch()
        {
            int threadNumber1 = 1;
            int threadNumber2 = 0;
            string regExThreadNumber1 = "";
            string regExThreadNumber2 = "";

            for (int i = 2; i < logCollection.Count; i++)
            {
                regExThreadNumber1= FindThreadNumber(logCollection[i-1]);
                regExThreadNumber2 = FindThreadNumber(logCollection[i]);

                //Find Thread Number
                if(Int32.TryParse(regExThreadNumber1, out threadNumber1) &&
                Int32.TryParse(regExThreadNumber2, out threadNumber2))
                {

                }
            } 
        }

        private string FindThreadNumber(string thread)
        {
            string pattern = @"^([0-9]+)";

            Regex rg = new Regex(pattern);
            Match rgMatch = rg.Match(thread);

            return rgMatch.Value;
        }

        private async Task BeginAnalysis()
        {
            if (logCollection.Count <= 0)
            {
                DisplayMessage("**** Starting Number Lining ****");
                StringBuilder strBuilder = new StringBuilder();

                Task numberLogMessagesTask = Task.Run(NumberLogMessages);
                await numberLogMessagesTask;
                strBuilder.Append($"**** Number Lining Done Total Lines: {logCollection.Count}****");
                DisplayMessage(strBuilder.ToString());
            }            

            await FindAllThreadSwitch();
        }

        private async Task NumberLogMessages()
        {
            string[] lines = fileContent.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
            for (int i = 1; i < lines.Length; i++)
            {
                logCollection.Add(i, lines[i]);
            }
        }
    }
}
