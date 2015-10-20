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
        Kernel kernel;

        public MainForm()
        {
            kernel = new Kernel();
            kernel.Start();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
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
            kernel.ExperienceChecker.Active = ((CheckBox)sender).Checked;
        }
    }
}
