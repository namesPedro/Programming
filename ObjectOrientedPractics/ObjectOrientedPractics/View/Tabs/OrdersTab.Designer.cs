namespace ObjectOrientedPractics.View.Tabs
{
    partial class OrdersTab
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderStatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerFullNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.ordersLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.priorityPanel = new System.Windows.Forms.Panel();
            this.priorityOptionsLabel = new System.Windows.Forms.Label();
            this.deliveryTimeComboBox = new System.Windows.Forms.ComboBox();
            this.deliveryDatePicker = new System.Windows.Forms.DateTimePicker();
            this.deliveryTimeLabel = new System.Windows.Forms.Label();
            this.deliveryDateLabel = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.amountTextLabel = new System.Windows.Forms.Label();
            this.orderItemsListBox = new System.Windows.Forms.ListBox();
            this.orderItemsLabel = new System.Windows.Forms.Label();
            this.addressControl1 = new ObjectOrientedPractics.View.Controls.AddressControl();
            this.statusLabel = new System.Windows.Forms.Label();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.createdLabel = new System.Windows.Forms.Label();
            this.createdTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.selectedOrderLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.priorityPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(479, 989);
            this.panel1.TabIndex = 9;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dataGridView1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 16);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(479, 973);
            this.panel6.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.createdColumn,
            this.orderStatusColumn,
            this.customerFullNameColumn});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(479, 973);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // idColumn
            // 
            this.idColumn.HeaderText = "Id";
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            // 
            // createdColumn
            // 
            this.createdColumn.HeaderText = "Created";
            this.createdColumn.Name = "createdColumn";
            this.createdColumn.ReadOnly = true;
            // 
            // orderStatusColumn
            // 
            this.orderStatusColumn.HeaderText = "Order Status";
            this.orderStatusColumn.Name = "orderStatusColumn";
            this.orderStatusColumn.ReadOnly = true;
            // 
            // customerFullNameColumn
            // 
            this.customerFullNameColumn.HeaderText = "Customer Full Name";
            this.customerFullNameColumn.Name = "customerFullNameColumn";
            this.customerFullNameColumn.ReadOnly = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.ordersLabel);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(479, 16);
            this.panel5.TabIndex = 2;
            // 
            // ordersLabel
            // 
            this.ordersLabel.AutoSize = true;
            this.ordersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ordersLabel.Location = new System.Drawing.Point(3, 0);
            this.ordersLabel.Name = "ordersLabel";
            this.ordersLabel.Size = new System.Drawing.Size(44, 13);
            this.ordersLabel.TabIndex = 0;
            this.ordersLabel.Text = "Orders";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.priorityPanel);
            this.panel2.Controls.Add(this.amountLabel);
            this.panel2.Controls.Add(this.amountTextLabel);
            this.panel2.Controls.Add(this.orderItemsListBox);
            this.panel2.Controls.Add(this.orderItemsLabel);
            this.panel2.Controls.Add(this.addressControl1);
            this.panel2.Controls.Add(this.statusLabel);
            this.panel2.Controls.Add(this.statusComboBox);
            this.panel2.Controls.Add(this.createdLabel);
            this.panel2.Controls.Add(this.createdTextBox);
            this.panel2.Controls.Add(this.idTextBox);
            this.panel2.Controls.Add(this.idLabel);
            this.panel2.Controls.Add(this.selectedOrderLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1376, 989);
            this.panel2.TabIndex = 8;
            // 
            // priorityPanel
            // 
            this.priorityPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.priorityPanel.Controls.Add(this.priorityOptionsLabel);
            this.priorityPanel.Controls.Add(this.deliveryTimeComboBox);
            this.priorityPanel.Controls.Add(this.deliveryDatePicker);
            this.priorityPanel.Controls.Add(this.deliveryTimeLabel);
            this.priorityPanel.Controls.Add(this.deliveryDateLabel);
            this.priorityPanel.Location = new System.Drawing.Point(1134, 0);
            this.priorityPanel.Name = "priorityPanel";
            this.priorityPanel.Size = new System.Drawing.Size(214, 75);
            this.priorityPanel.TabIndex = 17;
            this.priorityPanel.Visible = false;
            // 
            // priorityOptionsLabel
            // 
            this.priorityOptionsLabel.AutoSize = true;
            this.priorityOptionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priorityOptionsLabel.Location = new System.Drawing.Point(-3, 0);
            this.priorityOptionsLabel.Name = "priorityOptionsLabel";
            this.priorityOptionsLabel.Size = new System.Drawing.Size(93, 13);
            this.priorityOptionsLabel.TabIndex = 12;
            this.priorityOptionsLabel.Text = "Priority Options";
            // 
            // deliveryTimeComboBox
            // 
            this.deliveryTimeComboBox.FormattingEnabled = true;
            this.deliveryTimeComboBox.Location = new System.Drawing.Point(77, 47);
            this.deliveryTimeComboBox.Name = "deliveryTimeComboBox";
            this.deliveryTimeComboBox.Size = new System.Drawing.Size(131, 21);
            this.deliveryTimeComboBox.TabIndex = 16;
            this.deliveryTimeComboBox.SelectedIndexChanged += new System.EventHandler(this.DeliveryTimeComboBox_SelectedIndexChanged);
            // 
            // deliveryDatePicker
            // 
            this.deliveryDatePicker.Location = new System.Drawing.Point(77, 22);
            this.deliveryDatePicker.Name = "deliveryDatePicker";
            this.deliveryDatePicker.Size = new System.Drawing.Size(131, 20);
            this.deliveryDatePicker.TabIndex = 14;
            this.deliveryDatePicker.ValueChanged += new System.EventHandler(this.DeliveryDatePicker_ValueChanged);
            // 
            // deliveryTimeLabel
            // 
            this.deliveryTimeLabel.AutoSize = true;
            this.deliveryTimeLabel.Location = new System.Drawing.Point(-3, 51);
            this.deliveryTimeLabel.Name = "deliveryTimeLabel";
            this.deliveryTimeLabel.Size = new System.Drawing.Size(74, 13);
            this.deliveryTimeLabel.TabIndex = 15;
            this.deliveryTimeLabel.Text = "Delivery Time:";
            // 
            // deliveryDateLabel
            // 
            this.deliveryDateLabel.AutoSize = true;
            this.deliveryDateLabel.Location = new System.Drawing.Point(-3, 25);
            this.deliveryDateLabel.Name = "deliveryDateLabel";
            this.deliveryDateLabel.Size = new System.Drawing.Size(74, 13);
            this.deliveryDateLabel.TabIndex = 13;
            this.deliveryDateLabel.Text = "Delivery Date:";
            // 
            // amountLabel
            // 
            this.amountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.amountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.amountLabel.Location = new System.Drawing.Point(939, 354);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(421, 31);
            this.amountLabel.TabIndex = 11;
            this.amountLabel.Text = "0,00";
            this.amountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // amountTextLabel
            // 
            this.amountTextLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.amountTextLabel.AutoSize = true;
            this.amountTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.amountTextLabel.Location = new System.Drawing.Point(1307, 341);
            this.amountTextLabel.Name = "amountTextLabel";
            this.amountTextLabel.Size = new System.Drawing.Size(53, 13);
            this.amountTextLabel.TabIndex = 10;
            this.amountTextLabel.Text = "Amount:";
            // 
            // orderItemsListBox
            // 
            this.orderItemsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.orderItemsListBox.FormattingEnabled = true;
            this.orderItemsListBox.Location = new System.Drawing.Point(930, 243);
            this.orderItemsListBox.Name = "orderItemsListBox";
            this.orderItemsListBox.Size = new System.Drawing.Size(430, 95);
            this.orderItemsListBox.TabIndex = 9;
            // 
            // orderItemsLabel
            // 
            this.orderItemsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.orderItemsLabel.AutoSize = true;
            this.orderItemsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderItemsLabel.Location = new System.Drawing.Point(927, 227);
            this.orderItemsLabel.Name = "orderItemsLabel";
            this.orderItemsLabel.Size = new System.Drawing.Size(72, 13);
            this.orderItemsLabel.TabIndex = 8;
            this.orderItemsLabel.Text = "Order Items";
            // 
            // addressControl1
            // 
            this.addressControl1.Address = null;
            this.addressControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addressControl1.Location = new System.Drawing.Point(930, 101);
            this.addressControl1.Name = "addressControl1";
            this.addressControl1.Size = new System.Drawing.Size(430, 123);
            this.addressControl1.TabIndex = 7;
            // 
            // statusLabel
            // 
            this.statusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(927, 77);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(40, 13);
            this.statusLabel.TabIndex = 6;
            this.statusLabel.Text = "Status:";
            // 
            // statusComboBox
            // 
            this.statusComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Location = new System.Drawing.Point(980, 74);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(128, 21);
            this.statusComboBox.TabIndex = 5;
            this.statusComboBox.SelectedIndexChanged += new System.EventHandler(this.statusComboBox_SelectedIndexChanged);
            // 
            // createdLabel
            // 
            this.createdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.createdLabel.AutoSize = true;
            this.createdLabel.Location = new System.Drawing.Point(927, 51);
            this.createdLabel.Name = "createdLabel";
            this.createdLabel.Size = new System.Drawing.Size(47, 13);
            this.createdLabel.TabIndex = 4;
            this.createdLabel.Text = "Created:";
            // 
            // createdTextBox
            // 
            this.createdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.createdTextBox.Location = new System.Drawing.Point(980, 48);
            this.createdTextBox.Name = "createdTextBox";
            this.createdTextBox.Size = new System.Drawing.Size(128, 20);
            this.createdTextBox.TabIndex = 3;
            // 
            // idTextBox
            // 
            this.idTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.idTextBox.Location = new System.Drawing.Point(980, 22);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(128, 20);
            this.idTextBox.TabIndex = 2;
            // 
            // idLabel
            // 
            this.idLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(927, 25);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(21, 13);
            this.idLabel.TabIndex = 1;
            this.idLabel.Text = "ID:";
            // 
            // selectedOrderLabel
            // 
            this.selectedOrderLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectedOrderLabel.AutoSize = true;
            this.selectedOrderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectedOrderLabel.Location = new System.Drawing.Point(927, 0);
            this.selectedOrderLabel.Name = "selectedOrderLabel";
            this.selectedOrderLabel.Size = new System.Drawing.Size(92, 13);
            this.selectedOrderLabel.TabIndex = 0;
            this.selectedOrderLabel.Text = "Selected Order";
            // 
            // OrdersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "OrdersTab";
            this.Size = new System.Drawing.Size(1376, 989);
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.priorityPanel.ResumeLayout(false);
            this.priorityPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label ordersLabel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label selectedOrderLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderStatusColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerFullNameColumn;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label createdLabel;
        private System.Windows.Forms.TextBox createdTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.ComboBox statusComboBox;
        private Controls.AddressControl addressControl1;
        private System.Windows.Forms.Label amountTextLabel;
        private System.Windows.Forms.ListBox orderItemsListBox;
        private System.Windows.Forms.Label orderItemsLabel;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Label priorityOptionsLabel;
        private System.Windows.Forms.ComboBox deliveryTimeComboBox;
        private System.Windows.Forms.Label deliveryTimeLabel;
        private System.Windows.Forms.DateTimePicker deliveryDatePicker;
        private System.Windows.Forms.Label deliveryDateLabel;
        private System.Windows.Forms.Panel priorityPanel;
    }
}
