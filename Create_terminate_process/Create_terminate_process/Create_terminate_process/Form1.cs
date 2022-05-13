using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Create_terminate_process
{
    public partial class Form1 : Form
    {

        private string firstProcessName;
        private string secondProcessName;
        private string thirdProcessName;
        private Thread tFirstProcess;
        private Thread tSecondProcess;
        private Thread tThirdProcess;

        public Form1()
        {
            InitializeComponent();
        }

         private void b_start_first_process_Click(object sender, EventArgs e)
         {
            tFirstProcess = new Thread(() => StartFirstProcess());
            tFirstProcess.Start();
        }

        private void b_start_second_process_Click(object sender, EventArgs e)
        {
            tSecondProcess = new Thread(() => StartSecondProcess());
            tSecondProcess.Start();
        }

        private void b_start_third_process_Click(object sender, EventArgs e)
        {
            tThirdProcess = new Thread(() => StartThirdProcess());
            tThirdProcess.Start();
        }

        private void StartFirstProcess() {
            Process firstProcess = new Process();
            firstProcess.StartInfo.FileName = this.firstProcessName;
            firstProcess.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
            firstProcess.Start();

            this.Invoke(new Action(() => { b_start_first_process.Enabled = false; }));
            this.Invoke(new Action(() => { lbl_first_process.Text = firstProcessName + " has been started!"; }));
            firstProcess.WaitForExit();
            this.Invoke(new Action(() => { b_start_first_process.Enabled = true; }));
            this.Invoke(new Action(() => { lbl_first_process.Text = firstProcessName + " has been terminated!"; }));

            tFirstProcess.Abort();
        }

        private void StartSecondProcess()
        {
            Process secondProcess = new Process();
            secondProcess.StartInfo.FileName = this.secondProcessName;
            secondProcess.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
            secondProcess.Start();

            this.Invoke(new Action(() => { b_start_second_process.Enabled = false; }));
            this.Invoke(new Action(() => { lbl_second_process.Text = secondProcessName + " has been started!"; }));
            secondProcess.WaitForExit();
            this.Invoke(new Action(() => { b_start_second_process.Enabled = true; }));
            this.Invoke(new Action(() => { lbl_second_process.Text = secondProcessName + " has been terminated!"; }));

            tSecondProcess.Abort();
        }

        private void StartThirdProcess()
        {
            Process thirdProcess = new Process();
            thirdProcess.StartInfo.FileName = this.thirdProcessName;
            thirdProcess.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
            thirdProcess.Start();

            this.Invoke(new Action(() => { b_start_third_process.Enabled = false; }));
            this.Invoke(new Action(() => { lbl_third_process.Text = thirdProcessName + " has been started!"; }));
            thirdProcess.WaitForExit();
            this.Invoke(new Action(() => { b_start_third_process.Enabled = true; }));
            this.Invoke(new Action(() => { lbl_third_process.Text = thirdProcessName + " has been terminated!"; }));

            tThirdProcess.Abort();
        }

        private void tb_first_process_TextChanged(object sender, EventArgs e)
        {
            this.firstProcessName = tb_first_process.Text;
            if (firstProcessName.Split('.').Last() != "exe") {
                firstProcessName += ".exe";
            }
        }

        private void tb_second_process_TextChanged(object sender, EventArgs e)
        {
            this.secondProcessName = tb_second_process.Text;
            if (secondProcessName.Split('.').Last() != "exe")
            {
                secondProcessName += ".exe";
            }
        }

        private void tb_third_process_TextChanged(object sender, EventArgs e)
        {
            this.thirdProcessName = tb_third_process.Text;
            if (thirdProcessName.Split('.').Last() != "exe")
            {
                thirdProcessName += ".exe";
            }
        }
    }
}
