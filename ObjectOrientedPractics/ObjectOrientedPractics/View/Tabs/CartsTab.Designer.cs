namespace ObjectOrientedPractics.View.Tabs
{
    partial class CartsTab
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
            this.panel6 = new System.Windows.Forms.Panel();
            this.itemsAddToCartButton = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.itemsLabel = new System.Windows.Forms.Label();
            this.itemsListBox = new System.Windows.Forms.ListBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.customerLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.discountAmountLabel = new System.Windows.Forms.Label();
            this.discountAmountTextLabel = new System.Windows.Forms.Label();
            this.discountsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.discountsLabel = new System.Windows.Forms.Label();
            this.createOrderButton = new System.Windows.Forms.Button();
            this.removeItemButton = new System.Windows.Forms.Button();
            this.clearCartButton = new System.Windows.Forms.Button();
            this.amountLabel = new System.Windows.Forms.Label();
            this.amountTextLabel = new System.Windows.Forms.Label();
            this.cartListBox = new System.Windows.Forms.ListBox();
            this.cartLabel = new System.Windows.Forms.Label();
            this.customersComboBox = new System.Windows.Forms.ComboBox();
            this.totalLabel = new System.Windows.Forms.Label();
            this.totalTextLabel = new System.Windows.Forms.Label();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.itemsAddToCartButton);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(190, 50);
            this.panel6.TabIndex = 0;
            // 
            // itemsAddToCartButton
            // 
            this.itemsAddToCartButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemsAddToCartButton.Location = new System.Drawing.Point(0, 0);
            this.itemsAddToCartButton.Name = "itemsAddToCartButton";
            this.itemsAddToCartButton.Size = new System.Drawing.Size(190, 50);
            this.itemsAddToCartButton.TabIndex = 2;
            this.itemsAddToCartButton.Text = "Add To Cart";
            this.itemsAddToCartButton.UseVisualStyleBackColor = true;
            this.itemsAddToCartButton.Click += new System.EventHandler(this.addToCartButton_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 936);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(399, 50);
            this.panel5.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(209, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(190, 50);
            this.panel7.TabIndex = 1;
            // 
            // itemsLabel
            // 
            this.itemsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.itemsLabel.Location = new System.Drawing.Point(3, 0);
            this.itemsLabel.Name = "itemsLabel";
            this.itemsLabel.Size = new System.Drawing.Size(158, 13);
            this.itemsLabel.TabIndex = 0;
            this.itemsLabel.Text = "Items";
            // 
            // itemsListBox
            // 
            this.itemsListBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.itemsListBox.FormattingEnabled = true;
            this.itemsListBox.Location = new System.Drawing.Point(0, 24);
            this.itemsListBox.Name = "itemsListBox";
            this.itemsListBox.Size = new System.Drawing.Size(399, 550);
            this.itemsListBox.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.itemsLabel);
            this.panel8.Controls.Add(this.itemsListBox);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(399, 580);
            this.panel8.TabIndex = 2;
            // 
            // customerLabel
            // 
            this.customerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customerLabel.AutoSize = true;
            this.customerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customerLabel.Location = new System.Drawing.Point(504, 24);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(63, 13);
            this.customerLabel.TabIndex = 4;
            this.customerLabel.Text = "Customer:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(399, 986);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.totalLabel);
            this.panel2.Controls.Add(this.totalTextLabel);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(403, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(963, 986);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.discountAmountLabel);
            this.panel3.Controls.Add(this.discountAmountTextLabel);
            this.panel3.Controls.Add(this.discountsCheckedListBox);
            this.panel3.Controls.Add(this.discountsLabel);
            this.panel3.Controls.Add(this.createOrderButton);
            this.panel3.Controls.Add(this.removeItemButton);
            this.panel3.Controls.Add(this.clearCartButton);
            this.panel3.Controls.Add(this.amountLabel);
            this.panel3.Controls.Add(this.amountTextLabel);
            this.panel3.Controls.Add(this.cartListBox);
            this.panel3.Controls.Add(this.cartLabel);
            this.panel3.Controls.Add(this.customersComboBox);
            this.panel3.Controls.Add(this.customerLabel);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(963, 395);
            this.panel3.TabIndex = 0;
            // 
            // discountAmountLabel
            // 
            this.discountAmountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.discountAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.discountAmountLabel.Location = new System.Drawing.Point(715, 294);
            this.discountAmountLabel.Name = "discountAmountLabel";
            this.discountAmountLabel.Size = new System.Drawing.Size(248, 29);
            this.discountAmountLabel.TabIndex = 23;
            this.discountAmountLabel.Text = "0,00";
            this.discountAmountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // discountAmountTextLabel
            // 
            this.discountAmountTextLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.discountAmountTextLabel.AutoSize = true;
            this.discountAmountTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.discountAmountTextLabel.Location = new System.Drawing.Point(854, 278);
            this.discountAmountTextLabel.Name = "discountAmountTextLabel";
            this.discountAmountTextLabel.Size = new System.Drawing.Size(107, 13);
            this.discountAmountTextLabel.TabIndex = 22;
            this.discountAmountTextLabel.Text = "Discount Amount:";
            // 
            // discountsCheckedListBox
            // 
            this.discountsCheckedListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.discountsCheckedListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.discountsCheckedListBox.FormattingEnabled = true;
            this.discountsCheckedListBox.Location = new System.Drawing.Point(507, 294);
            this.discountsCheckedListBox.Name = "discountsCheckedListBox";
            this.discountsCheckedListBox.Size = new System.Drawing.Size(202, 90);
            this.discountsCheckedListBox.TabIndex = 21;
            this.discountsCheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.discountsCheckedListBox_ItemCheck);
            // 
            // discountsLabel
            // 
            this.discountsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.discountsLabel.AutoSize = true;
            this.discountsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.discountsLabel.Location = new System.Drawing.Point(504, 278);
            this.discountsLabel.Name = "discountsLabel";
            this.discountsLabel.Size = new System.Drawing.Size(67, 13);
            this.discountsLabel.TabIndex = 20;
            this.discountsLabel.Text = "Discounts:";
            // 
            // createOrderButton
            // 
            this.createOrderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.createOrderButton.Location = new System.Drawing.Point(507, 220);
            this.createOrderButton.Name = "createOrderButton";
            this.createOrderButton.Size = new System.Drawing.Size(120, 35);
            this.createOrderButton.TabIndex = 19;
            this.createOrderButton.Text = "Create Order";
            this.createOrderButton.UseVisualStyleBackColor = true;
            this.createOrderButton.Click += new System.EventHandler(this.createOrderButton_Click);
            // 
            // removeItemButton
            // 
            this.removeItemButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.removeItemButton.Location = new System.Drawing.Point(715, 220);
            this.removeItemButton.Name = "removeItemButton";
            this.removeItemButton.Size = new System.Drawing.Size(120, 35);
            this.removeItemButton.TabIndex = 18;
            this.removeItemButton.Text = "Remove Item";
            this.removeItemButton.UseVisualStyleBackColor = true;
            this.removeItemButton.Click += new System.EventHandler(this.removeItemButton_Click);
            // 
            // clearCartButton
            // 
            this.clearCartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clearCartButton.Location = new System.Drawing.Point(841, 220);
            this.clearCartButton.Name = "clearCartButton";
            this.clearCartButton.Size = new System.Drawing.Size(120, 35);
            this.clearCartButton.TabIndex = 17;
            this.clearCartButton.Text = "Clear Cart";
            this.clearCartButton.UseVisualStyleBackColor = true;
            this.clearCartButton.Click += new System.EventHandler(this.clearCartButton_Click);
            // 
            // amountLabel
            // 
            this.amountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.amountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.amountLabel.Location = new System.Drawing.Point(641, 188);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(320, 29);
            this.amountLabel.TabIndex = 16;
            this.amountLabel.Text = "0,00";
            this.amountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // amountTextLabel
            // 
            this.amountTextLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.amountTextLabel.AutoSize = true;
            this.amountTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.amountTextLabel.Location = new System.Drawing.Point(908, 175);
            this.amountTextLabel.Name = "amountTextLabel";
            this.amountTextLabel.Size = new System.Drawing.Size(53, 13);
            this.amountTextLabel.TabIndex = 15;
            this.amountTextLabel.Text = "Amount:";
            // 
            // cartListBox
            // 
            this.cartListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cartListBox.FormattingEnabled = true;
            this.cartListBox.Location = new System.Drawing.Point(507, 77);
            this.cartListBox.Name = "cartListBox";
            this.cartListBox.Size = new System.Drawing.Size(454, 95);
            this.cartListBox.TabIndex = 14;
            // 
            // cartLabel
            // 
            this.cartLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cartLabel.AutoSize = true;
            this.cartLabel.Location = new System.Drawing.Point(504, 61);
            this.cartLabel.Name = "cartLabel";
            this.cartLabel.Size = new System.Drawing.Size(29, 13);
            this.cartLabel.TabIndex = 13;
            this.cartLabel.Text = "Cart:";
            // 
            // customersComboBox
            // 
            this.customersComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customersComboBox.FormattingEnabled = true;
            this.customersComboBox.Location = new System.Drawing.Point(569, 21);
            this.customersComboBox.Name = "customersComboBox";
            this.customersComboBox.Size = new System.Drawing.Size(392, 21);
            this.customersComboBox.TabIndex = 12;
            this.customersComboBox.SelectedIndexChanged += new System.EventHandler(this.customersComboBox_SelectedIndexChanged);
            // 
            // totalLabel
            // 
            this.totalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalLabel.Location = new System.Drawing.Point(715, 957);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(248, 29);
            this.totalLabel.TabIndex = 25;
            this.totalLabel.Text = "0,00";
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // totalTextLabel
            // 
            this.totalTextLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.totalTextLabel.AutoSize = true;
            this.totalTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalTextLabel.Location = new System.Drawing.Point(910, 944);
            this.totalTextLabel.Name = "totalTextLabel";
            this.totalTextLabel.Size = new System.Drawing.Size(51, 13);
            this.totalTextLabel.TabIndex = 24;
            this.totalTextLabel.Text = "TOTAL:";
            // 
            // CartsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "CartsTab";
            this.Size = new System.Drawing.Size(1366, 986);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button itemsAddToCartButton;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label itemsLabel;
        private System.Windows.Forms.ListBox itemsListBox;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox customersComboBox;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Label amountTextLabel;
        private System.Windows.Forms.ListBox cartListBox;
        private System.Windows.Forms.Label cartLabel;
        private System.Windows.Forms.Button clearCartButton;
        private System.Windows.Forms.Button createOrderButton;
        private System.Windows.Forms.Button removeItemButton;
        private System.Windows.Forms.Label discountsLabel;
        private System.Windows.Forms.CheckedListBox discountsCheckedListBox;
        private System.Windows.Forms.Label discountAmountLabel;
        private System.Windows.Forms.Label discountAmountTextLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label totalTextLabel;
    }
}
