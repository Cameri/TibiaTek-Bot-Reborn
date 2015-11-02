namespace TibiaTekBot
{
    partial class HelerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelerForm));
            this.HealingTabControl = new System.Windows.Forms.TabControl();
            this.HealingTab1 = new System.Windows.Forms.TabPage();
            this.HealerBox = new System.Windows.Forms.GroupBox();
            this.HealPotionHpPanel = new System.Windows.Forms.Panel();
            this.HealPotionPercent = new System.Windows.Forms.NumericUpDown();
            this.HealPotionHp = new System.Windows.Forms.NumericUpDown();
            this.HealPotionUsePercent = new System.Windows.Forms.RadioButton();
            this.HealPotionUseHp = new System.Windows.Forms.RadioButton();
            this.HealRuneHpPanel = new System.Windows.Forms.Panel();
            this.HealRunePercent = new System.Windows.Forms.NumericUpDown();
            this.HealRuneHP = new System.Windows.Forms.NumericUpDown();
            this.HealRuneUsePercent = new System.Windows.Forms.RadioButton();
            this.HealRuneUseHp = new System.Windows.Forms.RadioButton();
            this.HealSpellHPPanel = new System.Windows.Forms.Panel();
            this.HealSpellPercent = new System.Windows.Forms.NumericUpDown();
            this.HealSpellUsePercent = new System.Windows.Forms.RadioButton();
            this.HealSpellHp = new System.Windows.Forms.NumericUpDown();
            this.HealSpellUseHP = new System.Windows.Forms.RadioButton();
            this.HealWithPotion = new System.Windows.Forms.CheckBox();
            this.HealPotionName = new System.Windows.Forms.ComboBox();
            this.HealSpellName = new System.Windows.Forms.ComboBox();
            this.HealWithSpell = new System.Windows.Forms.CheckBox();
            this.HealRuneType = new System.Windows.Forms.ComboBox();
            this.HealWithRune = new System.Windows.Forms.CheckBox();
            this.DrinkerBox = new System.Windows.Forms.GroupBox();
            this.ManaPotionName = new System.Windows.Forms.ComboBox();
            this.RestoreManaWith = new System.Windows.Forms.CheckBox();
            this.DrinkerManaPoints = new System.Windows.Forms.NumericUpDown();
            this.DrinkerManalbl = new System.Windows.Forms.Label();
            this.HealingTab2 = new System.Windows.Forms.TabPage();
            this.GroupBox17 = new System.Windows.Forms.GroupBox();
            this.FriendHealerHelp = new System.Windows.Forms.Button();
            this.HealFriendTrigger = new System.Windows.Forms.CheckBox();
            this.HealFHp = new System.Windows.Forms.NumericUpDown();
            this.HealFHplbl = new System.Windows.Forms.Label();
            this.HealFName = new System.Windows.Forms.TextBox();
            this.HealFNamelbl = new System.Windows.Forms.Label();
            this.HealFType = new System.Windows.Forms.ComboBox();
            this.HealFTypelbl = new System.Windows.Forms.Label();
            this.GroupBox19 = new System.Windows.Forms.GroupBox();
            this.PartyHealerHelp = new System.Windows.Forms.Button();
            this.HealPartyTrigger = new System.Windows.Forms.CheckBox();
            this.HealPHp = new System.Windows.Forms.NumericUpDown();
            this.HealP = new System.Windows.Forms.Label();
            this.HealPType = new System.Windows.Forms.ComboBox();
            this.HealPlbl = new System.Windows.Forms.Label();
            this.HideButtom = new System.Windows.Forms.Button();
            this.HealingTabControl.SuspendLayout();
            this.HealingTab1.SuspendLayout();
            this.HealerBox.SuspendLayout();
            this.HealPotionHpPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HealPotionPercent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HealPotionHp)).BeginInit();
            this.HealRuneHpPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HealRunePercent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HealRuneHP)).BeginInit();
            this.HealSpellHPPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HealSpellPercent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HealSpellHp)).BeginInit();
            this.DrinkerBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DrinkerManaPoints)).BeginInit();
            this.HealingTab2.SuspendLayout();
            this.GroupBox17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HealFHp)).BeginInit();
            this.GroupBox19.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HealPHp)).BeginInit();
            this.SuspendLayout();
            // 
            // HealingTabControl
            // 
            this.HealingTabControl.Controls.Add(this.HealingTab1);
            this.HealingTabControl.Controls.Add(this.HealingTab2);
            this.HealingTabControl.Location = new System.Drawing.Point(3, 2);
            this.HealingTabControl.Name = "HealingTabControl";
            this.HealingTabControl.SelectedIndex = 0;
            this.HealingTabControl.Size = new System.Drawing.Size(403, 339);
            this.HealingTabControl.TabIndex = 1;
            // 
            // HealingTab1
            // 
            this.HealingTab1.Controls.Add(this.HealerBox);
            this.HealingTab1.Controls.Add(this.DrinkerBox);
            this.HealingTab1.Location = new System.Drawing.Point(4, 22);
            this.HealingTab1.Name = "HealingTab1";
            this.HealingTab1.Padding = new System.Windows.Forms.Padding(3);
            this.HealingTab1.Size = new System.Drawing.Size(395, 313);
            this.HealingTab1.TabIndex = 0;
            this.HealingTab1.Text = "Part I";
            this.HealingTab1.UseVisualStyleBackColor = true;
            // 
            // HealerBox
            // 
            this.HealerBox.Controls.Add(this.HealPotionHpPanel);
            this.HealerBox.Controls.Add(this.HealRuneHpPanel);
            this.HealerBox.Controls.Add(this.HealSpellHPPanel);
            this.HealerBox.Controls.Add(this.HealWithPotion);
            this.HealerBox.Controls.Add(this.HealPotionName);
            this.HealerBox.Controls.Add(this.HealSpellName);
            this.HealerBox.Controls.Add(this.HealWithSpell);
            this.HealerBox.Controls.Add(this.HealRuneType);
            this.HealerBox.Controls.Add(this.HealWithRune);
            this.HealerBox.Location = new System.Drawing.Point(6, 6);
            this.HealerBox.Name = "HealerBox";
            this.HealerBox.Size = new System.Drawing.Size(187, 287);
            this.HealerBox.TabIndex = 13;
            this.HealerBox.TabStop = false;
            this.HealerBox.Text = "Self Healer";
            // 
            // HealPotionHpPanel
            // 
            this.HealPotionHpPanel.Controls.Add(this.HealPotionPercent);
            this.HealPotionHpPanel.Controls.Add(this.HealPotionHp);
            this.HealPotionHpPanel.Controls.Add(this.HealPotionUsePercent);
            this.HealPotionHpPanel.Controls.Add(this.HealPotionUseHp);
            this.HealPotionHpPanel.Location = new System.Drawing.Point(7, 219);
            this.HealPotionHpPanel.Name = "HealPotionHpPanel";
            this.HealPotionHpPanel.Size = new System.Drawing.Size(173, 53);
            this.HealPotionHpPanel.TabIndex = 23;
            // 
            // HealPotionPercent
            // 
            this.HealPotionPercent.Location = new System.Drawing.Point(119, 24);
            this.HealPotionPercent.Name = "HealPotionPercent";
            this.HealPotionPercent.Size = new System.Drawing.Size(52, 20);
            this.HealPotionPercent.TabIndex = 3;
            this.HealPotionPercent.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // HealPotionHp
            // 
            this.HealPotionHp.Location = new System.Drawing.Point(119, 1);
            this.HealPotionHp.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.HealPotionHp.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.HealPotionHp.Name = "HealPotionHp";
            this.HealPotionHp.Size = new System.Drawing.Size(52, 20);
            this.HealPotionHp.TabIndex = 2;
            this.HealPotionHp.ThousandsSeparator = true;
            this.HealPotionHp.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // HealPotionUsePercent
            // 
            this.HealPotionUsePercent.AutoSize = true;
            this.HealPotionUsePercent.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.HealPotionUsePercent.Location = new System.Drawing.Point(3, 24);
            this.HealPotionUsePercent.Name = "HealPotionUsePercent";
            this.HealPotionUsePercent.Size = new System.Drawing.Size(110, 17);
            this.HealPotionUsePercent.TabIndex = 1;
            this.HealPotionUsePercent.TabStop = true;
            this.HealPotionUsePercent.Text = "Hit Points Percent";
            this.HealPotionUsePercent.UseVisualStyleBackColor = true;
            // 
            // HealPotionUseHp
            // 
            this.HealPotionUseHp.AutoSize = true;
            this.HealPotionUseHp.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.HealPotionUseHp.Location = new System.Drawing.Point(3, 1);
            this.HealPotionUseHp.Name = "HealPotionUseHp";
            this.HealPotionUseHp.Size = new System.Drawing.Size(70, 17);
            this.HealPotionUseHp.TabIndex = 0;
            this.HealPotionUseHp.TabStop = true;
            this.HealPotionUseHp.Text = "Hit Points";
            this.HealPotionUseHp.UseVisualStyleBackColor = true;
            // 
            // HealRuneHpPanel
            // 
            this.HealRuneHpPanel.Controls.Add(this.HealRunePercent);
            this.HealRuneHpPanel.Controls.Add(this.HealRuneHP);
            this.HealRuneHpPanel.Controls.Add(this.HealRuneUsePercent);
            this.HealRuneHpPanel.Controls.Add(this.HealRuneUseHp);
            this.HealRuneHpPanel.Location = new System.Drawing.Point(6, 40);
            this.HealRuneHpPanel.Name = "HealRuneHpPanel";
            this.HealRuneHpPanel.Size = new System.Drawing.Size(174, 53);
            this.HealRuneHpPanel.TabIndex = 23;
            // 
            // HealRunePercent
            // 
            this.HealRunePercent.Location = new System.Drawing.Point(119, 24);
            this.HealRunePercent.Name = "HealRunePercent";
            this.HealRunePercent.Size = new System.Drawing.Size(53, 20);
            this.HealRunePercent.TabIndex = 3;
            this.HealRunePercent.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // HealRuneHP
            // 
            this.HealRuneHP.Location = new System.Drawing.Point(119, 1);
            this.HealRuneHP.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.HealRuneHP.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.HealRuneHP.Name = "HealRuneHP";
            this.HealRuneHP.Size = new System.Drawing.Size(53, 20);
            this.HealRuneHP.TabIndex = 2;
            this.HealRuneHP.ThousandsSeparator = true;
            this.HealRuneHP.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // HealRuneUsePercent
            // 
            this.HealRuneUsePercent.AutoSize = true;
            this.HealRuneUsePercent.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.HealRuneUsePercent.Location = new System.Drawing.Point(3, 24);
            this.HealRuneUsePercent.Name = "HealRuneUsePercent";
            this.HealRuneUsePercent.Size = new System.Drawing.Size(110, 17);
            this.HealRuneUsePercent.TabIndex = 1;
            this.HealRuneUsePercent.TabStop = true;
            this.HealRuneUsePercent.Text = "Hit Points Percent";
            this.HealRuneUsePercent.UseVisualStyleBackColor = true;
            // 
            // HealRuneUseHp
            // 
            this.HealRuneUseHp.AutoSize = true;
            this.HealRuneUseHp.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.HealRuneUseHp.Location = new System.Drawing.Point(3, 1);
            this.HealRuneUseHp.Name = "HealRuneUseHp";
            this.HealRuneUseHp.Size = new System.Drawing.Size(70, 17);
            this.HealRuneUseHp.TabIndex = 0;
            this.HealRuneUseHp.TabStop = true;
            this.HealRuneUseHp.Text = "Hit Points";
            this.HealRuneUseHp.UseVisualStyleBackColor = true;
            // 
            // HealSpellHPPanel
            // 
            this.HealSpellHPPanel.Controls.Add(this.HealSpellPercent);
            this.HealSpellHPPanel.Controls.Add(this.HealSpellUsePercent);
            this.HealSpellHPPanel.Controls.Add(this.HealSpellHp);
            this.HealSpellHPPanel.Controls.Add(this.HealSpellUseHP);
            this.HealSpellHPPanel.Location = new System.Drawing.Point(5, 128);
            this.HealSpellHPPanel.Name = "HealSpellHPPanel";
            this.HealSpellHPPanel.Size = new System.Drawing.Size(175, 56);
            this.HealSpellHPPanel.TabIndex = 22;
            // 
            // HealSpellPercent
            // 
            this.HealSpellPercent.Location = new System.Drawing.Point(119, 25);
            this.HealSpellPercent.Name = "HealSpellPercent";
            this.HealSpellPercent.Size = new System.Drawing.Size(54, 20);
            this.HealSpellPercent.TabIndex = 3;
            this.HealSpellPercent.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // HealSpellUsePercent
            // 
            this.HealSpellUsePercent.AutoSize = true;
            this.HealSpellUsePercent.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.HealSpellUsePercent.Location = new System.Drawing.Point(3, 25);
            this.HealSpellUsePercent.Name = "HealSpellUsePercent";
            this.HealSpellUsePercent.Size = new System.Drawing.Size(110, 17);
            this.HealSpellUsePercent.TabIndex = 2;
            this.HealSpellUsePercent.TabStop = true;
            this.HealSpellUsePercent.Text = "Hit Points Percent";
            this.HealSpellUsePercent.UseVisualStyleBackColor = true;
            // 
            // HealSpellHp
            // 
            this.HealSpellHp.Location = new System.Drawing.Point(119, 2);
            this.HealSpellHp.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.HealSpellHp.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.HealSpellHp.Name = "HealSpellHp";
            this.HealSpellHp.Size = new System.Drawing.Size(54, 20);
            this.HealSpellHp.TabIndex = 1;
            this.HealSpellHp.ThousandsSeparator = true;
            this.HealSpellHp.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // HealSpellUseHP
            // 
            this.HealSpellUseHP.AutoSize = true;
            this.HealSpellUseHP.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.HealSpellUseHP.Location = new System.Drawing.Point(3, 2);
            this.HealSpellUseHP.Name = "HealSpellUseHP";
            this.HealSpellUseHP.Size = new System.Drawing.Size(70, 17);
            this.HealSpellUseHP.TabIndex = 0;
            this.HealSpellUseHP.TabStop = true;
            this.HealSpellUseHP.Text = "Hit Points";
            this.HealSpellUseHP.UseVisualStyleBackColor = true;
            // 
            // HealWithPotion
            // 
            this.HealWithPotion.AutoSize = true;
            this.HealWithPotion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.HealWithPotion.Location = new System.Drawing.Point(6, 192);
            this.HealWithPotion.Name = "HealWithPotion";
            this.HealWithPotion.Size = new System.Drawing.Size(81, 17);
            this.HealWithPotion.TabIndex = 19;
            this.HealWithPotion.Text = "With Potion";
            this.HealWithPotion.UseVisualStyleBackColor = true;
            // 
            // HealPotionName
            // 
            this.HealPotionName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HealPotionName.FormattingEnabled = true;
            this.HealPotionName.Items.AddRange(new object[] {
            "Health Potion",
            "Strong Health Potion",
            "Great Health Potion",
            "Ultimate Health Potion",
            "Spirit Potion"});
            this.HealPotionName.Location = new System.Drawing.Point(90, 192);
            this.HealPotionName.Name = "HealPotionName";
            this.HealPotionName.Size = new System.Drawing.Size(88, 21);
            this.HealPotionName.TabIndex = 18;
            // 
            // HealSpellName
            // 
            this.HealSpellName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HealSpellName.FormattingEnabled = true;
            this.HealSpellName.Location = new System.Drawing.Point(89, 103);
            this.HealSpellName.Name = "HealSpellName";
            this.HealSpellName.Size = new System.Drawing.Size(89, 21);
            this.HealSpellName.TabIndex = 13;
            // 
            // HealWithSpell
            // 
            this.HealWithSpell.AutoSize = true;
            this.HealWithSpell.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.HealWithSpell.Location = new System.Drawing.Point(6, 105);
            this.HealWithSpell.Name = "HealWithSpell";
            this.HealWithSpell.Size = new System.Drawing.Size(74, 17);
            this.HealWithSpell.TabIndex = 12;
            this.HealWithSpell.Text = "With Spell";
            this.HealWithSpell.UseVisualStyleBackColor = true;
            // 
            // HealRuneType
            // 
            this.HealRuneType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HealRuneType.FormattingEnabled = true;
            this.HealRuneType.Items.AddRange(new object[] {
            "UH Rune",
            "IH Rune"});
            this.HealRuneType.Location = new System.Drawing.Point(89, 16);
            this.HealRuneType.Name = "HealRuneType";
            this.HealRuneType.Size = new System.Drawing.Size(89, 21);
            this.HealRuneType.TabIndex = 10;
            // 
            // HealWithRune
            // 
            this.HealWithRune.AutoSize = true;
            this.HealWithRune.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.HealWithRune.Location = new System.Drawing.Point(6, 20);
            this.HealWithRune.Name = "HealWithRune";
            this.HealWithRune.Size = new System.Drawing.Size(77, 17);
            this.HealWithRune.TabIndex = 9;
            this.HealWithRune.Text = "With Rune";
            this.HealWithRune.UseVisualStyleBackColor = true;
            // 
            // DrinkerBox
            // 
            this.DrinkerBox.Controls.Add(this.ManaPotionName);
            this.DrinkerBox.Controls.Add(this.RestoreManaWith);
            this.DrinkerBox.Controls.Add(this.DrinkerManaPoints);
            this.DrinkerBox.Controls.Add(this.DrinkerManalbl);
            this.DrinkerBox.Location = new System.Drawing.Point(199, 6);
            this.DrinkerBox.Name = "DrinkerBox";
            this.DrinkerBox.Size = new System.Drawing.Size(190, 77);
            this.DrinkerBox.TabIndex = 22;
            this.DrinkerBox.TabStop = false;
            this.DrinkerBox.Text = "Mana Potion Drinker";
            // 
            // ManaPotionName
            // 
            this.ManaPotionName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ManaPotionName.FormattingEnabled = true;
            this.ManaPotionName.Items.AddRange(new object[] {
            "Mana Potion",
            "Strong Mana Potion",
            "Great Mana Potion",
            "Spirit Potion"});
            this.ManaPotionName.Location = new System.Drawing.Point(91, 18);
            this.ManaPotionName.Name = "ManaPotionName";
            this.ManaPotionName.Size = new System.Drawing.Size(89, 21);
            this.ManaPotionName.TabIndex = 15;
            // 
            // RestoreManaWith
            // 
            this.RestoreManaWith.AutoSize = true;
            this.RestoreManaWith.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.RestoreManaWith.Location = new System.Drawing.Point(6, 19);
            this.RestoreManaWith.Name = "RestoreManaWith";
            this.RestoreManaWith.Size = new System.Drawing.Size(81, 17);
            this.RestoreManaWith.TabIndex = 14;
            this.RestoreManaWith.Text = "With Potion";
            this.RestoreManaWith.UseVisualStyleBackColor = true;
            // 
            // DrinkerManaPoints
            // 
            this.DrinkerManaPoints.Location = new System.Drawing.Point(104, 45);
            this.DrinkerManaPoints.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.DrinkerManaPoints.Name = "DrinkerManaPoints";
            this.DrinkerManaPoints.Size = new System.Drawing.Size(76, 20);
            this.DrinkerManaPoints.TabIndex = 1;
            this.DrinkerManaPoints.ThousandsSeparator = true;
            // 
            // DrinkerManalbl
            // 
            this.DrinkerManalbl.AutoSize = true;
            this.DrinkerManalbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DrinkerManalbl.Location = new System.Drawing.Point(6, 47);
            this.DrinkerManalbl.Name = "DrinkerManalbl";
            this.DrinkerManalbl.Size = new System.Drawing.Size(92, 13);
            this.DrinkerManalbl.TabIndex = 0;
            this.DrinkerManalbl.Text = "Min. Mana Points:";
            // 
            // HealingTab2
            // 
            this.HealingTab2.Controls.Add(this.GroupBox17);
            this.HealingTab2.Controls.Add(this.GroupBox19);
            this.HealingTab2.Location = new System.Drawing.Point(4, 22);
            this.HealingTab2.Name = "HealingTab2";
            this.HealingTab2.Padding = new System.Windows.Forms.Padding(3);
            this.HealingTab2.Size = new System.Drawing.Size(395, 313);
            this.HealingTab2.TabIndex = 1;
            this.HealingTab2.Text = "Part II";
            this.HealingTab2.UseVisualStyleBackColor = true;
            // 
            // GroupBox17
            // 
            this.GroupBox17.Controls.Add(this.FriendHealerHelp);
            this.GroupBox17.Controls.Add(this.HealFriendTrigger);
            this.GroupBox17.Controls.Add(this.HealFHp);
            this.GroupBox17.Controls.Add(this.HealFHplbl);
            this.GroupBox17.Controls.Add(this.HealFName);
            this.GroupBox17.Controls.Add(this.HealFNamelbl);
            this.GroupBox17.Controls.Add(this.HealFType);
            this.GroupBox17.Controls.Add(this.HealFTypelbl);
            this.GroupBox17.Location = new System.Drawing.Point(6, 114);
            this.GroupBox17.Name = "GroupBox17";
            this.GroupBox17.Size = new System.Drawing.Size(195, 129);
            this.GroupBox17.TabIndex = 20;
            this.GroupBox17.TabStop = false;
            this.GroupBox17.Text = "Friend Healer";
            // 
            // FriendHealerHelp
            // 
            this.FriendHealerHelp.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.FriendHealerHelp.Location = new System.Drawing.Point(163, 96);
            this.FriendHealerHelp.Name = "FriendHealerHelp";
            this.FriendHealerHelp.Size = new System.Drawing.Size(26, 24);
            this.FriendHealerHelp.TabIndex = 10;
            this.FriendHealerHelp.Text = "?";
            this.FriendHealerHelp.UseVisualStyleBackColor = true;
            // 
            // HealFriendTrigger
            // 
            this.HealFriendTrigger.Appearance = System.Windows.Forms.Appearance.Button;
            this.HealFriendTrigger.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.HealFriendTrigger.Location = new System.Drawing.Point(5, 96);
            this.HealFriendTrigger.Name = "HealFriendTrigger";
            this.HealFriendTrigger.Size = new System.Drawing.Size(74, 24);
            this.HealFriendTrigger.TabIndex = 9;
            this.HealFriendTrigger.Text = "Activate";
            this.HealFriendTrigger.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HealFriendTrigger.UseVisualStyleBackColor = true;
            // 
            // HealFHp
            // 
            this.HealFHp.Location = new System.Drawing.Point(104, 69);
            this.HealFHp.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.HealFHp.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.HealFHp.Name = "HealFHp";
            this.HealFHp.Size = new System.Drawing.Size(85, 20);
            this.HealFHp.TabIndex = 5;
            this.HealFHp.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // HealFHplbl
            // 
            this.HealFHplbl.AutoSize = true;
            this.HealFHplbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.HealFHplbl.Location = new System.Drawing.Point(6, 71);
            this.HealFHplbl.Name = "HealFHplbl";
            this.HealFHplbl.Size = new System.Drawing.Size(95, 13);
            this.HealFHplbl.TabIndex = 4;
            this.HealFHplbl.Text = "Hit Points Percent:";
            // 
            // HealFName
            // 
            this.HealFName.Location = new System.Drawing.Point(50, 16);
            this.HealFName.Name = "HealFName";
            this.HealFName.Size = new System.Drawing.Size(139, 20);
            this.HealFName.TabIndex = 3;
            // 
            // HealFNamelbl
            // 
            this.HealFNamelbl.AutoSize = true;
            this.HealFNamelbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.HealFNamelbl.Location = new System.Drawing.Point(6, 19);
            this.HealFNamelbl.Name = "HealFNamelbl";
            this.HealFNamelbl.Size = new System.Drawing.Size(38, 13);
            this.HealFNamelbl.TabIndex = 2;
            this.HealFNamelbl.Text = "Name:";
            // 
            // HealFType
            // 
            this.HealFType.FormattingEnabled = true;
            this.HealFType.Items.AddRange(new object[] {
            "Ultimate Healing Rune",
            "Exura Sio - Spell",
            "Both"});
            this.HealFType.Location = new System.Drawing.Point(65, 42);
            this.HealFType.Name = "HealFType";
            this.HealFType.Size = new System.Drawing.Size(124, 21);
            this.HealFType.TabIndex = 1;
            // 
            // HealFTypelbl
            // 
            this.HealFTypelbl.AutoSize = true;
            this.HealFTypelbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.HealFTypelbl.Location = new System.Drawing.Point(6, 45);
            this.HealFTypelbl.Name = "HealFTypelbl";
            this.HealFTypelbl.Size = new System.Drawing.Size(54, 13);
            this.HealFTypelbl.TabIndex = 0;
            this.HealFTypelbl.Text = "Heal with:";
            // 
            // GroupBox19
            // 
            this.GroupBox19.Controls.Add(this.PartyHealerHelp);
            this.GroupBox19.Controls.Add(this.HealPartyTrigger);
            this.GroupBox19.Controls.Add(this.HealPHp);
            this.GroupBox19.Controls.Add(this.HealP);
            this.GroupBox19.Controls.Add(this.HealPType);
            this.GroupBox19.Controls.Add(this.HealPlbl);
            this.GroupBox19.Location = new System.Drawing.Point(6, 6);
            this.GroupBox19.Name = "GroupBox19";
            this.GroupBox19.Size = new System.Drawing.Size(198, 102);
            this.GroupBox19.TabIndex = 21;
            this.GroupBox19.TabStop = false;
            this.GroupBox19.Text = "Party Healer";
            // 
            // PartyHealerHelp
            // 
            this.PartyHealerHelp.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.PartyHealerHelp.Location = new System.Drawing.Point(166, 69);
            this.PartyHealerHelp.Name = "PartyHealerHelp";
            this.PartyHealerHelp.Size = new System.Drawing.Size(26, 24);
            this.PartyHealerHelp.TabIndex = 13;
            this.PartyHealerHelp.Text = "?";
            this.PartyHealerHelp.UseVisualStyleBackColor = true;
            // 
            // HealPartyTrigger
            // 
            this.HealPartyTrigger.Appearance = System.Windows.Forms.Appearance.Button;
            this.HealPartyTrigger.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.HealPartyTrigger.Location = new System.Drawing.Point(5, 69);
            this.HealPartyTrigger.Name = "HealPartyTrigger";
            this.HealPartyTrigger.Size = new System.Drawing.Size(74, 24);
            this.HealPartyTrigger.TabIndex = 12;
            this.HealPartyTrigger.Text = "Activate";
            this.HealPartyTrigger.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HealPartyTrigger.UseVisualStyleBackColor = true;
            // 
            // HealPHp
            // 
            this.HealPHp.Location = new System.Drawing.Point(107, 43);
            this.HealPHp.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.HealPHp.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.HealPHp.Name = "HealPHp";
            this.HealPHp.Size = new System.Drawing.Size(85, 20);
            this.HealPHp.TabIndex = 11;
            this.HealPHp.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // HealP
            // 
            this.HealP.AutoSize = true;
            this.HealP.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.HealP.Location = new System.Drawing.Point(6, 46);
            this.HealP.Name = "HealP";
            this.HealP.Size = new System.Drawing.Size(95, 13);
            this.HealP.TabIndex = 10;
            this.HealP.Text = "Hit Points Percent:";
            // 
            // HealPType
            // 
            this.HealPType.FormattingEnabled = true;
            this.HealPType.Items.AddRange(new object[] {
            "Ultimate Healing Rune",
            "Exura Sio - Spell",
            "Both"});
            this.HealPType.Location = new System.Drawing.Point(65, 13);
            this.HealPType.Name = "HealPType";
            this.HealPType.Size = new System.Drawing.Size(127, 21);
            this.HealPType.TabIndex = 3;
            // 
            // HealPlbl
            // 
            this.HealPlbl.AutoSize = true;
            this.HealPlbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.HealPlbl.Location = new System.Drawing.Point(6, 19);
            this.HealPlbl.Name = "HealPlbl";
            this.HealPlbl.Size = new System.Drawing.Size(54, 13);
            this.HealPlbl.TabIndex = 2;
            this.HealPlbl.Text = "Heal with:";
            // 
            // HideButtom
            // 
            this.HideButtom.Location = new System.Drawing.Point(331, 347);
            this.HideButtom.Name = "HideButtom";
            this.HideButtom.Size = new System.Drawing.Size(75, 23);
            this.HideButtom.TabIndex = 2;
            this.HideButtom.Text = "Hide";
            this.HideButtom.UseVisualStyleBackColor = true;
            this.HideButtom.Click += new System.EventHandler(this.HideButtom_Click);
            // 
            // HelerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 375);
            this.Controls.Add(this.HideButtom);
            this.Controls.Add(this.HealingTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "HelerForm";
            this.Text = "Heler";
            this.Load += new System.EventHandler(this.HelerForm_Load);
            this.HealingTabControl.ResumeLayout(false);
            this.HealingTab1.ResumeLayout(false);
            this.HealerBox.ResumeLayout(false);
            this.HealerBox.PerformLayout();
            this.HealPotionHpPanel.ResumeLayout(false);
            this.HealPotionHpPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HealPotionPercent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HealPotionHp)).EndInit();
            this.HealRuneHpPanel.ResumeLayout(false);
            this.HealRuneHpPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HealRunePercent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HealRuneHP)).EndInit();
            this.HealSpellHPPanel.ResumeLayout(false);
            this.HealSpellHPPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HealSpellPercent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HealSpellHp)).EndInit();
            this.DrinkerBox.ResumeLayout(false);
            this.DrinkerBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DrinkerManaPoints)).EndInit();
            this.HealingTab2.ResumeLayout(false);
            this.GroupBox17.ResumeLayout(false);
            this.GroupBox17.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HealFHp)).EndInit();
            this.GroupBox19.ResumeLayout(false);
            this.GroupBox19.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HealPHp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.TabControl HealingTabControl;
        internal System.Windows.Forms.TabPage HealingTab1;
        internal System.Windows.Forms.GroupBox HealerBox;
        internal System.Windows.Forms.Panel HealPotionHpPanel;
        internal System.Windows.Forms.NumericUpDown HealPotionPercent;
        internal System.Windows.Forms.NumericUpDown HealPotionHp;
        internal System.Windows.Forms.RadioButton HealPotionUsePercent;
        internal System.Windows.Forms.RadioButton HealPotionUseHp;
        internal System.Windows.Forms.Panel HealRuneHpPanel;
        internal System.Windows.Forms.NumericUpDown HealRunePercent;
        internal System.Windows.Forms.NumericUpDown HealRuneHP;
        internal System.Windows.Forms.RadioButton HealRuneUsePercent;
        internal System.Windows.Forms.RadioButton HealRuneUseHp;
        internal System.Windows.Forms.Panel HealSpellHPPanel;
        internal System.Windows.Forms.NumericUpDown HealSpellPercent;
        internal System.Windows.Forms.RadioButton HealSpellUsePercent;
        internal System.Windows.Forms.NumericUpDown HealSpellHp;
        internal System.Windows.Forms.RadioButton HealSpellUseHP;
        internal System.Windows.Forms.CheckBox HealWithPotion;
        internal System.Windows.Forms.ComboBox HealPotionName;
        internal System.Windows.Forms.ComboBox HealSpellName;
        internal System.Windows.Forms.CheckBox HealWithSpell;
        internal System.Windows.Forms.ComboBox HealRuneType;
        internal System.Windows.Forms.CheckBox HealWithRune;
        internal System.Windows.Forms.GroupBox DrinkerBox;
        internal System.Windows.Forms.ComboBox ManaPotionName;
        internal System.Windows.Forms.CheckBox RestoreManaWith;
        internal System.Windows.Forms.NumericUpDown DrinkerManaPoints;
        internal System.Windows.Forms.Label DrinkerManalbl;
        internal System.Windows.Forms.TabPage HealingTab2;
        internal System.Windows.Forms.GroupBox GroupBox17;
        internal System.Windows.Forms.Button FriendHealerHelp;
        internal System.Windows.Forms.CheckBox HealFriendTrigger;
        internal System.Windows.Forms.NumericUpDown HealFHp;
        internal System.Windows.Forms.Label HealFHplbl;
        internal System.Windows.Forms.TextBox HealFName;
        internal System.Windows.Forms.Label HealFNamelbl;
        internal System.Windows.Forms.ComboBox HealFType;
        internal System.Windows.Forms.Label HealFTypelbl;
        internal System.Windows.Forms.GroupBox GroupBox19;
        internal System.Windows.Forms.Button PartyHealerHelp;
        internal System.Windows.Forms.CheckBox HealPartyTrigger;
        internal System.Windows.Forms.NumericUpDown HealPHp;
        internal System.Windows.Forms.Label HealP;
        internal System.Windows.Forms.ComboBox HealPType;
        internal System.Windows.Forms.Label HealPlbl;
        private System.Windows.Forms.Button HideButtom;
    }
}