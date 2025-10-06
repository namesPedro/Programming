namespace Programming.View.Panels
{
    partial class RectanglesClassesControl
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
            this.RectanglesGroupBox = new System.Windows.Forms.GroupBox();
            this.RectangleIdTextBox = new System.Windows.Forms.TextBox();
            this.RectangleIdLabel = new System.Windows.Forms.Label();
            this.CenterYTextBox = new System.Windows.Forms.TextBox();
            this.FindButton = new System.Windows.Forms.Button();
            this.CenterYLabel = new System.Windows.Forms.Label();
            this.ColorTextBox = new System.Windows.Forms.TextBox();
            this.CenterXTextBox = new System.Windows.Forms.TextBox();
            this.CenterXLabel = new System.Windows.Forms.Label();
            this.WidthTextBox = new System.Windows.Forms.TextBox();
            this.LengthTextBox = new System.Windows.Forms.TextBox();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.LengthLabel = new System.Windows.Forms.Label();
            this.RectanglesListBox = new System.Windows.Forms.ListBox();
            this.RectanglesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // RectanglesGroupBox
            // 
            this.RectanglesGroupBox.Controls.Add(this.RectangleIdTextBox);
            this.RectanglesGroupBox.Controls.Add(this.RectangleIdLabel);
            this.RectanglesGroupBox.Controls.Add(this.CenterYTextBox);
            this.RectanglesGroupBox.Controls.Add(this.FindButton);
            this.RectanglesGroupBox.Controls.Add(this.CenterYLabel);
            this.RectanglesGroupBox.Controls.Add(this.ColorTextBox);
            this.RectanglesGroupBox.Controls.Add(this.CenterXTextBox);
            this.RectanglesGroupBox.Controls.Add(this.CenterXLabel);
            this.RectanglesGroupBox.Controls.Add(this.WidthTextBox);
            this.RectanglesGroupBox.Controls.Add(this.LengthTextBox);
            this.RectanglesGroupBox.Controls.Add(this.ColorLabel);
            this.RectanglesGroupBox.Controls.Add(this.WidthLabel);
            this.RectanglesGroupBox.Controls.Add(this.LengthLabel);
            this.RectanglesGroupBox.Controls.Add(this.RectanglesListBox);
            this.RectanglesGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RectanglesGroupBox.Location = new System.Drawing.Point(0, 0);
            this.RectanglesGroupBox.Name = "RectanglesGroupBox";
            this.RectanglesGroupBox.Size = new System.Drawing.Size(250, 294);
            this.RectanglesGroupBox.TabIndex = 1;
            this.RectanglesGroupBox.TabStop = false;
            this.RectanglesGroupBox.Text = "Rectangles";
            // 
            // RectangleIdTextBox
            // 
            this.RectangleIdTextBox.Location = new System.Drawing.Point(135, 230);
            this.RectangleIdTextBox.Name = "RectangleIdTextBox";
            this.RectangleIdTextBox.ReadOnly = true;
            this.RectangleIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.RectangleIdTextBox.TabIndex = 26;
            // 
            // RectangleIdLabel
            // 
            this.RectangleIdLabel.AutoSize = true;
            this.RectangleIdLabel.Location = new System.Drawing.Point(132, 214);
            this.RectangleIdLabel.Name = "RectangleIdLabel";
            this.RectangleIdLabel.Size = new System.Drawing.Size(16, 13);
            this.RectangleIdLabel.TabIndex = 25;
            this.RectangleIdLabel.Text = "Id";
            // 
            // CenterYTextBox
            // 
            this.CenterYTextBox.Location = new System.Drawing.Point(135, 191);
            this.CenterYTextBox.Name = "CenterYTextBox";
            this.CenterYTextBox.ReadOnly = true;
            this.CenterYTextBox.Size = new System.Drawing.Size(100, 20);
            this.CenterYTextBox.TabIndex = 24;
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(135, 260);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(100, 23);
            this.FindButton.TabIndex = 8;
            this.FindButton.Text = "Find";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.TextChanged += new System.EventHandler(this.FindButton_Click);
            // 
            // CenterYLabel
            // 
            this.CenterYLabel.AutoSize = true;
            this.CenterYLabel.Location = new System.Drawing.Point(132, 175);
            this.CenterYLabel.Name = "CenterYLabel";
            this.CenterYLabel.Size = new System.Drawing.Size(48, 13);
            this.CenterYLabel.TabIndex = 23;
            this.CenterYLabel.Text = "Center Y";
            // 
            // ColorTextBox
            // 
            this.ColorTextBox.Location = new System.Drawing.Point(135, 113);
            this.ColorTextBox.Name = "ColorTextBox";
            this.ColorTextBox.Size = new System.Drawing.Size(100, 20);
            this.ColorTextBox.TabIndex = 7;
            this.ColorTextBox.TextChanged += new System.EventHandler(this.ColorTextBox_TextChanged);
            // 
            // CenterXTextBox
            // 
            this.CenterXTextBox.Location = new System.Drawing.Point(135, 152);
            this.CenterXTextBox.Name = "CenterXTextBox";
            this.CenterXTextBox.ReadOnly = true;
            this.CenterXTextBox.Size = new System.Drawing.Size(100, 20);
            this.CenterXTextBox.TabIndex = 22;
            // 
            // CenterXLabel
            // 
            this.CenterXLabel.AutoSize = true;
            this.CenterXLabel.Location = new System.Drawing.Point(132, 136);
            this.CenterXLabel.Name = "CenterXLabel";
            this.CenterXLabel.Size = new System.Drawing.Size(48, 13);
            this.CenterXLabel.TabIndex = 21;
            this.CenterXLabel.Text = "Center X";
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.Location = new System.Drawing.Point(135, 74);
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.Size = new System.Drawing.Size(100, 20);
            this.WidthTextBox.TabIndex = 6;
            this.WidthTextBox.TextChanged += new System.EventHandler(this.WidthTextBox_TextChanged);
            // 
            // LengthTextBox
            // 
            this.LengthTextBox.Location = new System.Drawing.Point(135, 35);
            this.LengthTextBox.Name = "LengthTextBox";
            this.LengthTextBox.Size = new System.Drawing.Size(100, 20);
            this.LengthTextBox.TabIndex = 5;
            this.LengthTextBox.TextChanged += new System.EventHandler(this.LengthTextBox_TextChanged);
            // 
            // ColorLabel
            // 
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.Location = new System.Drawing.Point(132, 97);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(31, 13);
            this.ColorLabel.TabIndex = 4;
            this.ColorLabel.Text = "Color";
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Location = new System.Drawing.Point(132, 58);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(35, 13);
            this.WidthLabel.TabIndex = 3;
            this.WidthLabel.Text = "Width";
            // 
            // LengthLabel
            // 
            this.LengthLabel.AutoSize = true;
            this.LengthLabel.Location = new System.Drawing.Point(132, 19);
            this.LengthLabel.Name = "LengthLabel";
            this.LengthLabel.Size = new System.Drawing.Size(40, 13);
            this.LengthLabel.TabIndex = 2;
            this.LengthLabel.Text = "Length";
            // 
            // RectanglesListBox
            // 
            this.RectanglesListBox.FormattingEnabled = true;
            this.RectanglesListBox.Location = new System.Drawing.Point(6, 19);
            this.RectanglesListBox.Name = "RectanglesListBox";
            this.RectanglesListBox.Size = new System.Drawing.Size(120, 264);
            this.RectanglesListBox.TabIndex = 1;
            this.RectanglesListBox.SelectedIndexChanged += new System.EventHandler(this.RectanglesListBoxIndexChanged);
            // 
            // RectanglesClassesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RectanglesGroupBox);
            this.Name = "RectanglesClassesControl";
            this.Size = new System.Drawing.Size(250, 294);
            this.RectanglesGroupBox.ResumeLayout(false);
            this.RectanglesGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox RectanglesGroupBox;
        private System.Windows.Forms.TextBox RectangleIdTextBox;
        private System.Windows.Forms.Label RectangleIdLabel;
        private System.Windows.Forms.TextBox CenterYTextBox;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.Label CenterYLabel;
        private System.Windows.Forms.TextBox ColorTextBox;
        private System.Windows.Forms.TextBox CenterXTextBox;
        private System.Windows.Forms.Label CenterXLabel;
        private System.Windows.Forms.TextBox WidthTextBox;
        private System.Windows.Forms.TextBox LengthTextBox;
        private System.Windows.Forms.Label ColorLabel;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.Label LengthLabel;
        private System.Windows.Forms.ListBox RectanglesListBox;
    }
}
