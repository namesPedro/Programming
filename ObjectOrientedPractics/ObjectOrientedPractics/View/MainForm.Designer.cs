namespace ObjectOrientedPractics
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.itemsTabPage = new System.Windows.Forms.TabPage();
            this.itemsTab1 = new ObjectOrientedPractics.View.Tabs.ItemsTab();
            this.customersTabPage = new System.Windows.Forms.TabPage();
            this.customersTab1 = new ObjectOrientedPractics.View.Tabs.CustomersTab();
            this.cartsTabPage = new System.Windows.Forms.TabPage();
            this.cartsTab1 = new ObjectOrientedPractics.View.Tabs.CartsTab();
            this.ordersTabPage = new System.Windows.Forms.TabPage();
            this.ordersTab1 = new ObjectOrientedPractics.View.Tabs.OrdersTab();
            this.tabControl1.SuspendLayout();
            this.itemsTabPage.SuspendLayout();
            this.customersTabPage.SuspendLayout();
            this.cartsTabPage.SuspendLayout();
            this.ordersTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.itemsTabPage);
            this.tabControl1.Controls.Add(this.customersTabPage);
            this.tabControl1.Controls.Add(this.cartsTabPage);
            this.tabControl1.Controls.Add(this.ordersTabPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(984, 661);
            this.tabControl1.TabIndex = 0;
            // 
            // itemsTabPage
            // 
            this.itemsTabPage.Controls.Add(this.itemsTab1);
            this.itemsTabPage.Location = new System.Drawing.Point(4, 22);
            this.itemsTabPage.Name = "itemsTabPage";
            this.itemsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.itemsTabPage.Size = new System.Drawing.Size(976, 635);
            this.itemsTabPage.TabIndex = 0;
            this.itemsTabPage.Text = "Items";
            this.itemsTabPage.UseVisualStyleBackColor = true;
            // 
            // itemsTab1
            // 
            this.itemsTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemsTab1.Items = ((System.Collections.Generic.List<ObjectOrientedPractics.Model.Item>)(resources.GetObject("itemsTab1.Items")));
            this.itemsTab1.Location = new System.Drawing.Point(3, 3);
            this.itemsTab1.MinimumSize = new System.Drawing.Size(900, 630);
            this.itemsTab1.Name = "itemsTab1";
            this.itemsTab1.Size = new System.Drawing.Size(970, 630);
            this.itemsTab1.TabIndex = 0;
            // 
            // customersTabPage
            // 
            this.customersTabPage.Controls.Add(this.customersTab1);
            this.customersTabPage.Location = new System.Drawing.Point(4, 22);
            this.customersTabPage.Name = "customersTabPage";
            this.customersTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.customersTabPage.Size = new System.Drawing.Size(976, 635);
            this.customersTabPage.TabIndex = 1;
            this.customersTabPage.Text = "Customers";
            this.customersTabPage.UseVisualStyleBackColor = true;
            // 
            // customersTab1
            // 
            this.customersTab1.Customers = ((System.Collections.Generic.List<ObjectOrientedPractics.Model.Customer>)(resources.GetObject("customersTab1.Customers")));
            this.customersTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customersTab1.Location = new System.Drawing.Point(3, 3);
            this.customersTab1.MinimumSize = new System.Drawing.Size(950, 630);
            this.customersTab1.Name = "customersTab1";
            this.customersTab1.Size = new System.Drawing.Size(970, 630);
            this.customersTab1.TabIndex = 0;
            // 
            // cartsTabPage
            // 
            this.cartsTabPage.Controls.Add(this.cartsTab1);
            this.cartsTabPage.Location = new System.Drawing.Point(4, 22);
            this.cartsTabPage.Name = "cartsTabPage";
            this.cartsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.cartsTabPage.Size = new System.Drawing.Size(976, 635);
            this.cartsTabPage.TabIndex = 2;
            this.cartsTabPage.Text = "Carts";
            this.cartsTabPage.UseVisualStyleBackColor = true;
            // 
            // cartsTab1
            // 
            this.cartsTab1.Customers = ((System.Collections.Generic.List<ObjectOrientedPractics.Model.Customer>)(resources.GetObject("cartsTab1.Customers")));
            this.cartsTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cartsTab1.Items = ((System.Collections.Generic.List<ObjectOrientedPractics.Model.Item>)(resources.GetObject("cartsTab1.Items")));
            this.cartsTab1.Location = new System.Drawing.Point(3, 3);
            this.cartsTab1.Name = "cartsTab1";
            this.cartsTab1.OrdersTabRef = null;
            this.cartsTab1.Size = new System.Drawing.Size(970, 629);
            this.cartsTab1.TabIndex = 0;
            // 
            // ordersTabPage
            // 
            this.ordersTabPage.Controls.Add(this.ordersTab1);
            this.ordersTabPage.Location = new System.Drawing.Point(4, 22);
            this.ordersTabPage.Name = "ordersTabPage";
            this.ordersTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ordersTabPage.Size = new System.Drawing.Size(976, 635);
            this.ordersTabPage.TabIndex = 3;
            this.ordersTabPage.Text = "Orders";
            this.ordersTabPage.UseVisualStyleBackColor = true;
            // 
            // ordersTab1
            // 
            this.ordersTab1.Customers = ((System.Collections.Generic.List<ObjectOrientedPractics.Model.Customer>)(resources.GetObject("ordersTab1.Customers")));
            this.ordersTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ordersTab1.Location = new System.Drawing.Point(3, 3);
            this.ordersTab1.Name = "ordersTab1";
            this.ordersTab1.Size = new System.Drawing.Size(970, 629);
            this.ordersTab1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Object Oriented Practics";
            this.tabControl1.ResumeLayout(false);
            this.itemsTabPage.ResumeLayout(false);
            this.customersTabPage.ResumeLayout(false);
            this.cartsTabPage.ResumeLayout(false);
            this.ordersTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage itemsTabPage;
        private View.Tabs.ItemsTab itemsTab1;
        private System.Windows.Forms.TabPage customersTabPage;
        private View.Tabs.CustomersTab customersTab1;
        private System.Windows.Forms.TabPage cartsTabPage;
        private View.Tabs.CartsTab cartsTab1;
        private System.Windows.Forms.TabPage ordersTabPage;
        private View.Tabs.OrdersTab ordersTab1;
    }
}

