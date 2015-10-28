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

        Kernel kernel;
        public Tibia client;
        public MainForm()
        {
            
            kernel = new Kernel();
            kernel.Start();
            alarmsForm = new AlarmsForm(kernel.Client);
            lagBarForm = new LagBarForm(kernel.Client);
            runemakerform = new RuneMakerForm(kernel.Client);
            //runemakerform = new RuneMakerForm(kernel.Client);
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kernel.Client.SendKeys("exura{ENTER}");

            return;
            //MessageBox.Show(String.Format("{0}", kernel.Client.LocalPlayer.Location));
            BattleList bl = kernel.Client.GetBattlelist();
           // MessageBox.Show(bl.BattlelistBegin.ToString());
            bl.Reset();
            Tibia.Location playerLoc = kernel.Client.LocalPlayer.Location;
            uint playerID = kernel.Client.LocalPlayer.ID;
            do
            {
                if (bl.ID != playerID && bl.OnScreen && bl.Location.Z == playerLoc.Z)
                {
                    MessageBox.Show(String.Format("ID: {0:X} \nName: {1} \nLocation: {2}", bl.ID, bl.Name, bl.Location));

                }
            } while (bl.Next());
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
            alarmsForm.Show();
            alarmsForm.BringToFront();
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
            runemakerform.Show();
            runemakerform.BringToFront();
        }

        private void ShowLagBar_CheckedChanged(object sender, EventArgs e)
        {
             if (ShowLagBar.CheckState==CheckState.Checked)
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
            if (LevelScreenshot.Checked==true)
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
            if (LevelScreenshot.Checked==true)
            {
                if (kernel.Client.LocalPlayer.Level==NextLevel)
                {
                int fileCount = Directory.GetFiles(Environment.CurrentDirectory + "\\ScreenCaptures").Length;
                kernel.Client.SendKeys("^{DOWN}");
                Thread.Sleep(700);
                var image = ScreenCapture.CaptureActiveWindow();
                image.Save(Environment.CurrentDirectory + "\\ScreenCaptures\\" + kernel.Client.LocalPlayer.Name + " - Level " + NextLevel +".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                new SoundPlayer(Environment.CurrentDirectory + "\\Alarms\\Camera Shutter.wav").Play();
                NextLevel++;

                }
            }
        }

        private void ExpCheckerHelp_Click(object sender, EventArgs e)
        {
            NextLevel--;// solo es para simular un level up
        }
    }
}
