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
    public partial class HelerForm : Form
    {
        Kernel kernel = new Kernel();
        
        public Tibia client;
        Log logs = new Log();
        int PlayerMana = 0;
        int PlayerMaxMana = 0;
        int PlayerHP = 0;
        int PlayerMaxHP = 0;
        string PlayerName = "";
        public HelerForm(Tibia client)
        {
            
            this.client = client;
            InitializeComponent();
        }

        private void HelerForm_Load(object sender, EventArgs e)
        {
            #region cargar todos los combobox
            CBctrlShift1.SelectedIndex = 0;//level 1
            CBFuntionKeys1.SelectedIndex = 0;//level 1

            CBctrlShift2.SelectedIndex = 0;//level 2
            CBFuntionKeys2.SelectedIndex = 0;//level 2

            CBctrlShift3.SelectedIndex = 0;//level 3
            CBFuntionKeys3.SelectedIndex = 0;//level 3

            CBAlternalKeys.SelectedIndex = 0;//Mana Drinker
            CBFuntionKeys.SelectedIndex = 0;//Mana Drinker

            CBUtamoKey.SelectedIndex = 0;//UtamoVita
            CBUtamoFuntions.SelectedIndex = 0;//UtamoVita
            #endregion
        }

        private void HideButtom_Click(object sender, EventArgs e)
        {
            Hide();
        }

        int utamovitainterval = 0;
        int CriticalHP, NormalHP, GoodHP = 0;
        private void HelerTimer_Tick(object sender, EventArgs e)
        {
            if (!client.IsConnected)
            {
               
                HelerTimerTrigger.Checked = false;
                MessageBox.Show("Character disconnected, Healer deactivated.");
                logs.SaveLog(DateTime.Now, "Disconnected", "Character disconnected, Healer deactivated.");
                return;

            }


            #region detectar HP y Mana del player
            PlayerName = kernel.Client.LocalPlayer.Name;
            PlayerHP = Convert.ToInt32(kernel.Client.LocalPlayer.HealthPoints);
            PlayerMana = Convert.ToInt32(kernel.Client.LocalPlayer.ManaPoints);
            PlayerMaxHP = Convert.ToInt32(kernel.Client.LocalPlayer.MaxHealthPoints);
            PlayerMaxMana = Convert.ToInt32(kernel.Client.LocalPlayer.MaxManaPoints);

            if (!client.IsConnected)
            {
                HelerTimerTrigger.Checked = false;
                logs.SaveLog(DateTime.Now, "Disconnected", "Character disconnected, Heler disable.");
                MessageBox.Show("Character disconnected, Heler disable.");
                return;
            }
            GBCharacter.Text = PlayerName;
            Manalabel.Text = "Mana: " + PlayerMana + "/" + PlayerMaxMana;
            HPlabel.Text = "HP: " + PlayerHP + "/" + PlayerMaxHP;

            #endregion

            #region hitpoints old
            //if (CBHitPointsOnOff.Checked)
            //{
            //    if (RBspell.Checked)
            //    {
            //        if (RBMinHitPoints.Checked == true && PlayerHP < MinHitPoints.Value)
            //        {
            //            kernel.Client.SendKeys(TBSpellToCast.Text+"{ENTER}");
            //        }
            //        if (RBPorcentHitPoint.Checked == true && PlayerHP < PlayerMaxHP * PorcentHitPoints.Value / 100)
            //        {
            //            kernel.Client.SendKeys(TBSpellToCast.Text + "{ENTER}");
            //        }
            //    }

            //    if (RBhotkeys.Checked)
            //    {
            //        if (CBUseAnItem.Checked && HealingItemOnBag.Value>0)
            //        {
                        
            //        }
            //        if (RBMinHitPoints.Checked==true && PlayerHP < MinHitPoints.Value)
            //        {
            //            kernel.Client.SendKeys(CBkeyHP.SelectedItem + "{" + CBFuntionKeyHP.SelectedItem + "}");
            //        }
            //        if (RBPorcentHitPoint.Checked == true && PlayerHP < PlayerMaxHP * PorcentHitPoints.Value / 100)
            //        {
            //            kernel.Client.SendKeys(CBkeyHP.SelectedItem + "{" + CBFuntionKeyHP.SelectedItem + "}");
            //        }

                   
            //    }
            //}
            #endregion

            #region mana drinker
            if (CBManaOnOff.Checked)
            {
                string ManaDrinkerCombination = "";
               
                if (CBAlternalKeys.SelectedItem.ToString() == "None")
                {
                    ManaDrinkerCombination = "";
                }
                if (CBAlternalKeys.SelectedItem.ToString() == "Ctrl")
                {
                    ManaDrinkerCombination = "^";
                }
                if (CBAlternalKeys.SelectedItem.ToString() == "Shift")
                {
                    ManaDrinkerCombination = "+";
                }

                if (ManaPotionInBag.Value>0 && PlayerMana < PlayerMaxMana * DrinkerManaPoints.Value / 100)
                {
                    kernel.Client.SendKeys(ManaDrinkerCombination + "{" + CBFuntionKeys.SelectedItem + "}");
                    logs.SaveLog(DateTime.Now, "Mana Drinker", "Using one of "+ManaPotionInBag.Value+" mana potions.");
                    ManaPotionInBag.Value--;
                    return;
                }
                
            }


            #endregion

            #region Utamo Vita

            if (CBUtamoVita.Checked)
            {
                string UtamoVitaKey = "";

                if (CBUtamoKey.SelectedItem.ToString() == "None")
                {
                    UtamoVitaKey = "";
                }
                if (CBUtamoKey.SelectedItem.ToString() == "Ctrl")
                {
                    UtamoVitaKey = "^";
                }
                if (CBUtamoKey.SelectedItem.ToString() == "Shift")
                {
                    UtamoVitaKey = "+";
                }
                if (utamovitainterval == 0)
                {
                    kernel.Client.SendKeys("{ENTER}");
                    Thread.Sleep(100);
                    kernel.Client.SendKeys(UtamoVitaKey + "{" + CBUtamoFuntions.SelectedItem + "}");
                    utamovitainterval = 200;
                    UtamoVitaTimer.Text = "Cooldown: "+utamovitainterval;
                    logs.SaveLog(DateTime.Now, "Auto Utamo Vita", "Utamo Vita was cast.");
                }
                else
                {
                    utamovitainterval--;
                    UtamoVitaTimer.Text = "Cooldown: " + utamovitainterval;
                }
            }

            #endregion

            #region healer version 2

            #region level 3
            if (CBOnOff3.Checked)
            {
                string CBAlterText3 = "";
                if (CBctrlShift3.SelectedItem.ToString() == "None")
                {
                    CBAlterText3 = "";
                }
                if (CBctrlShift3.SelectedItem.ToString() == "Ctrl")
                {
                    CBAlterText3 = "^";
                }
                if (CBctrlShift3.SelectedItem.ToString() == "Shift")
                {
                    CBAlterText3 = "+";
                }

                if (CBuseItem3.Checked == true && UseItemCount3.Value > 0 && PlayerHP < PlayerMaxHP * HPProcent3.Value / 100)
                {
                    //MessageBox.Show("level 3, need item true\n\n" + testhp.Value + "\n" + 410 * HPProcent3.Value / 100);
                    kernel.Client.SendKeys(CBAlterText3 + "{" + CBFuntionKeys3.SelectedItem + "}");
                    logs.SaveLog(DateTime.Now, "Self Healing", "Self Healing level 3 (Critical Heal) was activate using item #" + UseItemCount3.Value);
                    client.SetStatusText("Self Healing level 3 (Critical Heal) was activate.");
                    UseItemCount3.Value--;
                    return;
                }
                else if (CBuseItem3.Checked == false && PlayerHP < PlayerMaxHP * HPProcent3.Value / 100)
                {
                    //MessageBox.Show("level 3, no need item true\n\n" + testhp.Value + "\n" + 410 * HPProcent3.Value / 100);
                    kernel.Client.SendKeys(CBAlterText3 + "{" + CBFuntionKeys3.SelectedItem + "}");
                    logs.SaveLog(DateTime.Now, "Self Healing", "Self Healing level 3 (Critical Heal) was activate.");
                    client.SetStatusText("Self Healing level 3 (Critical Heal) was activate.");
                    return;
                }
            }
            #endregion

            #region level 2
            if (CBOnOff2.Checked)
            {
                string CBAlterText2 = "";
                if (CBctrlShift2.SelectedItem.ToString() == "None")
                {
                    CBAlterText2 = "";
                }
                if (CBctrlShift2.SelectedItem.ToString() == "Ctrl")
                {
                    CBAlterText2 = "^";
                }
                if (CBctrlShift2.SelectedItem.ToString() == "Shift")
                {
                    CBAlterText2 = "+";
                }
                if (CBuseItem2.Checked == true && UseItemCount2.Value > 0 && PlayerHP < PlayerMaxHP * HPProcent2.Value / 100)
                {
                    //MessageBox.Show("level 2, need item true\n\n" + testhp.Value + "\n" + 410 * HPProcent2.Value / 100);
                    kernel.Client.SendKeys(CBAlterText2 + "{" + CBFuntionKeys2.SelectedItem + "}");
                    logs.SaveLog(DateTime.Now, "Self Healing", "Self Healing level 2 (Normal Heal) was activate using item #" + UseItemCount2.Value);
                    client.SetStatusText("Self Healing level 2 (Normal Heal) was activate.");
                    UseItemCount2.Value--;
                    return;
                }
                else if (CBuseItem2.Checked == false && PlayerHP < PlayerMaxHP * HPProcent2.Value / 100)
                {
                    //MessageBox.Show("level 2, no need item true\n\n" + testhp.Value + "\n" + 410 * HPProcent2.Value / 100);
                    kernel.Client.SendKeys(CBAlterText2 + "{" + CBFuntionKeys2.SelectedItem + "}");
                    logs.SaveLog(DateTime.Now, "Self Healing", "Self Healing level 2 (Normal Heal) was activate.");
                    client.SetStatusText("Self Healing level 2 (Normal Heal) was activate.");
                    return;
                }
            }
            #endregion

            #region level 1
            if (CBOnOff1.Checked)
            {
                string CBAlterText1 = "";
                if (CBctrlShift1.SelectedItem.ToString() == "None")
                {
                    CBAlterText1 = "";
                }
                if (CBctrlShift1.SelectedItem.ToString() == "Ctrl")
                {
                    CBAlterText1 = "^";
                }
                if (CBctrlShift1.SelectedItem.ToString() == "Shift")
                {
                    CBAlterText1 = "+";
                }
                if (CBuseItem1.Checked == true && UseItemCount1.Value > 0 && PlayerHP < PlayerMaxHP * HPProcent1.Value / 100)
                {
                    //MessageBox.Show("level 1, need item true\n\n" + testhp.Value + "\n" + 410 * HPProcent1.Value / 100);
                    kernel.Client.SendKeys(CBAlterText1 + "{" + CBFuntionKeys1.SelectedItem + "}");
                    logs.SaveLog(DateTime.Now, "Self Healing", "Self Healing level 1 (Good Heal) was activate using item #" + UseItemCount1.Value);
                    client.SetStatusText("Self Healing level 1 (Good Heal) was activate.");
                    UseItemCount1.Value--;
                    return;
                }
                else if (CBuseItem1.Checked == false && PlayerHP < PlayerMaxHP * HPProcent1.Value / 100)
                {
                    //MessageBox.Show("level 1, no need item true\n\n" + testhp.Value + "\n" + 410 * HPProcent1.Value / 100);
                    kernel.Client.SendKeys(CBAlterText1 + "{" + CBFuntionKeys1.SelectedItem + "}");
                    logs.SaveLog(DateTime.Now, "Self Healing", "Self Healing level 1 (Good Heal) was.");
                    client.SetStatusText("Self Healing level 1 (Good Heal) was activate.");
                    return;
                }
            }
            #endregion
           
            #endregion

        }

        private void HelerTimerTrigger_CheckedChanged(object sender, EventArgs e)
        {
            if (HelerTimerTrigger.Checked)
            {
                HelerTimerTrigger.Text = "Deactivate";
                HelerTimer.Enabled = true;
               
            }
            else
            {
                HelerTimer.Enabled = false;
                HelerTimerTrigger.Text = "Activate";
                Manalabel.Text = "Mana: 0/0";
                HPlabel.Text = "HP: 0/0";
                GBCharacter.Text = "N/A";
            }
        }

        private void RBspell_CheckedChanged(object sender, EventArgs e)
        {
            PanelSpell.Visible = true;
            PanelHotKeys.Visible = false;

            HealingItemOnBag.Enabled = false;
            HealingItemOnBag.Value = 0;
            CBUseAnItem.Enabled = false;
        }

        private void RBhotkeys_CheckedChanged(object sender, EventArgs e)
        {
            PanelSpell.Visible = false;
            PanelHotKeys.Visible = true;
            HealingItemOnBag.Enabled = true;
            CBUseAnItem.Enabled = true;
        }

        private void RBMinHitPoints_CheckedChanged(object sender, EventArgs e)
        {
            MinHitPoints.Enabled = true;
            PorcentHitPoints.Enabled = false;
        }

        private void RBporcentHitPoint_CheckedChanged(object sender, EventArgs e)
        {
            MinHitPoints.Enabled = false;
            PorcentHitPoints.Enabled = true;
        }

        private void CBHitPointsOnOff_CheckedChanged(object sender, EventArgs e)
        {
            if (CBHitPointsOnOff.Checked)
            {
                CBHitPointsOnOff.Text = "On";
            }
            else
            {
                CBHitPointsOnOff.Text = "Off";
            }
        }

        private void CBManaOnOff_CheckedChanged(object sender, EventArgs e)
        {
            if (CBManaOnOff.Checked)
            {
                CBManaOnOff.Text = "On";
            }
            else
            {
                CBManaOnOff.Text = "Off";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(PlayerHP +"\n\n"+ PlayerMaxHP * PorcentHitPoints.Value / 100);
        }

        private void CBUtamoVita_CheckedChanged(object sender, EventArgs e)
        {
            utamovitainterval = 189;
        }

        private void testbuttom_Click(object sender, EventArgs e)
        {
            //Math.Min(Math.Min(Math.Max(x, y), Math.Max(y, z)), Math.Max(x, z));

            //int[] numbers = new int[] { Convert.ToInt32(HPProcent1.Value), Convert.ToInt32(HPProcent2.Value), Convert.ToInt32(HPProcent3.Value) };
            //CriticalHP = numbers.Max();
            //GoodHP = numbers.Min();
            //NormalHP = Math.Min(Math.Min(Math.Max(Convert.ToInt32(HPProcent1.Value), Convert.ToInt32(HPProcent2.Value)), Math.Max(Convert.ToInt32(HPProcent2.Value), Convert.ToInt32(HPProcent3.Value))), Math.Max(Convert.ToInt32(HPProcent1.Value), Convert.ToInt32(HPProcent3.Value)));
            //MessageBox.Show(CriticalHP.ToString() + "\n" + NormalHP.ToString() + "\n" + GoodHP.ToString());
            

        }

        private void CBUtamoVita_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void CBctrlShift1_DropDownClosed(object sender, EventArgs e)
        {
            if (CBctrlShift1.SelectedItem == null)
            {
                CBctrlShift1.SelectedIndex = 0;
            }
        }

        private void CBFuntionKeys1_DropDownClosed(object sender, EventArgs e)
        {
            if (CBFuntionKeys1.SelectedItem == null)
            {
                CBFuntionKeys1.SelectedIndex = 0;
            }
        }

        private void CBctrlShift2_DropDownClosed(object sender, EventArgs e)
        {
            if (CBctrlShift2.SelectedItem == null)
            {
                CBctrlShift2.SelectedIndex = 0;
            }
        }

        private void CBFuntionKeys2_DropDownClosed(object sender, EventArgs e)
        {
            if (CBFuntionKeys2.SelectedItem == null)
            {
                CBFuntionKeys2.SelectedIndex = 0;
            }
        }

        private void CBctrlShift3_DropDownClosed(object sender, EventArgs e)
        {
            if (CBctrlShift3.SelectedItem == null)
            {
                CBctrlShift3.SelectedIndex = 0;
            }
        }

        private void CBFuntionKeys3_DropDownClosed(object sender, EventArgs e)
        {
            if (CBFuntionKeys3.SelectedItem == null)
            {
                CBFuntionKeys3.SelectedIndex = 0;
            }
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

        private void CBUtamoKey_DropDownClosed(object sender, EventArgs e)
        {
            if (CBUtamoKey.SelectedItem == null)
            {
                CBUtamoKey.SelectedIndex = 0;
            }
        }

        private void CBUtamoFuntions_DropDownClosed(object sender, EventArgs e)
        {
            if (CBUtamoFuntions.SelectedItem == null)
            {
                CBUtamoFuntions.SelectedIndex = 0;
            }
        }
    }
}
