using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TibiaTekBot
{
    public partial class MainForm : Form
    {

        AlarmsForm alarmsForm;
        LagBarForm lagBarForm;
       // RuneMakerForm runemakerform;
        Kernel kernel;
        public Tibia client;
        public MainForm()
        {
            
            kernel = new Kernel();
            kernel.Start();
            alarmsForm = new AlarmsForm(kernel.Client);
            lagBarForm = new LagBarForm(kernel.Client);
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

        private void ExpCheckerTrigger_CheckedChanged(object sender, EventArgs e)
        {
            if (ExpCheckerTrigger.Text=="Activate")
            {
                ExpCheckerTrigger.Text = "Deactivate";
            }
            else
            {
                ExpCheckerTrigger.Text = "Activate";
            }
            kernel.ExperienceChecker.Active = ((CheckBox)sender).Checked;
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
            //runemakerform.Show();
            //runemakerform.BringToFront();
            RuneMakerForm runemakerform = new RuneMakerForm();

            var formToShow = Application.OpenForms.Cast<Form>().FirstOrDefault(c => c is RuneMakerForm);
            if (formToShow != null)
            {
                formToShow.Show();
            }
            else
            {
                runemakerform.Show();
            }
        }
    }
}
