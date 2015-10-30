namespace TibiaTekBot
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.AutoLooterBox = new System.Windows.Forms.GroupBox();
            this.AutoLooterHelp = new System.Windows.Forms.Button();
            this.AutoLooterEatFromCorpse = new System.Windows.Forms.CheckBox();
            this.AutoLooterlbl = new System.Windows.Forms.Label();
            this.AutoLooterMinCap = new System.Windows.Forms.NumericUpDown();
            this.AutoLooterConfigure = new System.Windows.Forms.Button();
            this.AutoLooterTrigger = new System.Windows.Forms.CheckBox();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.SpellCasterHelp = new System.Windows.Forms.Button();
            this.SpellCasterTrigger = new System.Windows.Forms.CheckBox();
            this.SpellCasterMinimumManaPoints = new System.Windows.Forms.NumericUpDown();
            this.Label3 = new System.Windows.Forms.Label();
            this.SpellCasterSpell = new System.Windows.Forms.ComboBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.GroupBox4 = new System.Windows.Forms.GroupBox();
            this.AutoEaterHelp = new System.Windows.Forms.Button();
            this.AutoEaterEatFromFloorFirst = new System.Windows.Forms.CheckBox();
            this.Label20 = new System.Windows.Forms.Label();
            this.AutoEaterInterval = new System.Windows.Forms.NumericUpDown();
            this.Label18 = new System.Windows.Forms.Label();
            this.AutoEaterEatFromFloor = new System.Windows.Forms.CheckBox();
            this.AutoEaterMinimumHitPoints = new System.Windows.Forms.NumericUpDown();
            this.Label6 = new System.Windows.Forms.Label();
            this.AutoEaterTrigger = new System.Windows.Forms.CheckBox();
            this.AutoEaterSmart = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ExpCheckerBox = new System.Windows.Forms.GroupBox();
            this.LevelScreenshot = new System.Windows.Forms.CheckBox();
            this.ExpCheckerHelp = new System.Windows.Forms.Button();
            this.ShowLagBar = new System.Windows.Forms.CheckBox();
            this.ExpChecker = new System.Windows.Forms.CheckBox();
            this.MainFormTimer = new System.Windows.Forms.Timer(this.components);
            this.ShowAlarmsButtom = new System.Windows.Forms.Button();
            this.ShowRuneMakerButtom = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AutoLooterBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AutoLooterMinCap)).BeginInit();
            this.GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpellCasterMinimumManaPoints)).BeginInit();
            this.GroupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AutoEaterInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AutoEaterMinimumHitPoints)).BeginInit();
            this.ExpCheckerBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AutoLooterBox
            // 
            this.AutoLooterBox.Controls.Add(this.AutoLooterHelp);
            this.AutoLooterBox.Controls.Add(this.AutoLooterEatFromCorpse);
            this.AutoLooterBox.Controls.Add(this.AutoLooterlbl);
            this.AutoLooterBox.Controls.Add(this.AutoLooterMinCap);
            this.AutoLooterBox.Controls.Add(this.AutoLooterConfigure);
            this.AutoLooterBox.Controls.Add(this.AutoLooterTrigger);
            this.AutoLooterBox.Location = new System.Drawing.Point(12, 178);
            this.AutoLooterBox.Name = "AutoLooterBox";
            this.AutoLooterBox.Size = new System.Drawing.Size(206, 95);
            this.AutoLooterBox.TabIndex = 8;
            this.AutoLooterBox.TabStop = false;
            this.AutoLooterBox.Text = "Auto Looter";
            this.AutoLooterBox.Enter += new System.EventHandler(this.AutoLooterBox_Enter);
            // 
            // AutoLooterHelp
            // 
            this.AutoLooterHelp.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AutoLooterHelp.Location = new System.Drawing.Point(172, 63);
            this.AutoLooterHelp.Name = "AutoLooterHelp";
            this.AutoLooterHelp.Size = new System.Drawing.Size(26, 24);
            this.AutoLooterHelp.TabIndex = 8;
            this.AutoLooterHelp.Text = "?";
            this.AutoLooterHelp.UseVisualStyleBackColor = true;
            // 
            // AutoLooterEatFromCorpse
            // 
            this.AutoLooterEatFromCorpse.AutoSize = true;
            this.AutoLooterEatFromCorpse.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AutoLooterEatFromCorpse.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AutoLooterEatFromCorpse.Location = new System.Drawing.Point(6, 40);
            this.AutoLooterEatFromCorpse.Name = "AutoLooterEatFromCorpse";
            this.AutoLooterEatFromCorpse.Size = new System.Drawing.Size(104, 17);
            this.AutoLooterEatFromCorpse.TabIndex = 6;
            this.AutoLooterEatFromCorpse.Text = "Eat From Corpse";
            this.AutoLooterEatFromCorpse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AutoLooterEatFromCorpse.UseVisualStyleBackColor = true;
            // 
            // AutoLooterlbl
            // 
            this.AutoLooterlbl.AutoSize = true;
            this.AutoLooterlbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AutoLooterlbl.Location = new System.Drawing.Point(6, 16);
            this.AutoLooterlbl.Name = "AutoLooterlbl";
            this.AutoLooterlbl.Size = new System.Drawing.Size(95, 13);
            this.AutoLooterlbl.TabIndex = 3;
            this.AutoLooterlbl.Text = "Minimum Capacity:";
            // 
            // AutoLooterMinCap
            // 
            this.AutoLooterMinCap.Location = new System.Drawing.Point(107, 14);
            this.AutoLooterMinCap.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.AutoLooterMinCap.Name = "AutoLooterMinCap";
            this.AutoLooterMinCap.Size = new System.Drawing.Size(91, 20);
            this.AutoLooterMinCap.TabIndex = 2;
            this.AutoLooterMinCap.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.AutoLooterMinCap.ThousandsSeparator = true;
            // 
            // AutoLooterConfigure
            // 
            this.AutoLooterConfigure.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AutoLooterConfigure.Location = new System.Drawing.Point(86, 63);
            this.AutoLooterConfigure.Name = "AutoLooterConfigure";
            this.AutoLooterConfigure.Size = new System.Drawing.Size(74, 24);
            this.AutoLooterConfigure.TabIndex = 1;
            this.AutoLooterConfigure.Text = "Configure";
            this.AutoLooterConfigure.UseVisualStyleBackColor = true;
            // 
            // AutoLooterTrigger
            // 
            this.AutoLooterTrigger.Appearance = System.Windows.Forms.Appearance.Button;
            this.AutoLooterTrigger.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AutoLooterTrigger.Location = new System.Drawing.Point(6, 63);
            this.AutoLooterTrigger.Name = "AutoLooterTrigger";
            this.AutoLooterTrigger.Size = new System.Drawing.Size(74, 24);
            this.AutoLooterTrigger.TabIndex = 0;
            this.AutoLooterTrigger.Text = "Activate";
            this.AutoLooterTrigger.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AutoLooterTrigger.UseVisualStyleBackColor = true;
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.SpellCasterHelp);
            this.GroupBox2.Controls.Add(this.SpellCasterTrigger);
            this.GroupBox2.Controls.Add(this.SpellCasterMinimumManaPoints);
            this.GroupBox2.Controls.Add(this.Label3);
            this.GroupBox2.Controls.Add(this.SpellCasterSpell);
            this.GroupBox2.Controls.Add(this.Label1);
            this.GroupBox2.Location = new System.Drawing.Point(12, 278);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(206, 105);
            this.GroupBox2.TabIndex = 9;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Spell Caster";
            this.GroupBox2.Enter += new System.EventHandler(this.GroupBox2_Enter);
            // 
            // SpellCasterHelp
            // 
            this.SpellCasterHelp.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SpellCasterHelp.Location = new System.Drawing.Point(172, 75);
            this.SpellCasterHelp.Name = "SpellCasterHelp";
            this.SpellCasterHelp.Size = new System.Drawing.Size(26, 24);
            this.SpellCasterHelp.TabIndex = 7;
            this.SpellCasterHelp.Text = "?";
            this.SpellCasterHelp.UseVisualStyleBackColor = true;
            // 
            // SpellCasterTrigger
            // 
            this.SpellCasterTrigger.Appearance = System.Windows.Forms.Appearance.Button;
            this.SpellCasterTrigger.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SpellCasterTrigger.Location = new System.Drawing.Point(59, 76);
            this.SpellCasterTrigger.Name = "SpellCasterTrigger";
            this.SpellCasterTrigger.Size = new System.Drawing.Size(74, 24);
            this.SpellCasterTrigger.TabIndex = 6;
            this.SpellCasterTrigger.Text = "Activate";
            this.SpellCasterTrigger.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SpellCasterTrigger.UseVisualStyleBackColor = true;
            // 
            // SpellCasterMinimumManaPoints
            // 
            this.SpellCasterMinimumManaPoints.Location = new System.Drawing.Point(123, 50);
            this.SpellCasterMinimumManaPoints.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.SpellCasterMinimumManaPoints.Name = "SpellCasterMinimumManaPoints";
            this.SpellCasterMinimumManaPoints.Size = new System.Drawing.Size(75, 20);
            this.SpellCasterMinimumManaPoints.TabIndex = 5;
            this.SpellCasterMinimumManaPoints.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.SpellCasterMinimumManaPoints.ThousandsSeparator = true;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label3.Location = new System.Drawing.Point(6, 52);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(111, 13);
            this.Label3.TabIndex = 4;
            this.Label3.Text = "Mininum Mana Points:";
            // 
            // SpellCasterSpell
            // 
            this.SpellCasterSpell.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.SpellCasterSpell.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.SpellCasterSpell.FormattingEnabled = true;
            this.SpellCasterSpell.Location = new System.Drawing.Point(45, 18);
            this.SpellCasterSpell.Name = "SpellCasterSpell";
            this.SpellCasterSpell.Size = new System.Drawing.Size(153, 21);
            this.SpellCasterSpell.TabIndex = 1;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label1.Location = new System.Drawing.Point(6, 21);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(33, 13);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Spell:";
            // 
            // GroupBox4
            // 
            this.GroupBox4.Controls.Add(this.AutoEaterHelp);
            this.GroupBox4.Controls.Add(this.AutoEaterEatFromFloorFirst);
            this.GroupBox4.Controls.Add(this.Label20);
            this.GroupBox4.Controls.Add(this.AutoEaterInterval);
            this.GroupBox4.Controls.Add(this.Label18);
            this.GroupBox4.Controls.Add(this.AutoEaterEatFromFloor);
            this.GroupBox4.Controls.Add(this.AutoEaterMinimumHitPoints);
            this.GroupBox4.Controls.Add(this.Label6);
            this.GroupBox4.Controls.Add(this.AutoEaterTrigger);
            this.GroupBox4.Controls.Add(this.AutoEaterSmart);
            this.GroupBox4.Location = new System.Drawing.Point(226, 181);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new System.Drawing.Size(191, 167);
            this.GroupBox4.TabIndex = 11;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Text = "Auto Eater";
            this.GroupBox4.Enter += new System.EventHandler(this.GroupBox4_Enter);
            // 
            // AutoEaterHelp
            // 
            this.AutoEaterHelp.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AutoEaterHelp.Location = new System.Drawing.Point(152, 135);
            this.AutoEaterHelp.Name = "AutoEaterHelp";
            this.AutoEaterHelp.Size = new System.Drawing.Size(26, 24);
            this.AutoEaterHelp.TabIndex = 15;
            this.AutoEaterHelp.Text = "?";
            this.AutoEaterHelp.UseVisualStyleBackColor = true;
            // 
            // AutoEaterEatFromFloorFirst
            // 
            this.AutoEaterEatFromFloorFirst.AutoSize = true;
            this.AutoEaterEatFromFloorFirst.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AutoEaterEatFromFloorFirst.Location = new System.Drawing.Point(6, 40);
            this.AutoEaterEatFromFloorFirst.Name = "AutoEaterEatFromFloorFirst";
            this.AutoEaterEatFromFloorFirst.Size = new System.Drawing.Size(116, 17);
            this.AutoEaterEatFromFloorFirst.TabIndex = 14;
            this.AutoEaterEatFromFloorFirst.Text = "Eat From Floor First";
            this.AutoEaterEatFromFloorFirst.UseVisualStyleBackColor = true;
            // 
            // Label20
            // 
            this.Label20.AutoSize = true;
            this.Label20.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label20.Location = new System.Drawing.Point(135, 111);
            this.Label20.Name = "Label20";
            this.Label20.Size = new System.Drawing.Size(20, 13);
            this.Label20.TabIndex = 13;
            this.Label20.Text = "ms";
            // 
            // AutoEaterInterval
            // 
            this.AutoEaterInterval.Enabled = false;
            this.AutoEaterInterval.Location = new System.Drawing.Point(63, 109);
            this.AutoEaterInterval.Maximum = new decimal(new int[] {
            999000,
            0,
            0,
            0});
            this.AutoEaterInterval.Name = "AutoEaterInterval";
            this.AutoEaterInterval.Size = new System.Drawing.Size(66, 20);
            this.AutoEaterInterval.TabIndex = 12;
            this.AutoEaterInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.AutoEaterInterval.ThousandsSeparator = true;
            // 
            // Label18
            // 
            this.Label18.AutoSize = true;
            this.Label18.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label18.Location = new System.Drawing.Point(6, 111);
            this.Label18.Name = "Label18";
            this.Label18.Size = new System.Drawing.Size(45, 13);
            this.Label18.TabIndex = 11;
            this.Label18.Text = "Interval:";
            // 
            // AutoEaterEatFromFloor
            // 
            this.AutoEaterEatFromFloor.AutoSize = true;
            this.AutoEaterEatFromFloor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AutoEaterEatFromFloor.Location = new System.Drawing.Point(6, 17);
            this.AutoEaterEatFromFloor.Name = "AutoEaterEatFromFloor";
            this.AutoEaterEatFromFloor.Size = new System.Drawing.Size(94, 17);
            this.AutoEaterEatFromFloor.TabIndex = 10;
            this.AutoEaterEatFromFloor.Text = "Eat From Floor";
            this.AutoEaterEatFromFloor.UseVisualStyleBackColor = true;
            // 
            // AutoEaterMinimumHitPoints
            // 
            this.AutoEaterMinimumHitPoints.Enabled = false;
            this.AutoEaterMinimumHitPoints.Location = new System.Drawing.Point(90, 81);
            this.AutoEaterMinimumHitPoints.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.AutoEaterMinimumHitPoints.Name = "AutoEaterMinimumHitPoints";
            this.AutoEaterMinimumHitPoints.Size = new System.Drawing.Size(88, 20);
            this.AutoEaterMinimumHitPoints.TabIndex = 9;
            this.AutoEaterMinimumHitPoints.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.AutoEaterMinimumHitPoints.ThousandsSeparator = true;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label6.Location = new System.Drawing.Point(6, 83);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(78, 13);
            this.Label6.TabIndex = 8;
            this.Label6.Text = "Min. Hit Points:";
            // 
            // AutoEaterTrigger
            // 
            this.AutoEaterTrigger.Appearance = System.Windows.Forms.Appearance.Button;
            this.AutoEaterTrigger.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AutoEaterTrigger.Location = new System.Drawing.Point(9, 135);
            this.AutoEaterTrigger.Name = "AutoEaterTrigger";
            this.AutoEaterTrigger.Size = new System.Drawing.Size(74, 24);
            this.AutoEaterTrigger.TabIndex = 7;
            this.AutoEaterTrigger.Text = "Activate";
            this.AutoEaterTrigger.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AutoEaterTrigger.UseVisualStyleBackColor = true;
            // 
            // AutoEaterSmart
            // 
            this.AutoEaterSmart.AutoSize = true;
            this.AutoEaterSmart.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AutoEaterSmart.Location = new System.Drawing.Point(6, 63);
            this.AutoEaterSmart.Name = "AutoEaterSmart";
            this.AutoEaterSmart.Size = new System.Drawing.Size(72, 17);
            this.AutoEaterSmart.TabIndex = 0;
            this.AutoEaterSmart.Text = "Eat Smart";
            this.AutoEaterSmart.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(342, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ExpCheckerBox
            // 
            this.ExpCheckerBox.Controls.Add(this.LevelScreenshot);
            this.ExpCheckerBox.Controls.Add(this.ExpCheckerHelp);
            this.ExpCheckerBox.Controls.Add(this.ShowLagBar);
            this.ExpCheckerBox.Controls.Add(this.ExpChecker);
            this.ExpCheckerBox.Location = new System.Drawing.Point(12, 12);
            this.ExpCheckerBox.Name = "ExpCheckerBox";
            this.ExpCheckerBox.Size = new System.Drawing.Size(403, 74);
            this.ExpCheckerBox.TabIndex = 12;
            this.ExpCheckerBox.TabStop = false;
            this.ExpCheckerBox.Text = "Addons";
            this.ExpCheckerBox.Enter += new System.EventHandler(this.ExpCheckerBox_Enter);
            // 
            // LevelScreenshot
            // 
            this.LevelScreenshot.AutoSize = true;
            this.LevelScreenshot.Location = new System.Drawing.Point(204, 19);
            this.LevelScreenshot.Name = "LevelScreenshot";
            this.LevelScreenshot.Size = new System.Drawing.Size(109, 17);
            this.LevelScreenshot.TabIndex = 11;
            this.LevelScreenshot.Text = "Level Screenshot";
            this.LevelScreenshot.UseVisualStyleBackColor = true;
            this.LevelScreenshot.CheckedChanged += new System.EventHandler(this.LevelScreenshot_CheckedChanged);
            // 
            // ExpCheckerHelp
            // 
            this.ExpCheckerHelp.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ExpCheckerHelp.Location = new System.Drawing.Point(366, 41);
            this.ExpCheckerHelp.Name = "ExpCheckerHelp";
            this.ExpCheckerHelp.Size = new System.Drawing.Size(26, 24);
            this.ExpCheckerHelp.TabIndex = 10;
            this.ExpCheckerHelp.Text = "?";
            this.ExpCheckerHelp.UseVisualStyleBackColor = true;
            this.ExpCheckerHelp.Click += new System.EventHandler(this.ExpCheckerHelp_Click);
            // 
            // ShowLagBar
            // 
            this.ShowLagBar.AutoSize = true;
            this.ShowLagBar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ShowLagBar.Location = new System.Drawing.Point(134, 19);
            this.ShowLagBar.Name = "ShowLagBar";
            this.ShowLagBar.Size = new System.Drawing.Size(63, 17);
            this.ShowLagBar.TabIndex = 1;
            this.ShowLagBar.Text = "Lag Bar";
            this.ShowLagBar.UseVisualStyleBackColor = true;
            this.ShowLagBar.CheckedChanged += new System.EventHandler(this.ShowLagBar_CheckedChanged);
            // 
            // ExpChecker
            // 
            this.ExpChecker.AutoSize = true;
            this.ExpChecker.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ExpChecker.Location = new System.Drawing.Point(6, 19);
            this.ExpChecker.Name = "ExpChecker";
            this.ExpChecker.Size = new System.Drawing.Size(122, 17);
            this.ExpChecker.TabIndex = 0;
            this.ExpChecker.Text = "Experience Checker";
            this.ExpChecker.UseVisualStyleBackColor = true;
            this.ExpChecker.CheckedChanged += new System.EventHandler(this.ExpChecker_CheckedChanged);
            // 
            // MainFormTimer
            // 
            this.MainFormTimer.Enabled = true;
            this.MainFormTimer.Interval = 1000;
            this.MainFormTimer.Tick += new System.EventHandler(this.MainFormTimer_Tick);
            // 
            // ShowAlarmsButtom
            // 
            this.ShowAlarmsButtom.Location = new System.Drawing.Point(9, 19);
            this.ShowAlarmsButtom.Name = "ShowAlarmsButtom";
            this.ShowAlarmsButtom.Size = new System.Drawing.Size(75, 23);
            this.ShowAlarmsButtom.TabIndex = 12;
            this.ShowAlarmsButtom.Text = "Alarms";
            this.ShowAlarmsButtom.UseVisualStyleBackColor = true;
            this.ShowAlarmsButtom.Click += new System.EventHandler(this.ShowAlarmsButtom_Click);
            // 
            // ShowRuneMakerButtom
            // 
            this.ShowRuneMakerButtom.Location = new System.Drawing.Point(90, 19);
            this.ShowRuneMakerButtom.Name = "ShowRuneMakerButtom";
            this.ShowRuneMakerButtom.Size = new System.Drawing.Size(75, 23);
            this.ShowRuneMakerButtom.TabIndex = 13;
            this.ShowRuneMakerButtom.Text = "RuneMaker";
            this.ShowRuneMakerButtom.UseVisualStyleBackColor = true;
            this.ShowRuneMakerButtom.Click += new System.EventHandler(this.ShowRuneMakerButtom_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ShowRuneMakerButtom);
            this.groupBox1.Controls.Add(this.ShowAlarmsButtom);
            this.groupBox1.Location = new System.Drawing.Point(12, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 79);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Helpers";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(429, 395);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ExpCheckerBox);
            this.Controls.Add(this.GroupBox4);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.AutoLooterBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "TibiaTek Bot Reborn";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.AutoLooterBox.ResumeLayout(false);
            this.AutoLooterBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AutoLooterMinCap)).EndInit();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpellCasterMinimumManaPoints)).EndInit();
            this.GroupBox4.ResumeLayout(false);
            this.GroupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AutoEaterInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AutoEaterMinimumHitPoints)).EndInit();
            this.ExpCheckerBox.ResumeLayout(false);
            this.ExpCheckerBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox AutoLooterBox;
        internal System.Windows.Forms.Button AutoLooterHelp;
        internal System.Windows.Forms.CheckBox AutoLooterEatFromCorpse;
        internal System.Windows.Forms.Label AutoLooterlbl;
        internal System.Windows.Forms.NumericUpDown AutoLooterMinCap;
        internal System.Windows.Forms.Button AutoLooterConfigure;
        internal System.Windows.Forms.CheckBox AutoLooterTrigger;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Button SpellCasterHelp;
        internal System.Windows.Forms.CheckBox SpellCasterTrigger;
        internal System.Windows.Forms.NumericUpDown SpellCasterMinimumManaPoints;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.ComboBox SpellCasterSpell;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.GroupBox GroupBox4;
        internal System.Windows.Forms.Button AutoEaterHelp;
        internal System.Windows.Forms.CheckBox AutoEaterEatFromFloorFirst;
        internal System.Windows.Forms.Label Label20;
        internal System.Windows.Forms.NumericUpDown AutoEaterInterval;
        internal System.Windows.Forms.Label Label18;
        internal System.Windows.Forms.CheckBox AutoEaterEatFromFloor;
        internal System.Windows.Forms.NumericUpDown AutoEaterMinimumHitPoints;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.CheckBox AutoEaterTrigger;
        internal System.Windows.Forms.CheckBox AutoEaterSmart;
        private System.Windows.Forms.Button button1;
        internal System.Windows.Forms.GroupBox ExpCheckerBox;
        internal System.Windows.Forms.Button ExpCheckerHelp;
        internal System.Windows.Forms.CheckBox ShowLagBar;
        internal System.Windows.Forms.CheckBox ExpChecker;
        private System.Windows.Forms.CheckBox LevelScreenshot;
        private System.Windows.Forms.Timer MainFormTimer;
        private System.Windows.Forms.Button ShowRuneMakerButtom;
        private System.Windows.Forms.Button ShowAlarmsButtom;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

