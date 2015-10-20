namespace TibiaTekBot
{
    partial class fmrEditLoot
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
            this.EditLootHelp = new System.Windows.Forms.Button();
            this.LooterEditButton = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.LootCategoryItems = new System.Windows.Forms.DataGridView();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LootTo = new System.Windows.Forms.ComboBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.LootCategories = new System.Windows.Forms.ComboBox();
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.OK_Button = new System.Windows.Forms.Button();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LootCategoryItems)).BeginInit();
            this.TableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EditLootHelp
            // 
            this.EditLootHelp.Location = new System.Drawing.Point(325, 214);
            this.EditLootHelp.Name = "EditLootHelp";
            this.EditLootHelp.Size = new System.Drawing.Size(26, 24);
            this.EditLootHelp.TabIndex = 7;
            this.EditLootHelp.Text = "?";
            this.EditLootHelp.UseVisualStyleBackColor = true;
            // 
            // LooterEditButton
            // 
            this.LooterEditButton.Location = new System.Drawing.Point(14, 214);
            this.LooterEditButton.Name = "LooterEditButton";
            this.LooterEditButton.Size = new System.Drawing.Size(97, 24);
            this.LooterEditButton.TabIndex = 6;
            this.LooterEditButton.Text = "Edit Loot Items";
            this.LooterEditButton.UseVisualStyleBackColor = true;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.LootCategoryItems);
            this.GroupBox1.Controls.Add(this.LootTo);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Controls.Add(this.LootCategories);
            this.GroupBox1.Location = new System.Drawing.Point(14, 6);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(342, 202);
            this.GroupBox1.TabIndex = 5;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Loot Items to Backpacks";
            // 
            // LootCategoryItems
            // 
            this.LootCategoryItems.AllowUserToAddRows = false;
            this.LootCategoryItems.AllowUserToDeleteRows = false;
            this.LootCategoryItems.AllowUserToResizeRows = false;
            this.LootCategoryItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LootCategoryItems.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.LootCategoryItems.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LootCategoryItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LootCategoryItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemName,
            this.ID});
            this.LootCategoryItems.Location = new System.Drawing.Point(6, 46);
            this.LootCategoryItems.Name = "LootCategoryItems";
            this.LootCategoryItems.ReadOnly = true;
            this.LootCategoryItems.RowHeadersVisible = false;
            this.LootCategoryItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.LootCategoryItems.Size = new System.Drawing.Size(203, 150);
            this.LootCategoryItems.TabIndex = 4;
            // 
            // ItemName
            // 
            this.ItemName.HeaderText = "ItemName";
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.HeaderText = "ItemID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // LootTo
            // 
            this.LootTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LootTo.FormattingEnabled = true;
            this.LootTo.Items.AddRange(new object[] {
            "Ground",
            "Backpack [1]",
            "Backpack [2]",
            "Backpack [3]",
            "Backpack [4]",
            "Backpack [5]",
            "Backpack [6]",
            "Backpack [7]",
            "Backpack [8]",
            "Backpack [9]",
            "Backpack [10]"});
            this.LootTo.Location = new System.Drawing.Point(218, 62);
            this.LootTo.Name = "LootTo";
            this.LootTo.Size = new System.Drawing.Size(119, 21);
            this.LootTo.TabIndex = 3;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(215, 46);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(66, 13);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "Loot Item to:";
            // 
            // LootCategories
            // 
            this.LootCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LootCategories.FormattingEnabled = true;
            this.LootCategories.Items.AddRange(new object[] {
            "Loot Category #1",
            "Loot Category #2",
            "Loot Category #3",
            "Loot Category #4",
            "Loot Category #5",
            "Loot Category #6",
            "Loot Category #7",
            "Loot Category #8",
            "Loot Category #9",
            "Loot Category #10",
            "Loot Category #11",
            "Loot Category #12"});
            this.LootCategories.Location = new System.Drawing.Point(6, 19);
            this.LootCategories.Name = "LootCategories";
            this.LootCategories.Size = new System.Drawing.Size(126, 21);
            this.LootCategories.TabIndex = 0;
            // 
            // TableLayoutPanel1
            // 
            this.TableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TableLayoutPanel1.ColumnCount = 2;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.Controls.Add(this.Cancel_Button, 1, 0);
            this.TableLayoutPanel1.Controls.Add(this.OK_Button, 0, 0);
            this.TableLayoutPanel1.Location = new System.Drawing.Point(177, 210);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 1;
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.Size = new System.Drawing.Size(146, 32);
            this.TableLayoutPanel1.TabIndex = 4;
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_Button.Location = new System.Drawing.Point(76, 4);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(67, 24);
            this.Cancel_Button.TabIndex = 1;
            this.Cancel_Button.Text = "Cancel";
            // 
            // OK_Button
            // 
            this.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OK_Button.Location = new System.Drawing.Point(3, 4);
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.Size = new System.Drawing.Size(67, 24);
            this.OK_Button.TabIndex = 0;
            this.OK_Button.Text = "OK";
            // 
            // fmrEditLoot
            // 
            this.AcceptButton = this.OK_Button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel_Button;
            this.ClientSize = new System.Drawing.Size(371, 248);
            this.Controls.Add(this.EditLootHelp);
            this.Controls.Add(this.LooterEditButton);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.TableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmrEditLoot";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Looter Items";
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LootCategoryItems)).EndInit();
            this.TableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button EditLootHelp;
        internal System.Windows.Forms.Button LooterEditButton;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.DataGridView LootCategoryItems;
        internal System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        internal System.Windows.Forms.DataGridViewTextBoxColumn ID;
        internal System.Windows.Forms.ComboBox LootTo;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.ComboBox LootCategories;
        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
        internal System.Windows.Forms.Button Cancel_Button;
        internal System.Windows.Forms.Button OK_Button;
    }
}