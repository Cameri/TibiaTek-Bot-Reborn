using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Threading;
using System.IO;
using System.Media;

namespace TibiaTekBot
{
    public partial class MainForm : Form
    {
        int NextLevel = 0;
        AlarmsForm alarmsForm;
        LagBarForm lagBarForm;
        RuneMakerForm runemakerform;
        HelerForm helerform;

        Kernel kernel;

        public MainForm()
        {

            kernel = new Kernel();
            kernel.Start();
            alarmsForm = new AlarmsForm(kernel.Client);
            lagBarForm = new LagBarForm(kernel.Client);
            runemakerform = new RuneMakerForm(kernel.Client);
            helerform = new HelerForm(kernel.Client);
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void GroupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void GroupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void ExpCheckerBox_Enter(object sender, EventArgs e)
        {

        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void AutoLooterBox_Enter(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void alarmsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void lagBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lagBarForm.Show();
            lagBarForm.BringToFront();
        }

        private void windowsMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void runeMakerToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void ShowLagBar_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowLagBar.CheckState == CheckState.Checked)
            {
                lagBarForm.Show();
                lagBarForm.BringToFront();
            }
            else
            {
                lagBarForm.Close();
            }

        }

        private void ExpChecker_CheckedChanged(object sender, EventArgs e)
        {
            kernel.ExperienceChecker.Active = ((CheckBox)sender).Checked;
        }

        private void LevelScreenshot_CheckedChanged(object sender, EventArgs e)
        {
            if (LevelScreenshot.Checked)
            {
                if (!Directory.Exists(Environment.CurrentDirectory + "\\ScreenCaptures"))
                {
                    Directory.CreateDirectory(Environment.CurrentDirectory + "\\ScreenCaptures");
                }
                NextLevel = Convert.ToInt32(kernel.Client.LocalPlayer.Level + 1);
            }

        }

        private void MainFormTimer_Tick(object sender, EventArgs e)
        {
            
             
           


            if (!kernel.Client.IsConnected)
            {
                return;
            }

            if (LevelScreenshot.Checked && kernel.Client.LocalPlayer.Level == NextLevel)
            {
                int fileCount = Directory.GetFiles(Environment.CurrentDirectory + "\\ScreenCaptures").Length;
                
                kernel.Client.SendKeys("^{DOWN}");
                Thread.Sleep(700);

                string fileNameWithoutExt = kernel.Client.LocalPlayer.Name + " - Level " + NextLevel;
                kernel.Client.TakeScreenshot(fileNameWithoutExt, true);
                NextLevel++;
                kernel.Client.SetStatusText("Screenshot saved.");
            }
        }

        private void ExpCheckerHelp_Click(object sender, EventArgs e)
        {
            NextLevel--;// solo es para simular un level up
        }

        private void ShowAlarmsButtom_Click(object sender, EventArgs e)
        {
            alarmsForm.Show();
            alarmsForm.BringToFront();
        }

        private void ShowRuneMakerButtom_Click(object sender, EventArgs e)
        {
            runemakerform.Show();
            runemakerform.BringToFront();
        }

        private void HelerBotButtom_Click(object sender, EventArgs e)
        {
            helerform.Show();
            helerform.BringToFront();
        }
    }
}
