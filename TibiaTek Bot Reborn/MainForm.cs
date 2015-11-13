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
        int autoeatinterval = 0;
        AlarmsForm alarmsForm;
        LagBarForm lagBarForm;
        RuneMakerForm runemakerform;
        HelerForm helerform;
        Log logs = new Log();

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
           
            CBFuntionKeys.SelectedIndex = 0;
            CBAlternalKeys.SelectedIndex = 0;
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

            #region screencapture
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
                logs.SaveLog(DateTime.Now, "Screenshot", "Screenshot saved");
               
            }
            #endregion

            #region auto eater
            if (AutoEaterTrigger.Checked)
            {
                if (autoeatinterval >= Convert.ToInt32(AutoEaterInterval.Value))
                {
                    string combination = "";
                    combination = CBAlternalKeys.SelectedText;
                    if (CBAlternalKeys.SelectedItem.ToString() == "None")
                    {
                        combination = "";
                    }
                    if (CBAlternalKeys.SelectedItem.ToString() == "Ctrl")
                    {
                        combination = "^";
                    }
                    if (CBAlternalKeys.SelectedItem.ToString() == "Shift")
                    {
                        combination = "+";
                    }
                    autoeatinterval = 0;
                    
                    if (FoodInBag.Value>0)
                    {
                        
                        kernel.Client.SendKeys("");
                        Thread.Sleep(500);
                        kernel.Client.SendKeys(combination + "{" + CBFuntionKeys.SelectedItem + "}");
                        FoodInBag.Value--;
                    }
                    else
                    {
                        kernel.Client.SetStatusText("No food in bag, auto eater disable.");
                        logs.SaveLog(DateTime.Now, "Auto Eater", "No food in bag, auto eater disable.");
                        AutoEaterTrigger.Checked = false;
                        MessageBox.Show("No food in bag, auto eater disable.");
                    }
                    
                    
                }
                else
                {
                    autoeatinterval++;
                }
            }
            #endregion
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

        private void AutoEaterTrigger_CheckedChanged(object sender, EventArgs e)
        {
            if (AutoEaterTrigger.Checked)
            {
                AutoEaterTrigger.Text = "Deactivate";
                autoeatinterval = 0;
            }
            else
            {
                AutoEaterTrigger.Text = "Activate";
               
            }
            
        }

        private void AutoEaterHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("How To Use:\n\nJust put in a hotkey the food you have in your bag and then put the same hotkey in Tibia Bot Tek - Auto Eater\n\nDefault time is 60 seconds (1 minute) but you can change it to your needs.\n\nFood In Bag: Indicates the amount of food contained in the bag and also the selected hotkey. ");
            
        }

        private void CBAlternalKeys_DropDownClosed(object sender, EventArgs e)
        {
            if (CBAlternalKeys.SelectedItem == null)
            {
                CBAlternalKeys.SelectedIndex = 0;
            }
        }

        private void CBFuntionKeys_DropDownClosed(object sender, EventArgs e)
        {
            if (CBFuntionKeys.SelectedItem == null)
            {
                CBFuntionKeys.SelectedIndex = 0;
            }
        }

        private void AutoEaterInterval_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void SpellCasterTrigger_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
