namespace Programming
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.WeekdayParsingGroupBox = new System.Windows.Forms.TabPage();
            this.IntValueTextBox = new System.Windows.Forms.TextBox();
            this.IntValueLabel = new System.Windows.Forms.Label();
            this.ValuesListBox = new System.Windows.Forms.ListBox();
            this.ValuesLabel = new System.Windows.Forms.Label();
            this.EnumsLabel = new System.Windows.Forms.Label();
            this.EnumsListBox = new System.Windows.Forms.ListBox();
            this.EnumsGroupBox = new System.Windows.Forms.GroupBox();
            this.WeekGroupBox = new System.Windows.Forms.GroupBox();
            this.SeasonGroupBox = new System.Windows.Forms.GroupBox();
            this.WeekParsLabel = new System.Windows.Forms.Label();
            this.ParsValueTextBox = new System.Windows.Forms.TextBox();
            this.ParseButton = new System.Windows.Forms.Button();
            this.WeekParsedLabel = new System.Windows.Forms.Label();
            this.SeasonHandLabel = new System.Windows.Forms.Label();
            this.SeasonValueTextBox = new System.Windows.Forms.TextBox();
            this.SeasonButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.WeekdayParsingGroupBox.SuspendLayout();
            this.EnumsGroupBox.SuspendLayout();
            this.WeekGroupBox.SuspendLayout();
            this.SeasonGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.WeekdayParsingGroupBox);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 472);
            this.tabControl1.TabIndex = 0;
            // 
            // WeekdayParsingGroupBox
            // 
            this.WeekdayParsingGroupBox.Controls.Add(this.SeasonGroupBox);
            this.WeekdayParsingGroupBox.Controls.Add(this.WeekGroupBox);
            this.WeekdayParsingGroupBox.Controls.Add(this.EnumsGroupBox);
            this.WeekdayParsingGroupBox.Location = new System.Drawing.Point(4, 22);
            this.WeekdayParsingGroupBox.Name = "WeekdayParsingGroupBox";
            this.WeekdayParsingGroupBox.Padding = new System.Windows.Forms.Padding(3);
            this.WeekdayParsingGroupBox.Size = new System.Drawing.Size(792, 446);
            this.WeekdayParsingGroupBox.TabIndex = 1;
            this.WeekdayParsingGroupBox.Text = "Enums";
            this.WeekdayParsingGroupBox.UseVisualStyleBackColor = true;
            // 
            // IntValueTextBox
            // 
            this.IntValueTextBox.Location = new System.Drawing.Point(343, 42);
            this.IntValueTextBox.Name = "IntValueTextBox";
            this.IntValueTextBox.Size = new System.Drawing.Size(100, 20);
            this.IntValueTextBox.TabIndex = 5;
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
            // ValuesLabel
            // 
            this.ValuesLabel.AutoSize = true;
            this.ValuesLabel.Location = new System.Drawing.Point(173, 26);
            this.ValuesLabel.Name = "ValuesLabel";
            this.ValuesLabel.Size = new System.Drawing.Size(75, 13);
            this.ValuesLabel.TabIndex = 2;
            this.ValuesLabel.Text = "Choose value:";
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
            // EnumsGroupBox
            // 
            this.EnumsGroupBox.Controls.Add(this.EnumsListBox);
            this.EnumsGroupBox.Controls.Add(this.EnumsLabel);
            this.EnumsGroupBox.Controls.Add(this.ValuesLabel);
            this.EnumsGroupBox.Controls.Add(this.IntValueLabel);
            this.EnumsGroupBox.Controls.Add(this.IntValueTextBox);
            this.EnumsGroupBox.Controls.Add(this.ValuesListBox);
            this.EnumsGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.EnumsGroupBox.Location = new System.Drawing.Point(3, 3);
            this.EnumsGroupBox.Name = "EnumsGroupBox";
            this.EnumsGroupBox.Size = new System.Drawing.Size(786, 300);
            this.EnumsGroupBox.TabIndex = 7;
            this.EnumsGroupBox.TabStop = false;
            this.EnumsGroupBox.Text = "Enumerations";
            // 
            // WeekGroupBox
            // 
            this.WeekGroupBox.Controls.Add(this.WeekParsedLabel);
            this.WeekGroupBox.Controls.Add(this.ParseButton);
            this.WeekGroupBox.Controls.Add(this.ParsValueTextBox);
            this.WeekGroupBox.Controls.Add(this.WeekParsLabel);
            this.WeekGroupBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.WeekGroupBox.Location = new System.Drawing.Point(3, 303);
            this.WeekGroupBox.Name = "WeekGroupBox";
            this.WeekGroupBox.Size = new System.Drawing.Size(390, 140);
            this.WeekGroupBox.TabIndex = 8;
            this.WeekGroupBox.TabStop = false;
            this.WeekGroupBox.Text = "Weekday Parsing";
            // 
            // SeasonGroupBox
            // 
            this.SeasonGroupBox.Controls.Add(this.SeasonButton);
            this.SeasonGroupBox.Controls.Add(this.SeasonValueTextBox);
            this.SeasonGroupBox.Controls.Add(this.SeasonHandLabel);
            this.SeasonGroupBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.SeasonGroupBox.Location = new System.Drawing.Point(399, 303);
            this.SeasonGroupBox.Name = "SeasonGroupBox";
            this.SeasonGroupBox.Size = new System.Drawing.Size(390, 140);
            this.SeasonGroupBox.TabIndex = 9;
            this.SeasonGroupBox.TabStop = false;
            this.SeasonGroupBox.Text = "Season Handle";
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
            // ParsValueTextBox
            // 
            this.ParsValueTextBox.Location = new System.Drawing.Point(9, 42);
            this.ParsValueTextBox.Name = "ParsValueTextBox";
            this.ParsValueTextBox.Size = new System.Drawing.Size(182, 20);
            this.ParsValueTextBox.TabIndex = 1;
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
            // SeasonHandLabel
            // 
            this.SeasonHandLabel.AutoSize = true;
            this.SeasonHandLabel.Location = new System.Drawing.Point(6, 26);
            this.SeasonHandLabel.Name = "SeasonHandLabel";
            this.SeasonHandLabel.Size = new System.Drawing.Size(83, 13);
            this.SeasonHandLabel.TabIndex = 0;
            this.SeasonHandLabel.Text = "Choose season:";
            // 
            // SeasonValueTextBox
            // 
            this.SeasonValueTextBox.Location = new System.Drawing.Point(9, 42);
            this.SeasonValueTextBox.Name = "SeasonValueTextBox";
            this.SeasonValueTextBox.Size = new System.Drawing.Size(182, 20);
            this.SeasonValueTextBox.TabIndex = 10;
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 472);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.WeekdayParsingGroupBox.ResumeLayout(false);
            this.EnumsGroupBox.ResumeLayout(false);
            this.EnumsGroupBox.PerformLayout();
            this.WeekGroupBox.ResumeLayout(false);
            this.WeekGroupBox.PerformLayout();
            this.SeasonGroupBox.ResumeLayout(false);
            this.SeasonGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage WeekdayParsingGroupBox;
        private System.Windows.Forms.ListBox ValuesListBox;
        private System.Windows.Forms.Label ValuesLabel;
        private System.Windows.Forms.Label EnumsLabel;
        private System.Windows.Forms.ListBox EnumsListBox;
        private System.Windows.Forms.TextBox IntValueTextBox;
        private System.Windows.Forms.Label IntValueLabel;
        private System.Windows.Forms.GroupBox EnumsGroupBox;
        private System.Windows.Forms.GroupBox WeekGroupBox;
        private System.Windows.Forms.GroupBox SeasonGroupBox;
        private System.Windows.Forms.Label WeekParsLabel;
        private System.Windows.Forms.Label WeekParsedLabel;
        private System.Windows.Forms.Button ParseButton;
        private System.Windows.Forms.TextBox ParsValueTextBox;
        private System.Windows.Forms.Label SeasonHandLabel;
        private System.Windows.Forms.Button SeasonButton;
        private System.Windows.Forms.TextBox SeasonValueTextBox;
    }
}

