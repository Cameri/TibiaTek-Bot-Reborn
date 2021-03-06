﻿using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Media;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;

namespace TibiaTekBot
{
    public partial class AlarmsForm : Form
    {
        bool Active = false;
        string LogTextDetails;
        Timer BattlelistTimer;
        Log logs = new Log();
        public Tibia client;
        int AlarmTimeIntervals = 1000;
        int StatusTimeInterval = 1000;
        public AlarmsForm(Tibia client)
        {
            this.client = client;

           
            InitializeComponent();
        }

        private void BattlelistTimer_Execute(object sender, EventArgs e)
        {
           
            BattleList bl = client.GetBattlelist();
            uint localPlayerID = client.LocalPlayer.ID;
            Tibia.Location localPlayerLoc = client.LocalPlayer.Location;
            bl.Reset();

            #region Battle List Sounds
            do
            {    
                if (!bl.OnScreen || bl.ID == localPlayerID)
                {
                    continue;
                }

                Tibia.Location entityLoc = bl.Location;

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
                
                // Verify relative entity floor
                if ((entityLoc.IsHigherThan(localPlayerLoc) && !BattlelistMultiFloorAbove.Checked)
                    || (entityLoc.IsLowerThan(localPlayerLoc) && !BattlelistMultiFloorBelow.Checked)
                    || ((BattlelistMultiFloorAbove.Checked || BattlelistMultiFloorBelow.Checked)
                    && Math.Abs((int)localPlayerLoc.Z - (int)entityLoc.Z) > BattlelistMultiFloorRange.Value))
                {
                    continue;
                }



                if (!BattlelistMultiFloorAbove.Checked
                    && !BattlelistMultiFloorBelow.Checked
                    && entityLoc.Z != localPlayerLoc.Z)
                {
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
                    LogTextDetails = String.Format("ID: {0:X}     Name: {1}     Location: {2}     ", bl.ID, bl.Name, bl.Location);
                    logs.SaveLog(DateTime.Now, "Alarm", LogTextDetails);
                    client.SetStatusText("Alarm was activated by: "+bl.Name.ToString());
                }
                break;
                

            } while (bl.Next());
            #endregion 

           
        }

        bool RunStatus = false;
        string statusText = "";
        private void StatusTimer_Tick(object sender, EventArgs e)
        {
           
           
            BattleList bl = client.GetBattlelist();
            uint localPlayerHP = client.LocalPlayer.HealthPoints;
            uint localPlayerMana = client.LocalPlayer.ManaPoints;
            uint localPlayerSoul = client.LocalPlayer.SoulPoints;
            uint localPlayerCAP = client.LocalPlayer.Capacity;

            #region Status Sound
            if (StatusPlaySound.Checked)
            {
                if (RunStatus==true)
                {
                    new SoundPlayer(STSound).Play();
                    LogTextDetails = String.Format("Alarm was activated by: Low {0:X}", statusText);
                    logs.SaveLog(DateTime.Now, "Alarm", LogTextDetails);
                    client.SetStatusText("Alarm was activated by: Low " + statusText);
                }

                statusText = "";
                RunStatus = false;
                if (localPlayerHP < StatusHitPoints.Value)
                {
                    RunStatus = true;
                    statusText =statusText+ " HitPoints";
                    
                }

                if (localPlayerMana < StatusManaPoints.Value)
                {
                    RunStatus = true;
                    statusText =statusText+ ", ManaPoints";
                    
                }

                if (localPlayerSoul < StatusSoulPoints.Value)
                {
                    RunStatus = true;
                    statusText = statusText + ", SoulPoints";
                   
                }
                if (localPlayerCAP /100+1 < StatusCapacity.Value)
                {
                    RunStatus = true;
                    statusText = statusText + ", Capacity";
                    
                }
                
                
            }
            #endregion
        }

