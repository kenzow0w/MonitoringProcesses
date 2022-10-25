using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic;
using System.Management;
using System.Timers;

namespace WindowsFormMonitoring
{
    public partial class Monitor : Form
    {
        private static System.Timers.Timer t = new System.Timers.Timer();
        static bool isMonitored;
        private int maxTimeForLive;
        private int frecuencyTime;
        private string processName = null;
        private int sec = 0;
        private int seconds = 0;
        private int minutes = 0;
        private Process process = null;
        private static List<Process> processes = null;
        private static ErrorProvider errorProvider = new ErrorProvider();

        private void setProcess(Process process)
        {
            this.process = process;
        }
        private Process getProcess()
        {
            return process;
        }

        public string getProccessName()
        {
            return textBoxProcessName.Text.ToString();
        }
        public void SetProccessName(string name)
        {
            this.processName = name;
        }

        public void SetMaxLifeTime(string v)
        {
            try
            {
                this.maxTimeForLive = int.Parse(v);
            }
            catch (Exception)
            {
                this.maxTimeForLive = 0;
            }
            
        }
        public int GetMaxLifeTime()
        {
            return this.maxTimeForLive;
        }

        public void SetFrecuencyTime(string v)
        {
            try
            {
                this.frecuencyTime = int.Parse(v);
            }
            catch (Exception)
            {
                this.frecuencyTime = 0;
            }
        }
        public int GetfrecuencyTime()
        {
            return this.frecuencyTime;
        }


        public Monitor()
        {
            InitializeComponent();
        }

        public List<Process> getProcesses()
        {
            try
            {
                processes = Process.GetProcesses().ToList<Process>();
                if (processes == null)
                {
                    Logger.WriteLog("Processes list is empty");
                }
                if (Utils.itHasDigital(label6.Text.ToString()))
                {
                    label6.Text = "Procesess started: ";
                }
                label6.Text += processes.Count.ToString();
                return processes;
            }
            catch (Exception)
            {
                Logger.WriteLog("Something happened, looks at logs");
                return null;
            }
        }
        public bool refreshAndCheckProcess(Process process)
        {
            List<Process> list = getProcesses();
            foreach (Process p in list)
            {
                if (process.GetHashCode().ToString().Equals(p.GetHashCode().ToString()))
                {
                    return true;
                }
            }
            return false;
        }

        public String getProcessNameFromForm(String name)
        {
            if (string.IsNullOrEmpty(name))
            {
                errorProvider.SetError(textBoxProcessName, "Please enter process name");
                return null;
            }
            return name;
        }

        public int getMaxTimeProcessFromForm(int time)
        {
            if (time == 0)
            {
                errorProvider.SetError(textBoxMaxLifetime, "0 is not possible");
                return 0;
            }
            if (time < 0)
            {
                errorProvider.SetError(textBoxMaxLifetime, "value < 0 is not possible");
                return 0;
            }
            return time;
        }

        public int getMonitoringFrequnceFromForm(int time)
        {
            try
            {
                SetFrecuencyTime(textBoxFrequencyTime.Text.ToString());
            }
            catch (Exception)
            {
                errorProvider.SetError(textBoxFrequencyTime, "Please enter valid value");
                return 0;
            }
            if (time == 0)
            {
                errorProvider.SetError(textBoxFrequencyTime, "0 is not possible");
                return 0;
            }
            if (time < 0)
            {
                errorProvider.SetError(textBoxFrequencyTime, "value < 0 is not possible");
                return 0;
            }
            return time;
        }

        public Process findProcessByName(String name)
        {
            if(!string.IsNullOrEmpty(name)){ 
            List<Process> list = getProcesses();
            foreach (Process p in list)
            {
                if (p.ProcessName.Equals(name))
                {
                        return p;
                }
            }
                return null;
            }
            else
            {
                return null;
            }
        }

        private void killProcess(Process process)
        {
            process.Kill();
            process.WaitForExit();
            Logger.WriteLog(string.Format("Process {0} was deleted", process.ProcessName.ToString()));
            MessageBox.Show(process.ProcessName.ToString() + " was deleted");
            isMonitored = false;
        }

