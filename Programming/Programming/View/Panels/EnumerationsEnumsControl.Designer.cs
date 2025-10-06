namespace Programming.View.Panels
{
    partial class EnumerationsEnumsControl
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
            this.EnumsGroupBox = new System.Windows.Forms.GroupBox();
            this.EnumsListBox = new System.Windows.Forms.ListBox();
            this.EnumsLabel = new System.Windows.Forms.Label();
            this.ValuesLabel = new System.Windows.Forms.Label();
            this.IntValueLabel = new System.Windows.Forms.Label();
            this.IntValueTextBox = new System.Windows.Forms.TextBox();
            this.ValuesListBox = new System.Windows.Forms.ListBox();
            this.EnumsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // EnumsGroupBox
            // 
            this.EnumsGroupBox.Controls.Add(this.EnumsListBox);
            this.EnumsGroupBox.Controls.Add(this.EnumsLabel);
            this.EnumsGroupBox.Controls.Add(this.ValuesLabel);
            this.EnumsGroupBox.Controls.Add(this.IntValueLabel);
            this.EnumsGroupBox.Controls.Add(this.IntValueTextBox);
            this.EnumsGroupBox.Controls.Add(this.ValuesListBox);
            this.EnumsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EnumsGroupBox.Location = new System.Drawing.Point(0, 0);
            this.EnumsGroupBox.Name = "EnumsGroupBox";
            this.EnumsGroupBox.Size = new System.Drawing.Size(547, 302);
            this.EnumsGroupBox.TabIndex = 8;
            this.EnumsGroupBox.TabStop = false;
            this.EnumsGroupBox.Text = "Enumerations";
            // 
            // EnumsListBox
            // 
            this.EnumsListBox.FormattingEnabled = true;
            this.EnumsListBox.Location = new System.Drawing.Point(9, 42);
            this.EnumsListBox.Name = "EnumsListBox";
            this.EnumsListBox.ScrollAlwaysVisible = true;
            this.EnumsListBox.Size = new System.Drawing.Size(148, 238);
            this.EnumsListBox.TabIndex = 0;
            this.EnumsListBox.SelectedIndexChanged += new System.EventHandler(this.EnumsListBoxIndexChanged);
            // 
            // EnumsLabel
            // 
            this.EnumsLabel.AutoSize = true;
            this.EnumsLabel.Location = new System.Drawing.Point(6, 26);
            this.EnumsLabel.Name = "EnumsLabel";
            this.EnumsLabel.Size = new System.Drawing.Size(107, 13);
            this.EnumsLabel.TabIndex = 1;
            this.EnumsLabel.Text = "Choose enumeration:";
            // 
            // ValuesLabel
            // 
            this.ValuesLabel.AutoSize = true;
            this.ValuesLabel.Location = new System.Drawing.Point(173, 26);
            this.ValuesLabel.Name = "ValuesLabel";
            this.ValuesLabel.Size = new System.Drawing.Size(75, 13);
            this.ValuesLabel.TabIndex = 2;
            this.ValuesLabel.Text = "Choose value:";
            // 
            // IntValueLabel
            // 
            this.IntValueLabel.AutoSize = true;
            this.IntValueLabel.Location = new System.Drawing.Point(340, 26);
            this.IntValueLabel.Name = "IntValueLabel";
            this.IntValueLabel.Size = new System.Drawing.Size(52, 13);
            this.IntValueLabel.TabIndex = 4;
            this.IntValueLabel.Text = "Int Value:";
            // 
            // IntValueTextBox
            // 
            this.IntValueTextBox.Location = new System.Drawing.Point(343, 42);
            this.IntValueTextBox.Name = "IntValueTextBox";
            this.IntValueTextBox.Size = new System.Drawing.Size(100, 20);
            this.IntValueTextBox.TabIndex = 5;
            // 
            // ValuesListBox
            // 
            this.ValuesListBox.FormattingEnabled = true;
            this.ValuesListBox.Location = new System.Drawing.Point(176, 42);
            this.ValuesListBox.Name = "ValuesListBox";
            this.ValuesListBox.ScrollAlwaysVisible = true;
            this.ValuesListBox.Size = new System.Drawing.Size(148, 238);
            this.ValuesListBox.TabIndex = 3;
            this.ValuesListBox.SelectedIndexChanged += new System.EventHandler(this.ValuesListBoxIndexChanged);
            // 
            // EnumerationsEnumsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.EnumsGroupBox);
            this.Name = "EnumerationsEnumsControl";
            this.Size = new System.Drawing.Size(547, 302);
            this.EnumsGroupBox.ResumeLayout(false);
            this.EnumsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox EnumsGroupBox;
        private System.Windows.Forms.ListBox EnumsListBox;
        private System.Windows.Forms.Label EnumsLabel;
        private System.Windows.Forms.Label ValuesLabel;
        private System.Windows.Forms.Label IntValueLabel;
        private System.Windows.Forms.TextBox IntValueTextBox;
        private System.Windows.Forms.ListBox ValuesListBox;
    }
}