        private void AlarmsActivate_Click(object sender, EventArgs e)
        {
            
            AlarmsLoad.Enabled = false;
            Active = !Active;
            if (Active)
            {
                BattlelistTimer = new Timer(AlarmTimeIntervals);
                BattlelistTimer.Execute += BattlelistTimer_Execute;
                StatusTimer.Interval = StatusTimeInterval;
                StatusTimer.Enabled = true;
                StatusTimer.Start();
                AlarmsActivate.Text = "Deactivate";
                BattlelistTimer.Start();
            }
            else
            {
                StatusTimer.Stop();
                StatusTimer.Enabled = false;
                AlarmsActivate.Text = "Activate";
                BattlelistTimer.Stop();
            }

            statusText = "";
            RunStatus = false;
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

            #region Cargar StSoundBox
            if (StSoundBox.Items.Count > 0)
            {
                StSoundBox.Items.Clear();
            }
            foreach (var sound in Directory.GetFiles(Environment.CurrentDirectory + "\\Alarms"))
            {
                StSoundBox.Items.Add(Path.GetFileName(sound));
            }
            StSoundBox.SelectedIndex = 0;
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
            openFileDialog1.Filter = "Wav files (*.wav)|*.wav";
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

        private void OpenLogFolder_Click(object sender, EventArgs e)
        {
            string path = Environment.CurrentDirectory + "\\Logs";
            if (Directory.Exists(path))
            {
                Process.Start("explorer.exe", path);
            }
            else
            {
                MessageBox.Show("Directory not found.");
            }
    }

        private void ViewLogButtom_Click(object sender, EventArgs e)
        {
            string path = Environment.CurrentDirectory + "\\Logs";
            string playername = client.LocalPlayer.Name;
            if (File.Exists(path+"\\"+playername+".Logs.txt"))
            {
                Process.Start(path + "\\" + playername + ".Logs.txt");
            }
            else
            {
                MessageBox.Show("No log file found for "+playername);
            }
            
        }
        
        private void BattlelistMessagePlayerInput_TextChanged(object sender, EventArgs e)
        {
            BattlelistMessagePlayer.Enabled = BattlelistMessagePlayerInput.Text.Length > 0;
            if (!BattlelistMessagePlayer.Enabled)
            {
                BattlelistMessagePlayer.Checked = false;
            }
        }

        private void BattleListPauseBot_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BattlelistMessagePlayer_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void StatusMessagePlayerName_TextChanged(object sender, EventArgs e)
        {
            StatusMessagePlayer.Enabled = BattlelistMessagePlayerInput.Text.Length > 0;
            if (!StatusMessagePlayer.Enabled)
            {
                StatusMessagePlayer.Checked = false;
            }
        }
        private void AlarmsLoad_Click(object sender, EventArgs e)
        {

        }

        private void AlarmsSave_Click(object sender, EventArgs e)
        {

        }

        private void AlarmIntervals_ValueChanged(object sender, EventArgs e)
        
        {
            AlarmTimeIntervals = 1000;
            AlarmTimeIntervals =Convert.ToInt32( AlarmIntervals.Value * 1000);
        }

        string STSound = "";
        private void StSoundTest_Click(object sender, EventArgs e)
        {
            if (StSoundBox.Text != string.Empty)
            {
                SoundPlayer simpleSound = new SoundPlayer(Environment.CurrentDirectory + "\\Alarms\\" + StSoundBox.SelectedItem);
                simpleSound.Play();
            }
            else
            {
                MessageBox.Show("Select a sound from the list.");
            }
        }

        private void StSoundBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            STSound = Application.StartupPath + "\\Alarms\\" + StSoundBox.SelectedItem;
        }

        private void StSoundBox_DropDown(object sender, EventArgs e)
        {
            if (StSoundBox.Items.Count > 0)
            {
                StSoundBox.Items.Clear();
            }
            foreach (var sound in Directory.GetFiles(Environment.CurrentDirectory + "\\Alarms"))
            {
                StSoundBox.Items.Add(Path.GetFileName(sound));
            }
        }

        private void StSoundBox_DropDownClosed(object sender, EventArgs e)
        {
            if (StSoundBox.SelectedItem == null)
            {
                StSoundBox.SelectedIndex = 0;
            }
        }

        private void StatusTimerInterval_ValueChanged(object sender, EventArgs e)
        {
            //StatusTimeInterval = 1000;
            StatusTimeInterval = Convert.ToInt32(StatusTimerInterval.Value * 1000);
        }

        
        
    }
}
