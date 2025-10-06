namespace Programming.View.Panels
{
    partial class SeasonsEnumsControl
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
            this.SeasonGroupBox = new System.Windows.Forms.GroupBox();
            this.SeasonButton = new System.Windows.Forms.Button();
            this.SeasonValueTextBox = new System.Windows.Forms.TextBox();
            this.SeasonHandLabel = new System.Windows.Forms.Label();
            this.SeasonGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SeasonGroupBox
            // 
            this.SeasonGroupBox.Controls.Add(this.SeasonButton);
            this.SeasonGroupBox.Controls.Add(this.SeasonValueTextBox);
            this.SeasonGroupBox.Controls.Add(this.SeasonHandLabel);
            this.SeasonGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SeasonGroupBox.Location = new System.Drawing.Point(0, 0);
            this.SeasonGroupBox.Name = "SeasonGroupBox";
            this.SeasonGroupBox.Size = new System.Drawing.Size(308, 142);
            this.SeasonGroupBox.TabIndex = 10;
            this.SeasonGroupBox.TabStop = false;
            this.SeasonGroupBox.Text = "Season Handle";
            // 
            // SeasonButton
            // 
            this.SeasonButton.Location = new System.Drawing.Point(197, 39);
            this.SeasonButton.Name = "SeasonButton";
            this.SeasonButton.Size = new System.Drawing.Size(75, 23);
            this.SeasonButton.TabIndex = 11;
            this.SeasonButton.Text = "Go!";
            this.SeasonButton.UseVisualStyleBackColor = true;
            this.SeasonButton.Click += new System.EventHandler(this.SeasonButton_Click);
            // 
            // SeasonValueTextBox
            // 
            this.SeasonValueTextBox.Location = new System.Drawing.Point(9, 42);
            this.SeasonValueTextBox.Name = "SeasonValueTextBox";
            this.SeasonValueTextBox.Size = new System.Drawing.Size(182, 20);
            this.SeasonValueTextBox.TabIndex = 10;
            // 
            // SeasonHandLabel
            // 
            this.SeasonHandLabel.AutoSize = true;
            this.SeasonHandLabel.Location = new System.Drawing.Point(6, 26);
            this.SeasonHandLabel.Name = "SeasonHandLabel";
            this.SeasonHandLabel.Size = new System.Drawing.Size(83, 13);
            this.SeasonHandLabel.TabIndex = 0;
            this.SeasonHandLabel.Text = "Choose season:";
            // 
            // SeasonsEnumsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SeasonGroupBox);
            this.Name = "SeasonsEnumsControl";
            this.Size = new System.Drawing.Size(308, 142);
            this.SeasonGroupBox.ResumeLayout(false);
            this.SeasonGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SeasonGroupBox;
        private System.Windows.Forms.Button SeasonButton;
        private System.Windows.Forms.TextBox SeasonValueTextBox;
        private System.Windows.Forms.Label SeasonHandLabel;
    }
}
