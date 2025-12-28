namespace ObjectOrientedPractics.View.Controls
{
    partial class AddressControl
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
            this.apartmentTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.buildingTextBox = new System.Windows.Forms.TextBox();
            this.streetTextBox = new System.Windows.Forms.TextBox();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.postIndexTextBox = new System.Windows.Forms.TextBox();
            this.apartmentLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.buildingLabel = new System.Windows.Forms.Label();
            this.streetLabel = new System.Windows.Forms.Label();
            this.countryLabel = new System.Windows.Forms.Label();
            this.postIndexLabel = new System.Windows.Forms.Label();
            this.deliveryAddressLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // apartmentTextBox
            // 
            this.apartmentTextBox.Location = new System.Drawing.Point(195, 94);
            this.apartmentTextBox.Name = "apartmentTextBox";
            this.apartmentTextBox.Size = new System.Drawing.Size(56, 20);
            this.apartmentTextBox.TabIndex = 25;
            this.apartmentTextBox.TextChanged += new System.EventHandler(this.apartmentTextBox_TextChanged);
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(238, 42);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(130, 20);
            this.cityTextBox.TabIndex = 24;
            this.cityTextBox.Leave += new System.EventHandler(this.cityTextBox_TextChanged);
            // 
            // buildingTextBox
            // 
            this.buildingTextBox.Location = new System.Drawing.Point(69, 94);
            this.buildingTextBox.Name = "buildingTextBox";
            this.buildingTextBox.Size = new System.Drawing.Size(56, 20);
            this.buildingTextBox.TabIndex = 23;
            this.buildingTextBox.TextChanged += new System.EventHandler(this.buildingTextBox_TextChanged);
            // 
            // streetTextBox
            // 
            this.streetTextBox.Location = new System.Drawing.Point(69, 68);
            this.streetTextBox.Name = "streetTextBox";
            this.streetTextBox.Size = new System.Drawing.Size(299, 20);
            this.streetTextBox.TabIndex = 22;
            this.streetTextBox.TextChanged += new System.EventHandler(this.streetTextBox_TextChanged);
            // 
            // countryTextBox
            // 
            this.countryTextBox.Location = new System.Drawing.Point(69, 42);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(130, 20);
            this.countryTextBox.TabIndex = 21;
            this.countryTextBox.TextChanged += new System.EventHandler(this.countryTextBox_TextChanged);
            // 
            // postIndexTextBox
            // 
            this.postIndexTextBox.Location = new System.Drawing.Point(69, 16);
            this.postIndexTextBox.Name = "postIndexTextBox";
            this.postIndexTextBox.Size = new System.Drawing.Size(100, 20);
            this.postIndexTextBox.TabIndex = 20;
            this.postIndexTextBox.TextChanged += new System.EventHandler(this.postIndexTextBox_TextChanged);
            // 
            // apartmentLabel
            // 
            this.apartmentLabel.AutoSize = true;
            this.apartmentLabel.Location = new System.Drawing.Point(131, 97);
            this.apartmentLabel.Name = "apartmentLabel";
            this.apartmentLabel.Size = new System.Drawing.Size(58, 13);
            this.apartmentLabel.TabIndex = 19;
            this.apartmentLabel.Text = "Apartment:";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(205, 45);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(27, 13);
            this.cityLabel.TabIndex = 18;
            this.cityLabel.Text = "City:";
            // 
            // buildingLabel
            // 
            this.buildingLabel.AutoSize = true;
            this.buildingLabel.Location = new System.Drawing.Point(3, 97);
            this.buildingLabel.Name = "buildingLabel";
            this.buildingLabel.Size = new System.Drawing.Size(47, 13);
            this.buildingLabel.TabIndex = 17;
            this.buildingLabel.Text = "Building:";
            // 
            // streetLabel
            // 
            this.streetLabel.AutoSize = true;
            this.streetLabel.Location = new System.Drawing.Point(3, 71);
            this.streetLabel.Name = "streetLabel";
            this.streetLabel.Size = new System.Drawing.Size(38, 13);
            this.streetLabel.TabIndex = 16;
            this.streetLabel.Text = "Street:";
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Location = new System.Drawing.Point(3, 45);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(46, 13);
            this.countryLabel.TabIndex = 15;
            this.countryLabel.Text = "Country:";
            // 
            // postIndexLabel
            // 
            this.postIndexLabel.AutoSize = true;
            this.postIndexLabel.Location = new System.Drawing.Point(3, 19);
            this.postIndexLabel.Name = "postIndexLabel";
            this.postIndexLabel.Size = new System.Drawing.Size(60, 13);
            this.postIndexLabel.TabIndex = 14;
            this.postIndexLabel.Text = "Post Index:";
            // 
            // deliveryAddressLabel
            // 
            this.deliveryAddressLabel.AutoSize = true;
            this.deliveryAddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deliveryAddressLabel.Location = new System.Drawing.Point(3, 0);
            this.deliveryAddressLabel.Name = "deliveryAddressLabel";
            this.deliveryAddressLabel.Size = new System.Drawing.Size(102, 13);
            this.deliveryAddressLabel.TabIndex = 13;
            this.deliveryAddressLabel.Text = "Delivery Address";
            // 
            // AddressControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.apartmentTextBox);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.buildingTextBox);
            this.Controls.Add(this.streetTextBox);
            this.Controls.Add(this.countryTextBox);
            this.Controls.Add(this.postIndexTextBox);
            this.Controls.Add(this.apartmentLabel);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.buildingLabel);
            this.Controls.Add(this.streetLabel);
            this.Controls.Add(this.countryLabel);
            this.Controls.Add(this.postIndexLabel);
            this.Controls.Add(this.deliveryAddressLabel);
            this.Name = "AddressControl";
            this.Size = new System.Drawing.Size(379, 123);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox apartmentTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox buildingTextBox;
        private System.Windows.Forms.TextBox streetTextBox;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.TextBox postIndexTextBox;
        private System.Windows.Forms.Label apartmentLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label buildingLabel;
        private System.Windows.Forms.Label streetLabel;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.Label postIndexLabel;
        private System.Windows.Forms.Label deliveryAddressLabel;
    }
}