        private void killProcessAndChildren(int pid)
        {
            if (pid == 0)
            {
                return;
            }
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("Select * From Win32_Process Where ParentProcessID=" + pid);
            ManagementObjectCollection objectCollection = searcher.Get();
            foreach (ManagementObject obj in objectCollection)
            {
                killProcessAndChildren(Convert.ToInt32(obj["ProcessID"]));
            }
            try
            {
                Process p = Process.GetProcessById(pid);
                p.Kill();
                p.WaitForExit();
            }
            catch (ArgumentException) { }
        }


        private int getParentProcessId(Process process)
        {
            int parentId = 0;
            try
            {
                ManagementObject managementObject = new ManagementObject("win32_process.handle='" + process.Id + "'");
                managementObject.Get();
                parentId = Convert.ToInt32(managementObject["ParentProcessId"]);
            }
            catch (Exception)
            {

            }
            return parentId;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getProcesses();
            t.Interval = 1000;
            t.Elapsed += OnTimeEvent;
            t.Elapsed += eventTimeFreq;
        }

        private void OnTimeEvent(object sender, System.Timers.ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                seconds -= 1;
                if (seconds == 0 || seconds > 60)
                {
                    if (minutes == 0)
                    {
                        minutes = 0;
                    }
                    else
                    {
                        seconds = 59;
                        minutes -= 1;
                    }
                }
                if (minutes == 0)
                {
                    minutes = 0;
                }
                textBoxForTimer.Text = string.Format("{0}:{1}", minutes.ToString().PadLeft(2, '0'), seconds.ToString().PadLeft(2, '0'));
                if (minutes == 0 & seconds <= 0)
                {
                    cancelTimer();
                    killProcess(getProcess());
                }
            }));
        }
        private void eventTimeFreq(object sender, ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                sec -= 1;
                if (sec == 0)
                {
                    if (!refreshAndCheckProcess(getProcess()))
                    {
                        Logger.WriteLog(string.Format("Process {0} was closed", process.ProcessName.ToString()));
                        MessageBox.Show(string.Format("Process {0} was closed", process.ProcessName.ToString()));
                        cancelTimer();
                        clearFields();
                    }
                    sec = (frecuencyTime * 60) - 1;
                }
                textBoxFreqTime.Text = string.Format("{0}", sec.ToString().PadLeft(2, '0'));
            }));

        }

        private void cancelTimer()
        {
            t.Stop();
            t.Close();
        }

        public void clearFields()
        {
            try
            {
                textBoxProcessName.Clear();
                textBoxMaxLifetime.Clear();
                textBoxFrequencyTime.Clear();
                errorProvider.Clear();
                cancelTimer();
                textBoxForTimer.Clear();
                textBoxFreqTime.Clear();
            }
            catch (NullReferenceException)
            {

            }
        }
        private void buttonClearForm_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void startMonitoring()
        {
            setProcess(findProcessByName(processName));
            if (process != null)
            {
                seconds = maxTimeForLive * 60;
                if (seconds <= 60)
                {
                    minutes = 0;
                }
                else
                {
                    minutes = maxTimeForLive;
                }
                sec = frecuencyTime * 60;
                t.Start();
            }
            else
            {
                if (MessageBox.Show("Process " + processName + " is not exist! Do you want to try else?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    this.Close();
                }
                else
                {
                    clearFields();
                }
            }
        }

        private void buttonStartMonitoring_Click(object sender, EventArgs e)
        {
            if (t.Enabled)
            {
                isMonitored = true;
            }
            else
            {
                isMonitored = false;
            }
            SetProccessName(textBoxProcessName.Text.ToString());
            SetMaxLifeTime(textBoxMaxLifetime.Text.ToString());
            SetFrecuencyTime(textBoxFrequencyTime.Text.ToString());
            getProcessNameFromForm(getProccessName());
            getMaxTimeProcessFromForm(GetMaxLifeTime());
            getMonitoringFrequnceFromForm(GetfrecuencyTime());
            bool isFlag = string.IsNullOrEmpty(processName) || maxTimeForLive == 0 || frecuencyTime == 0;
            {
                if (isMonitored == false & isFlag == false)
                {
                    isMonitored = true;
                    startMonitoring();
                }
                else
                {
                    return;
                }
            }
        }

        private void завершитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Escape))
            {
                this.Close();
                return true;
            }
            if (keyData == (Keys.Q))
            {
                clearFields();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
