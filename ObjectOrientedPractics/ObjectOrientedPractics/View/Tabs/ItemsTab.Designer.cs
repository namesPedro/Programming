namespace ObjectOrientedPractics.View.Tabs
{
    partial class ItemsTab
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.selectedItemDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.selectedItemDescriptionLabel = new System.Windows.Forms.Label();
            this.selectedItemNameTextBox = new System.Windows.Forms.TextBox();
            this.selectedItemNameLabel = new System.Windows.Forms.Label();
            this.selectedItemCostTextBox = new System.Windows.Forms.TextBox();
            this.selectedItemIdTextBox = new System.Windows.Forms.TextBox();
            this.selectedItemCostLabel = new System.Windows.Forms.Label();
            this.selectedItemIdLabel = new System.Windows.Forms.Label();
            this.selectedItemLabel = new System.Windows.Forms.Label();
            this.itemsLabel = new System.Windows.Forms.Label();
            this.itemsListBox = new System.Windows.Forms.ListBox();
            this.itemsAddButton = new System.Windows.Forms.Button();
            this.itemsRemoveButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.selectedItemCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.selectedItemCategoryLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectedItemDescriptionTextBox
            // 
            this.selectedItemDescriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectedItemDescriptionTextBox.Location = new System.Drawing.Point(12, 282);
            this.selectedItemDescriptionTextBox.Multiline = true;
            this.selectedItemDescriptionTextBox.Name = "selectedItemDescriptionTextBox";
            this.selectedItemDescriptionTextBox.Size = new System.Drawing.Size(482, 115);
            this.selectedItemDescriptionTextBox.TabIndex = 12;
            this.selectedItemDescriptionTextBox.Leave += new System.EventHandler(this.selectedItemDescriptionTextBox_Leave);
            // 
            // selectedItemDescriptionLabel
            // 
            this.selectedItemDescriptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectedItemDescriptionLabel.AutoSize = true;
            this.selectedItemDescriptionLabel.Location = new System.Drawing.Point(9, 266);
            this.selectedItemDescriptionLabel.Name = "selectedItemDescriptionLabel";
            this.selectedItemDescriptionLabel.Size = new System.Drawing.Size(63, 13);
            this.selectedItemDescriptionLabel.TabIndex = 11;
            this.selectedItemDescriptionLabel.Text = "Description:";
            // 
            // selectedItemNameTextBox
            // 
            this.selectedItemNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectedItemNameTextBox.Location = new System.Drawing.Point(12, 131);
            this.selectedItemNameTextBox.Multiline = true;
            this.selectedItemNameTextBox.Name = "selectedItemNameTextBox";
            this.selectedItemNameTextBox.Size = new System.Drawing.Size(482, 115);
            this.selectedItemNameTextBox.TabIndex = 10;
            this.selectedItemNameTextBox.Text = " ";
            this.selectedItemNameTextBox.Leave += new System.EventHandler(this.selectedItemNameTextBox_Leave);
            // 
            // selectedItemNameLabel
            // 
            this.selectedItemNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectedItemNameLabel.AutoSize = true;
            this.selectedItemNameLabel.Location = new System.Drawing.Point(9, 115);
            this.selectedItemNameLabel.Name = "selectedItemNameLabel";
            this.selectedItemNameLabel.Size = new System.Drawing.Size(38, 13);
            this.selectedItemNameLabel.TabIndex = 9;
            this.selectedItemNameLabel.Text = "Name:";
            // 
            // selectedItemCostTextBox
            // 
            this.selectedItemCostTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectedItemCostTextBox.Location = new System.Drawing.Point(67, 48);
            this.selectedItemCostTextBox.Name = "selectedItemCostTextBox";
            this.selectedItemCostTextBox.Size = new System.Drawing.Size(161, 20);
            this.selectedItemCostTextBox.TabIndex = 8;
            this.selectedItemCostTextBox.TextChanged += new System.EventHandler(this.selectedItemCostTextBox_Leave);
            // 
            // selectedItemIdTextBox
            // 
            this.selectedItemIdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectedItemIdTextBox.Location = new System.Drawing.Point(67, 22);
            this.selectedItemIdTextBox.Name = "selectedItemIdTextBox";
            this.selectedItemIdTextBox.ReadOnly = true;
            this.selectedItemIdTextBox.Size = new System.Drawing.Size(161, 20);
            this.selectedItemIdTextBox.TabIndex = 7;
            // 
            // selectedItemCostLabel
            // 
            this.selectedItemCostLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectedItemCostLabel.AutoSize = true;
            this.selectedItemCostLabel.Location = new System.Drawing.Point(9, 51);
            this.selectedItemCostLabel.Name = "selectedItemCostLabel";
            this.selectedItemCostLabel.Size = new System.Drawing.Size(31, 13);
            this.selectedItemCostLabel.TabIndex = 6;
            this.selectedItemCostLabel.Text = "Cost:";
            // 
            // selectedItemIdLabel
            // 
            this.selectedItemIdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectedItemIdLabel.AutoSize = true;
            this.selectedItemIdLabel.Location = new System.Drawing.Point(9, 25);
            this.selectedItemIdLabel.Name = "selectedItemIdLabel";
            this.selectedItemIdLabel.Size = new System.Drawing.Size(21, 13);
            this.selectedItemIdLabel.TabIndex = 5;
            this.selectedItemIdLabel.Text = "ID:";
            // 
            // selectedItemLabel
            // 
            this.selectedItemLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectedItemLabel.AutoSize = true;
            this.selectedItemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectedItemLabel.Location = new System.Drawing.Point(9, 0);
            this.selectedItemLabel.Name = "selectedItemLabel";
            this.selectedItemLabel.Size = new System.Drawing.Size(81, 13);
            this.selectedItemLabel.TabIndex = 4;
            this.selectedItemLabel.Text = "SelectedItem";
            // 
            // itemsLabel
            // 
            this.itemsLabel.AutoSize = true;
            this.itemsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.itemsLabel.Location = new System.Drawing.Point(3, 0);
            this.itemsLabel.Name = "itemsLabel";
            this.itemsLabel.Size = new System.Drawing.Size(37, 13);
            this.itemsLabel.TabIndex = 0;
            this.itemsLabel.Text = "Items";
            // 
            // itemsListBox
            // 
            this.itemsListBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.itemsListBox.FormattingEnabled = true;
            this.itemsListBox.Location = new System.Drawing.Point(0, 30);
            this.itemsListBox.Name = "itemsListBox";
            this.itemsListBox.Size = new System.Drawing.Size(399, 550);
            this.itemsListBox.TabIndex = 1;
            this.itemsListBox.SelectedIndexChanged += new System.EventHandler(this.itemsListBox_SelectedIndexChanged);
            // 
            // itemsAddButton
            // 
            this.itemsAddButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemsAddButton.Location = new System.Drawing.Point(0, 0);
            this.itemsAddButton.Name = "itemsAddButton";
            this.itemsAddButton.Size = new System.Drawing.Size(190, 50);
            this.itemsAddButton.TabIndex = 2;
            this.itemsAddButton.Text = "Add";
            this.itemsAddButton.UseVisualStyleBackColor = true;
            this.itemsAddButton.Click += new System.EventHandler(this.itemsAddButton_Click);
            // 
            // itemsRemoveButton
            // 
            this.itemsRemoveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemsRemoveButton.Location = new System.Drawing.Point(0, 0);
            this.itemsRemoveButton.Name = "itemsRemoveButton";
            this.itemsRemoveButton.Size = new System.Drawing.Size(190, 50);
            this.itemsRemoveButton.TabIndex = 3;
            this.itemsRemoveButton.Text = "Remove";
            this.itemsRemoveButton.UseVisualStyleBackColor = true;
            this.itemsRemoveButton.Click += new System.EventHandler(this.itemsRemoveButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(399, 900);
            this.panel1.TabIndex = 13;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 850);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(399, 50);
            this.panel6.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.itemsRemoveButton);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(209, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(190, 50);
            this.panel8.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.itemsAddButton);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(190, 50);
            this.panel7.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.itemsLabel);
            this.panel5.Controls.Add(this.itemsListBox);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(399, 580);
            this.panel5.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(534, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(497, 900);
            this.panel2.TabIndex = 14;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 850);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(497, 50);
            this.panel4.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.selectedItemCategoryLabel);
            this.panel3.Controls.Add(this.selectedItemCategoryComboBox);
            this.panel3.Controls.Add(this.selectedItemDescriptionTextBox);
            this.panel3.Controls.Add(this.selectedItemLabel);
            this.panel3.Controls.Add(this.selectedItemCostTextBox);
            this.panel3.Controls.Add(this.selectedItemIdLabel);
            this.panel3.Controls.Add(this.selectedItemNameLabel);
            this.panel3.Controls.Add(this.selectedItemIdTextBox);
            this.panel3.Controls.Add(this.selectedItemCostLabel);
            this.panel3.Controls.Add(this.selectedItemNameTextBox);
            this.panel3.Controls.Add(this.selectedItemDescriptionLabel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(497, 469);
            this.panel3.TabIndex = 0;
            // 
            // selectedItemCategoryComboBox
            // 
            this.selectedItemCategoryComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectedItemCategoryComboBox.FormattingEnabled = true;
            this.selectedItemCategoryComboBox.Location = new System.Drawing.Point(67, 79);
            this.selectedItemCategoryComboBox.Name = "selectedItemCategoryComboBox";
            this.selectedItemCategoryComboBox.Size = new System.Drawing.Size(161, 21);
            this.selectedItemCategoryComboBox.TabIndex = 13;
            this.selectedItemCategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.selectedItemCategoryComboBox_SelectedIndexChanged);
            // 
            // selectedItemCategoryLabel
            // 
            this.selectedItemCategoryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectedItemCategoryLabel.AutoSize = true;
            this.selectedItemCategoryLabel.Location = new System.Drawing.Point(9, 82);
            this.selectedItemCategoryLabel.Name = "selectedItemCategoryLabel";
            this.selectedItemCategoryLabel.Size = new System.Drawing.Size(52, 13);
            this.selectedItemCategoryLabel.TabIndex = 14;
            this.selectedItemCategoryLabel.Text = "Category:";
            // 
            // ItemsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(900, 630);
            this.Name = "ItemsTab";
            this.Size = new System.Drawing.Size(1031, 900);
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label selectedItemNameLabel;
        private System.Windows.Forms.TextBox selectedItemCostTextBox;
        private System.Windows.Forms.TextBox selectedItemIdTextBox;
        private System.Windows.Forms.Label selectedItemCostLabel;
        private System.Windows.Forms.Label selectedItemIdLabel;
        private System.Windows.Forms.Label selectedItemLabel;
        private System.Windows.Forms.TextBox selectedItemNameTextBox;
        private System.Windows.Forms.Label selectedItemDescriptionLabel;
        private System.Windows.Forms.TextBox selectedItemDescriptionTextBox;
        private System.Windows.Forms.Label itemsLabel;
        private System.Windows.Forms.ListBox itemsListBox;
        private System.Windows.Forms.Button itemsAddButton;
        private System.Windows.Forms.Button itemsRemoveButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label selectedItemCategoryLabel;
        private System.Windows.Forms.ComboBox selectedItemCategoryComboBox;
    }
}
