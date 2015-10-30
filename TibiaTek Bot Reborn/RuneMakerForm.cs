using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace TibiaTekBot
{
    public partial class RuneMakerForm : Form
    {
        int tryout = 0;
        public Tibia client;
        Log logs = new Log();
        private bool active = false;
        public RuneMakerForm(Tibia client)
        {
            this.client = client;
            InitializeComponent();
        }

        private void RunemakerTrigger_CheckedChanged(object sender, EventArgs e)
        {
            if (active)
            {
                RunemakerTrigger.Text = "Activate";
                tryout = 0;
            }
            else
            {
                ManaLabel.Text = "Mana: 0/0";
                RunemakerTrigger.Text = "Deactivate";
                tryout = 0;
            }
            active = !active;
            RuneMakerTimer.Enabled = active;
            GroupBox3.Enabled = !active;
        }

        private void RuneMakerTimer_Tick(object sender, EventArgs e)
        {
            if (!client.IsConnected)
            {
                ManaLabel.Text = "Disconnected";
                RunemakerTrigger.Checked = false;
                MessageBox.Show("Character disconnected, Rune Maker deactivated.");
                logs.SaveLog(DateTime.Now, "Disconnected", "Character disconnected, Rune Maker deactivated.");
                return;
                
            }

            // Update Mana/MaxMana display
            ManaLabel.Text = "Mana: " + client.LocalPlayer.ManaPoints + "/" + client.LocalPlayer.MaxManaPoints;

            if (BlankRunesAvailable.Value <= 0)
            {
                RunemakerTrigger.Checked = false; // ran out of runes, supposedly
                MessageBox.Show("Out of blank runes. Rune Maker is now deactivated.");
                logs.SaveLog(DateTime.Now, "Rune Maker", "Out of blank runes. Rune Maker is now deactivated.");
                client.SetStatusText("Out of blank runes. Rune Maker is now deactivated.");
                return;
            }

            uint random = 0;
            if (checkBox1.Checked)
            {
                random = (uint) (new Random().NextDouble() * client.LocalPlayer.MaxManaPoints * 0.01);
            }

            if (RunOnMaxMana.Checked)
            {
                uint limit = client.LocalPlayer.MaxManaPoints - 2U - random;

                if (client.LocalPlayer.ManaPoints < limit)
                {
                    return; // not enough MP
                }
            } else
            {
                if (client.LocalPlayer.ManaPoints < RunemakerMinimumManaPoints.Value - random)
                {
                    return; // not enough MP
                }
            }

            if (client.LocalPlayer.SoulPoints <= RunemakerMinimumSoulPoints.Value + 5)
            {
                return; // not enough SP
            }

            int currentmana = Convert.ToInt32( client.LocalPlayer.ManaPoints);
            
            
            // 'tis all gewd
            client.SendKeys("{ESC}");
            client.SendKeys("{ENTER}");
            client.SendKeys(RunemakerSpell.Text);
            client.SendKeys("{ENTER}");
            if (client.LocalPlayer.ManaPoints >= currentmana)
            {
                tryout++;
                if (tryout>=3)
                {
                RunemakerTrigger.Checked = false; // something when wrong
                logs.SaveLog(DateTime.Now, "Rune Maker", "Unable to cast spell, max attempts exceeded. verify if something is stopping the tibia windows to be activate.");
                client.SetStatusText("Unable to cast spell, max attempts exceeded.");
                MessageBox.Show("Unable to cast spell, max attempts exceeded.\n\nRune Maker deactivated.");
                }
                Thread.Sleep(1000);
                return;
            }
                tryout = 0;
                new SoundPlayer(Environment.CurrentDirectory + "\\Alarms\\Completion.wav").Play();
                BlankRunesAvailable.Value--;
           
           
   
        }

        private void HideWindows_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void RunemakerSpell_SelectedIndexChanged(object sender, EventArgs e)
        {
            RunemakerTrigger.Enabled = RunemakerSpell.Text.Length > 0;
        }

        private void RuneMakerForm_Load(object sender, EventArgs e)
        {

        }

        private void RunemakerSpell_TextChanged(object sender, EventArgs e)
        {
            RunemakerTrigger.Enabled = RunemakerSpell.Text.Length > 0;
        }

        private void RunOnMaxMana_CheckedChanged(object sender, EventArgs e)
        {
            RunemakerMinimumManaPoints.Enabled = !RunOnMaxMana.Checked;
        }

        private void RunemakerMinimumManaPoints_ValueChanged(object sender, EventArgs e)
        {

        }

        private void RunemakerHelp_Click(object sender, EventArgs e)
        {
            
        }
    }
}
