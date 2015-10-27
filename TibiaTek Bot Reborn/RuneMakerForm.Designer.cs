namespace TibiaTekBot
{
    partial class RuneMakerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RuneMakerForm));
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.BlankRunesAvailable = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.ManaLabel = new System.Windows.Forms.Label();
            this.RunOnMaxMana = new System.Windows.Forms.CheckBox();
            this.RunemakerHelp = new System.Windows.Forms.Button();
            this.RunemakerTrigger = new System.Windows.Forms.CheckBox();
            this.RunemakerMinimumSoulPoints = new System.Windows.Forms.NumericUpDown();
            this.Label5 = new System.Windows.Forms.Label();
            this.RunemakerMinimumManaPoints = new System.Windows.Forms.NumericUpDown();
            this.Label4 = new System.Windows.Forms.Label();
            this.RunemakerSpell = new System.Windows.Forms.ComboBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.RuneMakerTimer = new System.Windows.Forms.Timer(this.components);
            this.HideWindows = new System.Windows.Forms.Button();
            this.GroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BlankRunesAvailable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RunemakerMinimumSoulPoints)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RunemakerMinimumManaPoints)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.BlankRunesAvailable);
            this.GroupBox3.Controls.Add(this.label1);
            this.GroupBox3.Controls.Add(this.ManaLabel);
            this.GroupBox3.Controls.Add(this.RunOnMaxMana);
            this.GroupBox3.Controls.Add(this.RunemakerHelp);
            this.GroupBox3.Controls.Add(this.RunemakerTrigger);
            this.GroupBox3.Controls.Add(this.RunemakerMinimumSoulPoints);
            this.GroupBox3.Controls.Add(this.Label5);
            this.GroupBox3.Controls.Add(this.RunemakerMinimumManaPoints);
            this.GroupBox3.Controls.Add(this.Label4);
            this.GroupBox3.Controls.Add(this.RunemakerSpell);
            this.GroupBox3.Controls.Add(this.Label2);
            this.GroupBox3.Location = new System.Drawing.Point(3, 5);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(191, 234);
            this.GroupBox3.TabIndex = 11;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Runemaker";
            // 
            // BlankRunesAvailable
            // 
            this.BlankRunesAvailable.Location = new System.Drawing.Point(123, 135);
            this.BlankRunesAvailable.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.BlankRunesAvailable.Name = "BlankRunesAvailable";
            this.BlankRunesAvailable.Size = new System.Drawing.Size(55, 20);
            this.BlankRunesAvailable.TabIndex = 15;
            this.BlankRunesAvailable.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BlankRunesAvailable.ThousandsSeparator = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(6, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Blank Runes Available:";
            // 
            // ManaLabel
            // 
            this.ManaLabel.AutoSize = true;
            this.ManaLabel.Location = new System.Drawing.Point(6, 20);
            this.ManaLabel.Name = "ManaLabel";
            this.ManaLabel.Size = new System.Drawing.Size(57, 13);
            this.ManaLabel.TabIndex = 13;
            this.ManaLabel.Text = "Mana: 0/0";
            // 
            // RunOnMaxMana
            // 
            this.RunOnMaxMana.AutoSize = true;
            this.RunOnMaxMana.Location = new System.Drawing.Point(9, 167);
            this.RunOnMaxMana.Name = "RunOnMaxMana";
            this.RunOnMaxMana.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RunOnMaxMana.Size = new System.Drawing.Size(170, 17);
            this.RunOnMaxMana.TabIndex = 12;
            this.RunOnMaxMana.Text = "                  Run On Max Mana";
            this.RunOnMaxMana.UseVisualStyleBackColor = true;
            // 
            // RunemakerHelp
            // 
            this.RunemakerHelp.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.RunemakerHelp.Location = new System.Drawing.Point(152, 202);
            this.RunemakerHelp.Name = "RunemakerHelp";
            this.RunemakerHelp.Size = new System.Drawing.Size(26, 24);
            this.RunemakerHelp.TabIndex = 11;
            this.RunemakerHelp.Text = "?";
            this.RunemakerHelp.UseVisualStyleBackColor = true;
            // 
            // RunemakerTrigger
            // 
            this.RunemakerTrigger.Appearance = System.Windows.Forms.Appearance.Button;
            this.RunemakerTrigger.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.RunemakerTrigger.Location = new System.Drawing.Point(9, 202);
            this.RunemakerTrigger.Name = "RunemakerTrigger";
            this.RunemakerTrigger.Size = new System.Drawing.Size(74, 24);
            this.RunemakerTrigger.TabIndex = 10;
            this.RunemakerTrigger.Text = "Activate";
            this.RunemakerTrigger.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RunemakerTrigger.UseVisualStyleBackColor = true;
            this.RunemakerTrigger.CheckedChanged += new System.EventHandler(this.RunemakerTrigger_CheckedChanged);
            // 
            // RunemakerMinimumSoulPoints
            // 
            this.RunemakerMinimumSoulPoints.Location = new System.Drawing.Point(123, 104);
            this.RunemakerMinimumSoulPoints.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.RunemakerMinimumSoulPoints.Name = "RunemakerMinimumSoulPoints";
            this.RunemakerMinimumSoulPoints.Size = new System.Drawing.Size(55, 20);
            this.RunemakerMinimumSoulPoints.TabIndex = 9;
            this.RunemakerMinimumSoulPoints.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.RunemakerMinimumSoulPoints.ThousandsSeparator = true;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label5.Location = new System.Drawing.Point(6, 106);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(105, 13);
            this.Label5.TabIndex = 8;
            this.Label5.Text = "Mininum Soul Points:";
            // 
            // RunemakerMinimumManaPoints
            // 
            this.RunemakerMinimumManaPoints.Enabled = false;
            this.RunemakerMinimumManaPoints.Location = new System.Drawing.Point(123, 74);
            this.RunemakerMinimumManaPoints.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.RunemakerMinimumManaPoints.Name = "RunemakerMinimumManaPoints";
            this.RunemakerMinimumManaPoints.Size = new System.Drawing.Size(55, 20);
            this.RunemakerMinimumManaPoints.TabIndex = 7;
            this.RunemakerMinimumManaPoints.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.RunemakerMinimumManaPoints.ThousandsSeparator = true;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label4.Location = new System.Drawing.Point(6, 76);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(111, 13);
            this.Label4.TabIndex = 6;
            this.Label4.Text = "Mininum Mana Points:";
            // 
            // RunemakerSpell
            // 
            this.RunemakerSpell.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.RunemakerSpell.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.RunemakerSpell.FormattingEnabled = true;
            this.RunemakerSpell.Location = new System.Drawing.Point(45, 42);
            this.RunemakerSpell.Name = "RunemakerSpell";
            this.RunemakerSpell.Size = new System.Drawing.Size(133, 21);
            this.RunemakerSpell.TabIndex = 2;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label2.Location = new System.Drawing.Point(6, 45);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(33, 13);
            this.Label2.TabIndex = 0;
            this.Label2.Text = "Spell:";
            // 
            // RuneMakerTimer
            // 
            this.RuneMakerTimer.Interval = 1000;
            this.RuneMakerTimer.Tick += new System.EventHandler(this.RuneMakerTimer_Tick);
            // 
            // HideWindows
            // 
            this.HideWindows.Location = new System.Drawing.Point(313, 259);
            this.HideWindows.Name = "HideWindows";
            this.HideWindows.Size = new System.Drawing.Size(75, 23);
            this.HideWindows.TabIndex = 12;
            this.HideWindows.Text = "Hide";
            this.HideWindows.UseVisualStyleBackColor = true;
            this.HideWindows.Click += new System.EventHandler(this.HideWindows_Click);
            // 
            // RuneMakerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 288);
            this.Controls.Add(this.HideWindows);
            this.Controls.Add(this.GroupBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RuneMakerForm";
            this.Text = "Rune Maker Form";
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BlankRunesAvailable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RunemakerMinimumSoulPoints)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RunemakerMinimumManaPoints)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.Button RunemakerHelp;
        internal System.Windows.Forms.CheckBox RunemakerTrigger;
        internal System.Windows.Forms.NumericUpDown RunemakerMinimumSoulPoints;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.NumericUpDown RunemakerMinimumManaPoints;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label ManaLabel;
        private System.Windows.Forms.CheckBox RunOnMaxMana;
        private System.Windows.Forms.Timer RuneMakerTimer;
        internal System.Windows.Forms.NumericUpDown BlankRunesAvailable;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button HideWindows;
        private System.Windows.Forms.ComboBox RunemakerSpell;
    }
}