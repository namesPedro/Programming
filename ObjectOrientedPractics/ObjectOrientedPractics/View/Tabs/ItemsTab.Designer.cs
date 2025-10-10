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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectedItemDescriptionTextBox
            // 
            this.selectedItemDescriptionTextBox.Location = new System.Drawing.Point(6, 255);
            this.selectedItemDescriptionTextBox.Multiline = true;
            this.selectedItemDescriptionTextBox.Name = "selectedItemDescriptionTextBox";
            this.selectedItemDescriptionTextBox.Size = new System.Drawing.Size(711, 115);
            this.selectedItemDescriptionTextBox.TabIndex = 12;
            this.selectedItemDescriptionTextBox.TextChanged += new System.EventHandler(this.selectedItemDescriptionTextBox_TextChanged);
            // 
            // selectedItemDescriptionLabel
            // 
            this.selectedItemDescriptionLabel.AutoSize = true;
            this.selectedItemDescriptionLabel.Location = new System.Drawing.Point(3, 239);
            this.selectedItemDescriptionLabel.Name = "selectedItemDescriptionLabel";
            this.selectedItemDescriptionLabel.Size = new System.Drawing.Size(63, 13);
            this.selectedItemDescriptionLabel.TabIndex = 11;
            this.selectedItemDescriptionLabel.Text = "Description:";
            // 
            // selectedItemNameTextBox
            // 
            this.selectedItemNameTextBox.Location = new System.Drawing.Point(6, 104);
            this.selectedItemNameTextBox.Multiline = true;
            this.selectedItemNameTextBox.Name = "selectedItemNameTextBox";
            this.selectedItemNameTextBox.Size = new System.Drawing.Size(711, 115);
            this.selectedItemNameTextBox.TabIndex = 10;
            this.selectedItemNameTextBox.TextChanged += new System.EventHandler(this.selectedItemNameTextBox_TextChanged);
            // 
            // selectedItemNameLabel
            // 
            this.selectedItemNameLabel.AutoSize = true;
            this.selectedItemNameLabel.Location = new System.Drawing.Point(3, 88);
            this.selectedItemNameLabel.Name = "selectedItemNameLabel";
            this.selectedItemNameLabel.Size = new System.Drawing.Size(38, 13);
            this.selectedItemNameLabel.TabIndex = 9;
            this.selectedItemNameLabel.Text = "Name:";
            // 
            // selectedItemCostTextBox
            // 
            this.selectedItemCostTextBox.Location = new System.Drawing.Point(40, 48);
            this.selectedItemCostTextBox.Name = "selectedItemCostTextBox";
            this.selectedItemCostTextBox.Size = new System.Drawing.Size(161, 20);
            this.selectedItemCostTextBox.TabIndex = 8;
            this.selectedItemCostTextBox.TextChanged += new System.EventHandler(this.selectedItemCostTextBox_TextChanged);
            // 
            // selectedItemIdTextBox
            // 
            this.selectedItemIdTextBox.Location = new System.Drawing.Point(40, 22);
            this.selectedItemIdTextBox.Name = "selectedItemIdTextBox";
            this.selectedItemIdTextBox.ReadOnly = true;
            this.selectedItemIdTextBox.Size = new System.Drawing.Size(161, 20);
            this.selectedItemIdTextBox.TabIndex = 7;
            // 
            // selectedItemCostLabel
            // 
            this.selectedItemCostLabel.AutoSize = true;
            this.selectedItemCostLabel.Location = new System.Drawing.Point(3, 51);
            this.selectedItemCostLabel.Name = "selectedItemCostLabel";
            this.selectedItemCostLabel.Size = new System.Drawing.Size(31, 13);
            this.selectedItemCostLabel.TabIndex = 6;
            this.selectedItemCostLabel.Text = "Cost:";
            // 
            // selectedItemIdLabel
            // 
            this.selectedItemIdLabel.AutoSize = true;
            this.selectedItemIdLabel.Location = new System.Drawing.Point(3, 25);
            this.selectedItemIdLabel.Name = "selectedItemIdLabel";
            this.selectedItemIdLabel.Size = new System.Drawing.Size(21, 13);
            this.selectedItemIdLabel.TabIndex = 5;
            this.selectedItemIdLabel.Text = "ID:";
            // 
            // selectedItemLabel
            // 
            this.selectedItemLabel.AutoSize = true;
            this.selectedItemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectedItemLabel.Location = new System.Drawing.Point(3, 0);
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
            this.itemsListBox.FormattingEnabled = true;
            this.itemsListBox.Location = new System.Drawing.Point(6, 16);
            this.itemsListBox.Name = "itemsListBox";
            this.itemsListBox.Size = new System.Drawing.Size(370, 849);
            this.itemsListBox.TabIndex = 1;
            this.itemsListBox.SelectedIndexChanged += new System.EventHandler(this.itemsListBox_SelectedIndexChanged);
            // 
            // itemsAddButton
            // 
            this.itemsAddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.itemsAddButton.Location = new System.Drawing.Point(6, 871);
            this.itemsAddButton.Name = "itemsAddButton";
            this.itemsAddButton.Size = new System.Drawing.Size(182, 48);
            this.itemsAddButton.TabIndex = 2;
            this.itemsAddButton.Text = "Add";
            this.itemsAddButton.UseVisualStyleBackColor = true;
            this.itemsAddButton.Click += new System.EventHandler(this.itemsAddButton_Click);
            // 
            // itemsRemoveButton
            // 
            this.itemsRemoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.itemsRemoveButton.Location = new System.Drawing.Point(194, 871);
            this.itemsRemoveButton.Name = "itemsRemoveButton";
            this.itemsRemoveButton.Size = new System.Drawing.Size(182, 48);
            this.itemsRemoveButton.TabIndex = 3;
            this.itemsRemoveButton.Text = "Remove";
            this.itemsRemoveButton.UseVisualStyleBackColor = true;
            this.itemsRemoveButton.Click += new System.EventHandler(this.itemsRemoveButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.itemsRemoveButton);
            this.panel1.Controls.Add(this.itemsLabel);
            this.panel1.Controls.Add(this.itemsAddButton);
            this.panel1.Controls.Add(this.itemsListBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(382, 953);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.selectedItemLabel);
            this.panel2.Controls.Add(this.selectedItemIdLabel);
            this.panel2.Controls.Add(this.selectedItemDescriptionTextBox);
            this.panel2.Controls.Add(this.selectedItemDescriptionLabel);
            this.panel2.Controls.Add(this.selectedItemNameTextBox);
            this.panel2.Controls.Add(this.selectedItemNameLabel);
            this.panel2.Controls.Add(this.selectedItemCostTextBox);
            this.panel2.Controls.Add(this.selectedItemIdTextBox);
            this.panel2.Controls.Add(this.selectedItemCostLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(382, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(741, 408);
            this.panel2.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(382, 414);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(741, 539);
            this.panel3.TabIndex = 15;
            // 
            // ItemsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ItemsTab";
            this.Size = new System.Drawing.Size(1123, 953);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.Panel panel3;
    }
}
