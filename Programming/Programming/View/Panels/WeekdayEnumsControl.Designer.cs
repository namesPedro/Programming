namespace Programming.View.Panels
{
    partial class WeekdayEnumsControl
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
            this.WeekGroupBox = new System.Windows.Forms.GroupBox();
            this.WeekParsedLabel = new System.Windows.Forms.Label();
            this.ParseButton = new System.Windows.Forms.Button();
            this.ParsValueTextBox = new System.Windows.Forms.TextBox();
            this.WeekParsLabel = new System.Windows.Forms.Label();
            this.WeekGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // WeekGroupBox
            // 
            this.WeekGroupBox.Controls.Add(this.WeekParsedLabel);
            this.WeekGroupBox.Controls.Add(this.ParseButton);
            this.WeekGroupBox.Controls.Add(this.ParsValueTextBox);
            this.WeekGroupBox.Controls.Add(this.WeekParsLabel);
            this.WeekGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WeekGroupBox.Location = new System.Drawing.Point(0, 0);
            this.WeekGroupBox.Name = "WeekGroupBox";
            this.WeekGroupBox.Size = new System.Drawing.Size(303, 103);
            this.WeekGroupBox.TabIndex = 9;
            this.WeekGroupBox.TabStop = false;
            this.WeekGroupBox.Text = "Weekday Parsing";
            // 
            // WeekParsedLabel
            // 
            this.WeekParsedLabel.AutoSize = true;
            this.WeekParsedLabel.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.WeekParsedLabel.Location = new System.Drawing.Point(6, 78);
            this.WeekParsedLabel.Name = "WeekParsedLabel";
            this.WeekParsedLabel.Size = new System.Drawing.Size(95, 13);
            this.WeekParsedLabel.TabIndex = 3;
            this.WeekParsedLabel.Text = "WeekParsedLabel";
            // 
            // ParseButton
            // 
            this.ParseButton.Location = new System.Drawing.Point(197, 39);
            this.ParseButton.Name = "ParseButton";
            this.ParseButton.Size = new System.Drawing.Size(75, 23);
            this.ParseButton.TabIndex = 2;
            this.ParseButton.Text = "Parse";
            this.ParseButton.UseVisualStyleBackColor = true;
            this.ParseButton.Click += new System.EventHandler(this.ParseButton_Click);
            // 
            // ParsValueTextBox
            // 
            this.ParsValueTextBox.Location = new System.Drawing.Point(9, 42);
            this.ParsValueTextBox.Name = "ParsValueTextBox";
            this.ParsValueTextBox.Size = new System.Drawing.Size(182, 20);
            this.ParsValueTextBox.TabIndex = 1;
            // 
            // WeekParsLabel
            // 
            this.WeekParsLabel.AutoSize = true;
            this.WeekParsLabel.Location = new System.Drawing.Point(6, 26);
            this.WeekParsLabel.Name = "WeekParsLabel";
            this.WeekParsLabel.Size = new System.Drawing.Size(115, 13);
            this.WeekParsLabel.TabIndex = 0;
            this.WeekParsLabel.Text = "Type value for parsing:";
            // 
            // WeekdayEnumsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.WeekGroupBox);
            this.Name = "WeekdayEnumsControl";
            this.Size = new System.Drawing.Size(303, 103);
            this.WeekGroupBox.ResumeLayout(false);
            this.WeekGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox WeekGroupBox;
        private System.Windows.Forms.Label WeekParsedLabel;
        private System.Windows.Forms.Button ParseButton;
        private System.Windows.Forms.TextBox ParsValueTextBox;
        private System.Windows.Forms.Label WeekParsLabel;
    }
}
