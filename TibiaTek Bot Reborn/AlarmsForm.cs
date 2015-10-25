using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Media;

namespace TibiaTekBot
{
    public partial class AlarmsForm : Form
    {
        bool Active = false;
        Timer BattlelistTimer;
        public Kernel kernel;
        public AlarmsForm()
        {
            BattlelistTimer = new Timer(5000);
            BattlelistTimer.Execute += BattlelistTimer_Execute;
            InitializeComponent();
        }

        private void BattlelistTimer_Execute(object sender, EventArgs e)
        {
            BattleList bl = kernel.Client.GetBattlelist();
            uint localPlayerID = kernel.Client.LocalPlayer.ID;
            Tibia.Location localPlayerLoc = kernel.Client.LocalPlayer.Location;
            bool alert = false;
            bl.Reset();

            
            do
            {    
                if (!bl.OnScreen
                    || bl.ID == localPlayerID)
                {
                    continue;
                }

                Tibia.Location entityLoc = bl.Location;

                if (!BattlelistMultiFloorAbove.Checked
                    && !BattlelistMultiFloorBelow.Checked
                    && entityLoc.Z != localPlayerLoc.Z)
                {
                    continue;
                }

                for (int i = 0; i < BattlelistIgnoredPlayers.Items.Count; i++)
                {
                    if (Regex.IsMatch(bl.Name, BattlelistIgnoredPlayers.Items[i].ToString(), RegexOptions.IgnoreCase))
                    {
                        continue;
                    }
                }

                if (!BattlelistActivateIfPlayer.Checked && bl.IsPlayer)
                {
                    continue;
                }

                if (!BattlelistActivateIfMonsterNPC.Checked && bl.IsMonster)
                {
                    continue;
                }
                
                // Check if entity is above or below, and how far
                if ((Math.Abs(localPlayerLoc.Z - entityLoc.Z) > BattlelistMultiFloorRange.Value) 
                    && ((!BattlelistMultiFloorAbove.Checked && localPlayerLoc.Z > entityLoc.Z)
                    || (!BattlelistMultiFloorBelow.Checked && localPlayerLoc.Z < entityLoc.Z))) {
                    continue;
                }

                if (BattlelistActivateIfPlayer.Checked && bl.IsPlayer)
                {
                    //MessageBox.Show("Player " + bl.Name);
                }
                else if (BattlelistActivateIfMonsterNPC.Checked && bl.IsMonster)
                {
                    //MessageBox.Show("Monster " + bl.Name + " " + entityLoc.Z);
                }

                
                if (BattlelistPlaySound.Checked)
                {
                    new SoundPlayer(Application.StartupPath + "\\Alarms\\Tune.wav").Play();
                }
                break;
                

            } while (bl.Next());
        }

        private void AlarmsActivate_Click(object sender, EventArgs e)
        {
            AlarmsLoad.Enabled = false;
            Active = !Active;
            if (Active)
            {
                AlarmsActivate.Text = "Deactivate";
                BattlelistTimer.Start();
            }
            else
            {
                AlarmsActivate.Text = "Activate";
                BattlelistTimer.Stop();
            }
            Tabs.Enabled = !Active;
            AlarmsLoad.Enabled = !Active;
        }

        private void AlarmsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void AlarmsForm_Load(object sender, EventArgs e)
        {

        }

        private void AlarmsHide_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void BattlelistIgnoredPlayerAdd_Click(object sender, EventArgs e)
        {
            string input = BattlelistIgnoredPlayersInput.Text.Trim();
            if (!String.IsNullOrEmpty(input))
            {
                BattlelistIgnoredPlayers.Items.Add(input);
            }   
        }

        private void BattlelistIgnoredPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            BattlelistIgnoredPlayerRemove.Enabled = (BattlelistIgnoredPlayers.SelectedIndex >= 0);
        }

        private void BattlelistIgnoredPlayerRemove_Click(object sender, EventArgs e)
        {
            if (BattlelistIgnoredPlayers.SelectedIndex >= 0)
            {
                BattlelistIgnoredPlayers.Items.RemoveAt(BattlelistIgnoredPlayers.SelectedIndex);
            }
        }
    }
}
