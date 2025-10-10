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
            this.itemsGroupBox = new System.Windows.Forms.GroupBox();
            this.itemsRemoveButton = new System.Windows.Forms.Button();
            this.itemsAddButton = new System.Windows.Forms.Button();
            this.itemsListBox = new System.Windows.Forms.ListBox();
            this.itemsLabel = new System.Windows.Forms.Label();
            this.selectedItemGroupBox = new System.Windows.Forms.GroupBox();
            this.selectedItemDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.selectedItemDescriptionLabel = new System.Windows.Forms.Label();
            this.selectedItemNameTextBox = new System.Windows.Forms.TextBox();
            this.selectedItemNameLabel = new System.Windows.Forms.Label();
            this.selectedItemCostTextBox = new System.Windows.Forms.TextBox();
            this.selectedItemIdTextBox = new System.Windows.Forms.TextBox();
            this.selectedItemCostLabel = new System.Windows.Forms.Label();
            this.selectedItemIdLabel = new System.Windows.Forms.Label();
            this.selectedItemLabel = new System.Windows.Forms.Label();
            this.itemsGroupBox.SuspendLayout();
            this.selectedItemGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // itemsGroupBox
            // 
            this.itemsGroupBox.Controls.Add(this.itemsRemoveButton);
            this.itemsGroupBox.Controls.Add(this.itemsAddButton);
            this.itemsGroupBox.Controls.Add(this.itemsListBox);
            this.itemsGroupBox.Controls.Add(this.itemsLabel);
            this.itemsGroupBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.itemsGroupBox.Location = new System.Drawing.Point(0, 0);
            this.itemsGroupBox.Name = "itemsGroupBox";
            this.itemsGroupBox.Size = new System.Drawing.Size(385, 953);
            this.itemsGroupBox.TabIndex = 0;
            this.itemsGroupBox.TabStop = false;
            // 
            // itemsRemoveButton
            // 
            this.itemsRemoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.itemsRemoveButton.Location = new System.Drawing.Point(197, 899);
            this.itemsRemoveButton.Name = "itemsRemoveButton";
            this.itemsRemoveButton.Size = new System.Drawing.Size(182, 48);
            this.itemsRemoveButton.TabIndex = 3;
            this.itemsRemoveButton.Text = "Remove";
            this.itemsRemoveButton.UseVisualStyleBackColor = true;
            this.itemsRemoveButton.Click += new System.EventHandler(this.itemsRemoveButton_Click);
            // 
            // itemsAddButton
            // 
            this.itemsAddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.itemsAddButton.Location = new System.Drawing.Point(9, 899);
            this.itemsAddButton.Name = "itemsAddButton";
            this.itemsAddButton.Size = new System.Drawing.Size(182, 48);
            this.itemsAddButton.TabIndex = 2;
            this.itemsAddButton.Text = "Add";
            this.itemsAddButton.UseVisualStyleBackColor = true;
            this.itemsAddButton.Click += new System.EventHandler(this.itemsAddButton_Click);
            // 
            // itemsListBox
            // 
            this.itemsListBox.FormattingEnabled = true;
            this.itemsListBox.Location = new System.Drawing.Point(9, 32);
            this.itemsListBox.Name = "itemsListBox";
            this.itemsListBox.Size = new System.Drawing.Size(370, 849);
            this.itemsListBox.TabIndex = 1;
            // 
            // itemsLabel
            // 
            this.itemsLabel.AutoSize = true;
            this.itemsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.itemsLabel.Location = new System.Drawing.Point(6, 16);
            this.itemsLabel.Name = "itemsLabel";
            this.itemsLabel.Size = new System.Drawing.Size(37, 13);
            this.itemsLabel.TabIndex = 0;
            this.itemsLabel.Text = "Items";
            // 
            // selectedItemGroupBox
            // 
            this.selectedItemGroupBox.Controls.Add(this.selectedItemDescriptionTextBox);
            this.selectedItemGroupBox.Controls.Add(this.selectedItemDescriptionLabel);
            this.selectedItemGroupBox.Controls.Add(this.selectedItemNameTextBox);
            this.selectedItemGroupBox.Controls.Add(this.selectedItemNameLabel);
            this.selectedItemGroupBox.Controls.Add(this.selectedItemCostTextBox);
            this.selectedItemGroupBox.Controls.Add(this.selectedItemIdTextBox);
            this.selectedItemGroupBox.Controls.Add(this.selectedItemCostLabel);
            this.selectedItemGroupBox.Controls.Add(this.selectedItemIdLabel);
            this.selectedItemGroupBox.Controls.Add(this.selectedItemLabel);
            this.selectedItemGroupBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.selectedItemGroupBox.Location = new System.Drawing.Point(397, 0);
            this.selectedItemGroupBox.Name = "selectedItemGroupBox";
            this.selectedItemGroupBox.Size = new System.Drawing.Size(726, 953);
            this.selectedItemGroupBox.TabIndex = 1;
            this.selectedItemGroupBox.TabStop = false;
            // 
            // selectedItemDescriptionTextBox
            // 
            this.selectedItemDescriptionTextBox.Location = new System.Drawing.Point(9, 261);
            this.selectedItemDescriptionTextBox.Multiline = true;
            this.selectedItemDescriptionTextBox.Name = "selectedItemDescriptionTextBox";
            this.selectedItemDescriptionTextBox.Size = new System.Drawing.Size(711, 115);
            this.selectedItemDescriptionTextBox.TabIndex = 12;
            // 
            // selectedItemDescriptionLabel
            // 
            this.selectedItemDescriptionLabel.AutoSize = true;
            this.selectedItemDescriptionLabel.Location = new System.Drawing.Point(6, 245);
            this.selectedItemDescriptionLabel.Name = "selectedItemDescriptionLabel";
            this.selectedItemDescriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.selectedItemDescriptionLabel.TabIndex = 11;
            this.selectedItemDescriptionLabel.Text = "Description";
            // 
            // selectedItemNameTextBox
            // 
            this.selectedItemNameTextBox.Location = new System.Drawing.Point(9, 117);
            this.selectedItemNameTextBox.Multiline = true;
            this.selectedItemNameTextBox.Name = "selectedItemNameTextBox";
            this.selectedItemNameTextBox.Size = new System.Drawing.Size(711, 115);
            this.selectedItemNameTextBox.TabIndex = 10;
            // 
            // selectedItemNameLabel
            // 
            this.selectedItemNameLabel.AutoSize = true;
            this.selectedItemNameLabel.Location = new System.Drawing.Point(6, 101);
            this.selectedItemNameLabel.Name = "selectedItemNameLabel";
            this.selectedItemNameLabel.Size = new System.Drawing.Size(38, 13);
            this.selectedItemNameLabel.TabIndex = 9;
            this.selectedItemNameLabel.Text = "Name:";
            // 
            // selectedItemCostTextBox
            // 
            this.selectedItemCostTextBox.Location = new System.Drawing.Point(48, 65);
            this.selectedItemCostTextBox.Name = "selectedItemCostTextBox";
            this.selectedItemCostTextBox.Size = new System.Drawing.Size(161, 20);
            this.selectedItemCostTextBox.TabIndex = 8;
            // 
            // selectedItemIdTextBox
            // 
            this.selectedItemIdTextBox.Location = new System.Drawing.Point(48, 39);
            this.selectedItemIdTextBox.Name = "selectedItemIdTextBox";
            this.selectedItemIdTextBox.Size = new System.Drawing.Size(161, 20);
            this.selectedItemIdTextBox.TabIndex = 7;
            // 
            // selectedItemCostLabel
            // 
            this.selectedItemCostLabel.AutoSize = true;
            this.selectedItemCostLabel.Location = new System.Drawing.Point(6, 72);
            this.selectedItemCostLabel.Name = "selectedItemCostLabel";
            this.selectedItemCostLabel.Size = new System.Drawing.Size(31, 13);
            this.selectedItemCostLabel.TabIndex = 6;
            this.selectedItemCostLabel.Text = "Cost:";
            // 
            // selectedItemIdLabel
            // 
            this.selectedItemIdLabel.AutoSize = true;
            this.selectedItemIdLabel.Location = new System.Drawing.Point(6, 46);
            this.selectedItemIdLabel.Name = "selectedItemIdLabel";
            this.selectedItemIdLabel.Size = new System.Drawing.Size(21, 13);
            this.selectedItemIdLabel.TabIndex = 5;
            this.selectedItemIdLabel.Text = "ID:";
            // 
            // selectedItemLabel
            // 
            this.selectedItemLabel.AutoSize = true;
            this.selectedItemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectedItemLabel.Location = new System.Drawing.Point(6, 16);
            this.selectedItemLabel.Name = "selectedItemLabel";
            this.selectedItemLabel.Size = new System.Drawing.Size(81, 13);
            this.selectedItemLabel.TabIndex = 4;
            this.selectedItemLabel.Text = "SelectedItem";
            // 
            // ItemsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.selectedItemGroupBox);
            this.Controls.Add(this.itemsGroupBox);
            this.Name = "ItemsTab";
            this.Size = new System.Drawing.Size(1123, 953);
            this.itemsGroupBox.ResumeLayout(false);
            this.itemsGroupBox.PerformLayout();
            this.selectedItemGroupBox.ResumeLayout(false);
            this.selectedItemGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox itemsGroupBox;
        private System.Windows.Forms.Button itemsRemoveButton;
        private System.Windows.Forms.Button itemsAddButton;
        private System.Windows.Forms.ListBox itemsListBox;
        private System.Windows.Forms.Label itemsLabel;
        private System.Windows.Forms.GroupBox selectedItemGroupBox;
        private System.Windows.Forms.Label selectedItemNameLabel;
        private System.Windows.Forms.TextBox selectedItemCostTextBox;
        private System.Windows.Forms.TextBox selectedItemIdTextBox;
        private System.Windows.Forms.Label selectedItemCostLabel;
        private System.Windows.Forms.Label selectedItemIdLabel;
        private System.Windows.Forms.Label selectedItemLabel;
        private System.Windows.Forms.TextBox selectedItemNameTextBox;
        private System.Windows.Forms.Label selectedItemDescriptionLabel;
        private System.Windows.Forms.TextBox selectedItemDescriptionTextBox;
    }
}
