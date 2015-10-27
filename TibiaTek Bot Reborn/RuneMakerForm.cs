using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace TibiaTekBot
{
    public partial class RuneMakerForm : Form
    {
        Kernel kernel;
        public Tibia client;
        public RuneMakerForm()
        {
            //this.client = client;
            kernel = new Kernel();
            kernel.Start();
            InitializeComponent();
        }

        private void RunemakerTrigger_CheckedChanged(object sender, EventArgs e)
        {
            if (RunemakerTrigger.Text == "Activate")
            {
                RuneMakerTimer.Enabled = true;
                BlankRunesAvailable.Enabled = false;
                RunemakerTrigger.Text = "Deactivate";
            }
            else
            {
                ManaLabel.Text = "Mana: 0/0";
                RuneMakerTimer.Enabled = false;
                BlankRunesAvailable.Enabled = true;
                RunemakerTrigger.Text = "Activate";
            }


        }

        private void RuneMakerTimer_Tick(object sender, EventArgs e)
        {
            ManaLabel.Text = "Mana: "+kernel.Client.LocalPlayer.ManaPoints+"/"+kernel.Client.LocalPlayer.MaxManaPoints;
            if (BlankRunesAvailable.Value > 0)
            {
                if (RunOnMaxMana.Checked == true)
                {
                    if (kernel.Client.LocalPlayer.ManaPoints >= kernel.Client.LocalPlayer.MaxManaPoints-2)
                    {

                        if (kernel.Client.LocalPlayer.SoulPoints>RunemakerMinimumSoulPoints.Value+5)
                        {
                            kernel.Client.SendKeys(" {ENTER}");
                            Thread.Sleep(100);
                            kernel.Client.SendKeys(RunemakerSpell.Text + "{ENTER}");
                            BlankRunesAvailable.Value--;
                            
                        }
                    }

                }
            }
            else
            {
                RunemakerTrigger.CheckState = CheckState.Unchecked;
                MessageBox.Show("no more blank runes.");
                
            }
        }

        private void HideWindows_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
