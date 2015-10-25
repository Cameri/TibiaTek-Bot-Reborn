using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Media;
using System.IO;

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
            //SoundPlayer simpleSound = new SoundPlayer(Environment.CurrentDirectory + "\\Alarms\\" + BlSoundBox.SelectedItem);
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

                //for (int i = 0; i < BattlelistIgnoredPlayers.Items.Count; i++)
                //{
                //    if (Regex.IsMatch(bl.Name, BattlelistIgnoredPlayers.Items[i].ToString(), RegexOptions.IgnoreCase))
                //    {
                //        continue;
                //    }
                //}

                bool isIgnore = false;
                foreach (var listBoxItem in BattlelistIgnoredPlayers.Items)
                {
                    if (bl.Name.ToLower().Contains(listBoxItem.ToString()))
                    {
                        isIgnore = true;
                        break;
                    }
                    else
                    {
                        isIgnore = false;
                    }

                }

                if (isIgnore == true)
                {
                    continue;
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

                    new SoundPlayer(BLSound).Play(); 
  
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

            #region Cargar BlSoundBox
            if (BlSoundBox.Items.Count > 0)
            {
                BlSoundBox.Items.Clear();
            }
            foreach (var sound in Directory.GetFiles(Environment.CurrentDirectory + "\\Alarms"))
            {
                BlSoundBox.Items.Add(Path.GetFileName(sound));
            } 
            BlSoundBox.SelectedIndex = 0;
            #endregion
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
                BattlelistIgnoredPlayers.Items.Add(input.ToLower());
                BattlelistIgnoredPlayersInput.Clear();
                BattlelistIgnoredPlayersInput.Focus();
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

        private void BlSoundBox_DropDown(object sender, EventArgs e)
        {
            if (BlSoundBox.Items.Count > 0)
            {
                BlSoundBox.Items.Clear();
            }
            foreach (var sound in Directory.GetFiles(Environment.CurrentDirectory + "\\Alarms"))
            {
                BlSoundBox.Items.Add(Path.GetFileName(sound));
            }
        }

        private void BlSoundBox_DropDownClosed(object sender, EventArgs e)
        {
            if (BlSoundBox.SelectedItem == null)
            {
                BlSoundBox.SelectedIndex = 0;
            }
        }

        private void BlSoundTest_Click(object sender, EventArgs e)
        {
            if (BlSoundBox.Text != string.Empty)
            {
                SoundPlayer simpleSound = new SoundPlayer(Environment.CurrentDirectory + "\\Alarms\\" + BlSoundBox.SelectedItem);
                simpleSound.Play();
            }
            else
            {
                MessageBox.Show("Select a sound from the list.");
            }
        }

        private void SoundFileBrowseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "txt files (*.wav)|*.wav";
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    SoundFilePath.Text = openFileDialog1.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void SoundFileAddButton_Click(object sender, EventArgs e)
        {
            File.Copy(SoundFilePath.Text, Environment.CurrentDirectory + "\\Alarms\\" + Path.GetFileName(SoundFilePath.Text), true);
            SoundFilePath.Clear();
            MessageBox.Show("Alarms added succesfully.");
        }
        string BLSound = "";
        private void BlSoundBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            BLSound = Application.StartupPath + "\\Alarms\\" + BlSoundBox.SelectedItem;
        }
    }
}
