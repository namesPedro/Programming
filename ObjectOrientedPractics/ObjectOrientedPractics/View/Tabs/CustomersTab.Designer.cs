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
            this.customersRemoveButton = new System.Windows.Forms.Button();
            this.customersAddButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.isPriorityCheckBox = new System.Windows.Forms.CheckBox();
            this.addressControl1 = new ObjectOrientedPractics.View.Controls.AddressControl();
            this.selectedCustomerLabel = new System.Windows.Forms.Label();
            this.selectedCustomerFullNameTextBox = new System.Windows.Forms.TextBox();
            this.selectedCustomerIdLabel = new System.Windows.Forms.Label();
            this.selectedCustomerFullNameLabel = new System.Windows.Forms.Label();
            this.selectedCustomerIdTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.customersLabel = new System.Windows.Forms.Label();
            this.customersListBox = new System.Windows.Forms.ListBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.discountsLabel = new System.Windows.Forms.Label();
            this.discountsListBox = new System.Windows.Forms.ListBox();
            this.addDiscountButton = new System.Windows.Forms.Button();
            this.removeDiscountButton = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // customersRemoveButton
            // 
            this.customersRemoveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customersRemoveButton.Location = new System.Drawing.Point(0, 0);
            this.customersRemoveButton.Name = "customersRemoveButton";
            this.customersRemoveButton.Size = new System.Drawing.Size(190, 50);
            this.customersRemoveButton.TabIndex = 3;
            this.customersRemoveButton.Text = "Remove";
            this.customersRemoveButton.UseVisualStyleBackColor = true;
            this.customersRemoveButton.Click += new System.EventHandler(this.customersRemoveButton_Click);
            // 
            // customersAddButton
            // 
            this.customersAddButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customersAddButton.Location = new System.Drawing.Point(0, 0);
            this.customersAddButton.Name = "customersAddButton";
            this.customersAddButton.Size = new System.Drawing.Size(190, 50);
            this.customersAddButton.TabIndex = 2;
            this.customersAddButton.Text = "Add";
            this.customersAddButton.UseVisualStyleBackColor = true;
            this.customersAddButton.Click += new System.EventHandler(this.customersAddButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(405, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(963, 991);
            this.panel2.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 941);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(963, 50);
            this.panel4.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.removeDiscountButton);
            this.panel3.Controls.Add(this.addDiscountButton);
            this.panel3.Controls.Add(this.discountsListBox);
            this.panel3.Controls.Add(this.discountsLabel);
            this.panel3.Controls.Add(this.isPriorityCheckBox);
            this.panel3.Controls.Add(this.addressControl1);
            this.panel3.Controls.Add(this.selectedCustomerLabel);
            this.panel3.Controls.Add(this.selectedCustomerFullNameTextBox);
            this.panel3.Controls.Add(this.selectedCustomerIdLabel);
            this.panel3.Controls.Add(this.selectedCustomerFullNameLabel);
            this.panel3.Controls.Add(this.selectedCustomerIdTextBox);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(963, 935);
            this.panel3.TabIndex = 0;
            // 
            // isPriorityCheckBox
            // 
            this.isPriorityCheckBox.AutoSize = true;
            this.isPriorityCheckBox.Location = new System.Drawing.Point(479, 74);
            this.isPriorityCheckBox.Name = "isPriorityCheckBox";
            this.isPriorityCheckBox.Size = new System.Drawing.Size(68, 17);
            this.isPriorityCheckBox.TabIndex = 12;
            this.isPriorityCheckBox.Text = "Is Priority";
            this.isPriorityCheckBox.UseVisualStyleBackColor = true;
            this.isPriorityCheckBox.CheckedChanged += new System.EventHandler(this.isPriorityCheckBox_CheckedChanged);
            // 
            // addressControl1
            // 
            this.addressControl1.Address = null;
            this.addressControl1.Location = new System.Drawing.Point(421, 97);
            this.addressControl1.Name = "addressControl1";
            this.addressControl1.Size = new System.Drawing.Size(379, 123);
            this.addressControl1.TabIndex = 11;
            // 
            // selectedCustomerLabel
            // 
            this.selectedCustomerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectedCustomerLabel.AutoSize = true;
            this.selectedCustomerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectedCustomerLabel.Location = new System.Drawing.Point(418, 0);
            this.selectedCustomerLabel.Name = "selectedCustomerLabel";
            this.selectedCustomerLabel.Size = new System.Drawing.Size(109, 13);
            this.selectedCustomerLabel.TabIndex = 4;
            this.selectedCustomerLabel.Text = "SelectedCustomer";
            // 
            // selectedCustomerFullNameTextBox
            // 
            this.selectedCustomerFullNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectedCustomerFullNameTextBox.Location = new System.Drawing.Point(479, 48);
            this.selectedCustomerFullNameTextBox.Name = "selectedCustomerFullNameTextBox";
            this.selectedCustomerFullNameTextBox.Size = new System.Drawing.Size(482, 20);
            this.selectedCustomerFullNameTextBox.TabIndex = 10;
            this.selectedCustomerFullNameTextBox.Leave += new System.EventHandler(this.selectedCustomerFullNameTextBox_Leave);
            // 
            // selectedCustomerIdLabel
            // 
            this.selectedCustomerIdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectedCustomerIdLabel.AutoSize = true;
            this.selectedCustomerIdLabel.Location = new System.Drawing.Point(418, 25);
            this.selectedCustomerIdLabel.Name = "selectedCustomerIdLabel";
            this.selectedCustomerIdLabel.Size = new System.Drawing.Size(21, 13);
            this.selectedCustomerIdLabel.TabIndex = 5;
            this.selectedCustomerIdLabel.Text = "ID:";
            // 
            // selectedCustomerFullNameLabel
            // 
            this.selectedCustomerFullNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectedCustomerFullNameLabel.AutoSize = true;
            this.selectedCustomerFullNameLabel.Location = new System.Drawing.Point(418, 51);
            this.selectedCustomerFullNameLabel.Name = "selectedCustomerFullNameLabel";
            this.selectedCustomerFullNameLabel.Size = new System.Drawing.Size(57, 13);
            this.selectedCustomerFullNameLabel.TabIndex = 9;
            this.selectedCustomerFullNameLabel.Text = "Full Name:";
            // 
            // selectedCustomerIdTextBox
            // 
            this.selectedCustomerIdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectedCustomerIdTextBox.Location = new System.Drawing.Point(479, 22);
            this.selectedCustomerIdTextBox.Name = "selectedCustomerIdTextBox";
            this.selectedCustomerIdTextBox.ReadOnly = true;
            this.selectedCustomerIdTextBox.Size = new System.Drawing.Size(161, 20);
            this.selectedCustomerIdTextBox.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(399, 991);
            this.panel1.TabIndex = 5;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.customersLabel);
            this.panel8.Controls.Add(this.customersListBox);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(399, 580);
            this.panel8.TabIndex = 2;
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
            // customersListBox
            // 
            this.customersListBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.customersListBox.FormattingEnabled = true;
            this.customersListBox.Location = new System.Drawing.Point(0, 24);
            this.customersListBox.Name = "customersListBox";
            this.customersListBox.Size = new System.Drawing.Size(399, 550);
            this.customersListBox.TabIndex = 1;
            this.customersListBox.SelectedIndexChanged += new System.EventHandler(this.customersListBox_SelectedIndexChanged);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 941);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(399, 50);
            this.panel5.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.customersRemoveButton);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(209, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(190, 50);
            this.panel7.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.customersAddButton);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(190, 50);
            this.panel6.TabIndex = 0;
            // 
            // discountsLabel
            // 
            this.discountsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.discountsLabel.AutoSize = true;
            this.discountsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.discountsLabel.Location = new System.Drawing.Point(418, 223);
            this.discountsLabel.Name = "discountsLabel";
            this.discountsLabel.Size = new System.Drawing.Size(63, 13);
            this.discountsLabel.TabIndex = 13;
            this.discountsLabel.Text = "Discounts";
            // 
            // discountsListBox
            // 
            this.discountsListBox.FormattingEnabled = true;
            this.discountsListBox.Location = new System.Drawing.Point(421, 239);
            this.discountsListBox.Name = "discountsListBox";
            this.discountsListBox.Size = new System.Drawing.Size(252, 95);
            this.discountsListBox.TabIndex = 14;
            // 
            // addDiscountButton
            // 
            this.addDiscountButton.Location = new System.Drawing.Point(679, 239);
            this.addDiscountButton.Name = "addDiscountButton";
            this.addDiscountButton.Size = new System.Drawing.Size(100, 30);
            this.addDiscountButton.TabIndex = 15;
            this.addDiscountButton.Text = "Add";
            this.addDiscountButton.UseVisualStyleBackColor = true;
            this.addDiscountButton.Click += new System.EventHandler(this.addDiscountButton_Click);
            // 
            // removeDiscountButton
            // 
            this.removeDiscountButton.Location = new System.Drawing.Point(679, 275);
            this.removeDiscountButton.Name = "removeDiscountButton";
            this.removeDiscountButton.Size = new System.Drawing.Size(100, 30);
            this.removeDiscountButton.TabIndex = 16;
            this.removeDiscountButton.Text = "Remove";
            this.removeDiscountButton.UseVisualStyleBackColor = true;
            this.removeDiscountButton.Click += new System.EventHandler(this.removeDiscountButton_Click);
            // 
            // CustomersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.MinimumSize = new System.Drawing.Size(950, 630);
            this.Name = "CustomersTab";
            this.Size = new System.Drawing.Size(1368, 991);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button customersRemoveButton;
        private System.Windows.Forms.Button customersAddButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label selectedCustomerLabel;
        private System.Windows.Forms.TextBox selectedCustomerFullNameTextBox;
        private System.Windows.Forms.Label selectedCustomerIdLabel;
        private System.Windows.Forms.Label selectedCustomerFullNameLabel;
        private System.Windows.Forms.TextBox selectedCustomerIdTextBox;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label customersLabel;
        private System.Windows.Forms.ListBox customersListBox;
        private Controls.AddressControl addressControl1;
        private System.Windows.Forms.CheckBox isPriorityCheckBox;
        private System.Windows.Forms.Button addDiscountButton;
        private System.Windows.Forms.ListBox discountsListBox;
        private System.Windows.Forms.Label discountsLabel;
        private System.Windows.Forms.Button removeDiscountButton;
    }
}
