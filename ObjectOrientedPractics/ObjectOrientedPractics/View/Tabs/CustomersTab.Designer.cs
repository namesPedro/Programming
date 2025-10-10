namespace ObjectOrientedPractics.View.Tabs
{
    partial class CustomersTab
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.selectedCustomerLabel = new System.Windows.Forms.Label();
            this.selectedCustomerIdLabel = new System.Windows.Forms.Label();
            this.selectedCustomerAddressTextBox = new System.Windows.Forms.TextBox();
            this.selectedCustomerAddressLabel = new System.Windows.Forms.Label();
            this.selectedCustomerFullNameTextBox = new System.Windows.Forms.TextBox();
            this.selectedCustomerFullNameLabel = new System.Windows.Forms.Label();
            this.selectedCustomerIdTextBox = new System.Windows.Forms.TextBox();
            this.customersRemoveButton = new System.Windows.Forms.Button();
            this.customersLabel = new System.Windows.Forms.Label();
            this.customersAddButton = new System.Windows.Forms.Button();
            this.customersListBox = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(382, 414);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1168, 594);
            this.panel3.TabIndex = 18;
            // 
            // selectedCustomerLabel
            // 
            this.selectedCustomerLabel.AutoSize = true;
            this.selectedCustomerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectedCustomerLabel.Location = new System.Drawing.Point(3, 0);
            this.selectedCustomerLabel.Name = "selectedCustomerLabel";
            this.selectedCustomerLabel.Size = new System.Drawing.Size(109, 13);
            this.selectedCustomerLabel.TabIndex = 4;
            this.selectedCustomerLabel.Text = "SelectedCustomer";
            // 
            // selectedCustomerIdLabel
            // 
            this.selectedCustomerIdLabel.AutoSize = true;
            this.selectedCustomerIdLabel.Location = new System.Drawing.Point(3, 25);
            this.selectedCustomerIdLabel.Name = "selectedCustomerIdLabel";
            this.selectedCustomerIdLabel.Size = new System.Drawing.Size(21, 13);
            this.selectedCustomerIdLabel.TabIndex = 5;
            this.selectedCustomerIdLabel.Text = "ID:";
            // 
            // selectedCustomerAddressTextBox
            // 
            this.selectedCustomerAddressTextBox.Location = new System.Drawing.Point(64, 74);
            this.selectedCustomerAddressTextBox.Multiline = true;
            this.selectedCustomerAddressTextBox.Name = "selectedCustomerAddressTextBox";
            this.selectedCustomerAddressTextBox.Size = new System.Drawing.Size(711, 115);
            this.selectedCustomerAddressTextBox.TabIndex = 12;
            this.selectedCustomerAddressTextBox.TextChanged += new System.EventHandler(this.selectedCustomerAddressTextBox_TextChanged);
            // 
            // selectedCustomerAddressLabel
            // 
            this.selectedCustomerAddressLabel.AutoSize = true;
            this.selectedCustomerAddressLabel.Location = new System.Drawing.Point(3, 77);
            this.selectedCustomerAddressLabel.Name = "selectedCustomerAddressLabel";
            this.selectedCustomerAddressLabel.Size = new System.Drawing.Size(48, 13);
            this.selectedCustomerAddressLabel.TabIndex = 11;
            this.selectedCustomerAddressLabel.Text = "Address:";
            // 
            // selectedCustomerFullNameTextBox
            // 
            this.selectedCustomerFullNameTextBox.Location = new System.Drawing.Point(64, 48);
            this.selectedCustomerFullNameTextBox.Name = "selectedCustomerFullNameTextBox";
            this.selectedCustomerFullNameTextBox.Size = new System.Drawing.Size(711, 20);
            this.selectedCustomerFullNameTextBox.TabIndex = 10;
            this.selectedCustomerFullNameTextBox.TextChanged += new System.EventHandler(this.selectedCustomerFullNameTextBox_TextChanged);
            // 
            // selectedCustomerFullNameLabel
            // 
            this.selectedCustomerFullNameLabel.AutoSize = true;
            this.selectedCustomerFullNameLabel.Location = new System.Drawing.Point(3, 51);
            this.selectedCustomerFullNameLabel.Name = "selectedCustomerFullNameLabel";
            this.selectedCustomerFullNameLabel.Size = new System.Drawing.Size(57, 13);
            this.selectedCustomerFullNameLabel.TabIndex = 9;
            this.selectedCustomerFullNameLabel.Text = "Full Name:";
            // 
            // selectedCustomerIdTextBox
            // 
            this.selectedCustomerIdTextBox.Location = new System.Drawing.Point(64, 22);
            this.selectedCustomerIdTextBox.Name = "selectedCustomerIdTextBox";
            this.selectedCustomerIdTextBox.ReadOnly = true;
            this.selectedCustomerIdTextBox.Size = new System.Drawing.Size(161, 20);
            this.selectedCustomerIdTextBox.TabIndex = 7;
            // 
            // customersRemoveButton
            // 
            this.customersRemoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.customersRemoveButton.Location = new System.Drawing.Point(194, 926);
            this.customersRemoveButton.Name = "customersRemoveButton";
            this.customersRemoveButton.Size = new System.Drawing.Size(182, 48);
            this.customersRemoveButton.TabIndex = 3;
            this.customersRemoveButton.Text = "Remove";
            this.customersRemoveButton.UseVisualStyleBackColor = true;
            this.customersRemoveButton.Click += new System.EventHandler(this.customersRemoveButton_Click);
            // 
            // customersLabel
            // 
            this.customersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customersLabel.Location = new System.Drawing.Point(3, 0);
            this.customersLabel.Name = "customersLabel";
            this.customersLabel.Size = new System.Drawing.Size(158, 13);
            this.customersLabel.TabIndex = 0;
            this.customersLabel.Text = "Customers";
            // 
            // customersAddButton
            // 
            this.customersAddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.customersAddButton.Location = new System.Drawing.Point(6, 926);
            this.customersAddButton.Name = "customersAddButton";
            this.customersAddButton.Size = new System.Drawing.Size(182, 48);
            this.customersAddButton.TabIndex = 2;
            this.customersAddButton.Text = "Add";
            this.customersAddButton.UseVisualStyleBackColor = true;
            this.customersAddButton.Click += new System.EventHandler(this.customersAddButton_Click);
            // 
            // customersListBox
            // 
            this.customersListBox.FormattingEnabled = true;
            this.customersListBox.Location = new System.Drawing.Point(6, 16);
            this.customersListBox.Name = "customersListBox";
            this.customersListBox.Size = new System.Drawing.Size(370, 849);
            this.customersListBox.TabIndex = 1;
            this.customersListBox.SelectedIndexChanged += new System.EventHandler(this.customersListBox_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.selectedCustomerLabel);
            this.panel2.Controls.Add(this.selectedCustomerIdLabel);
            this.panel2.Controls.Add(this.selectedCustomerAddressTextBox);
            this.panel2.Controls.Add(this.selectedCustomerAddressLabel);
            this.panel2.Controls.Add(this.selectedCustomerFullNameTextBox);
            this.panel2.Controls.Add(this.selectedCustomerFullNameLabel);
            this.panel2.Controls.Add(this.selectedCustomerIdTextBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(382, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1168, 408);
            this.panel2.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.customersRemoveButton);
            this.panel1.Controls.Add(this.customersLabel);
            this.panel1.Controls.Add(this.customersAddButton);
            this.panel1.Controls.Add(this.customersListBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(382, 1008);
            this.panel1.TabIndex = 16;
            // 
            // CustomersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CustomersTab";
            this.Size = new System.Drawing.Size(1550, 1008);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label selectedCustomerLabel;
        private System.Windows.Forms.Label selectedCustomerIdLabel;
        private System.Windows.Forms.TextBox selectedCustomerAddressTextBox;
        private System.Windows.Forms.Label selectedCustomerAddressLabel;
        private System.Windows.Forms.TextBox selectedCustomerFullNameTextBox;
        private System.Windows.Forms.Label selectedCustomerFullNameLabel;
        private System.Windows.Forms.TextBox selectedCustomerIdTextBox;
        private System.Windows.Forms.Button customersRemoveButton;
        private System.Windows.Forms.Label customersLabel;
        private System.Windows.Forms.Button customersAddButton;
        private System.Windows.Forms.ListBox customersListBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}
