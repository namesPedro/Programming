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
            this.SeasonGroupBox = new System.Windows.Forms.GroupBox();
            this.SeasonButton = new System.Windows.Forms.Button();
            this.SeasonValueTextBox = new System.Windows.Forms.TextBox();
            this.SeasonHandLabel = new System.Windows.Forms.Label();
            this.WeekGroupBox = new System.Windows.Forms.GroupBox();
            this.WeekParsedLabel = new System.Windows.Forms.Label();
            this.ParseButton = new System.Windows.Forms.Button();
            this.ParsValueTextBox = new System.Windows.Forms.TextBox();
            this.WeekParsLabel = new System.Windows.Forms.Label();
            this.EnumsGroupBox = new System.Windows.Forms.GroupBox();
            this.EnumsListBox = new System.Windows.Forms.ListBox();
            this.EnumsLabel = new System.Windows.Forms.Label();
            this.ValuesLabel = new System.Windows.Forms.Label();
            this.IntValueLabel = new System.Windows.Forms.Label();
            this.IntValueTextBox = new System.Windows.Forms.TextBox();
            this.ValuesListBox = new System.Windows.Forms.ListBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.FilmsGroupBox = new System.Windows.Forms.GroupBox();
            this.RatingTextBox = new System.Windows.Forms.TextBox();
            this.RatingLabel = new System.Windows.Forms.Label();
            this.GenreTextBox = new System.Windows.Forms.TextBox();
            this.GenreLabel = new System.Windows.Forms.Label();
            this.ReleaseTextBox = new System.Windows.Forms.TextBox();
            this.FilmFindButton = new System.Windows.Forms.Button();
            this.DurationTextBox = new System.Windows.Forms.TextBox();
            this.FilmsListBox = new System.Windows.Forms.ListBox();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.ReleaseLabel = new System.Windows.Forms.Label();
            this.DurationLabel = new System.Windows.Forms.Label();
            this.RectanglesGroupBox = new System.Windows.Forms.GroupBox();
            this.FindButton = new System.Windows.Forms.Button();
            this.ColorTextBox = new System.Windows.Forms.TextBox();
            this.WidthTextBox = new System.Windows.Forms.TextBox();
            this.LengthTextBox = new System.Windows.Forms.TextBox();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.LengthLabel = new System.Windows.Forms.Label();
            this.RectanglesListBox = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.WeekdayParsingGroupBox.SuspendLayout();
            this.SeasonGroupBox.SuspendLayout();
            this.WeekGroupBox.SuspendLayout();
            this.EnumsGroupBox.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.FilmsGroupBox.SuspendLayout();
            this.RectanglesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.WeekdayParsingGroupBox);
            this.tabControl1.Controls.Add(this.tabPage1);
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
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.FilmsGroupBox);
            this.tabPage1.Controls.Add(this.RectanglesGroupBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 446);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Classes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // FilmsGroupBox
            // 
            this.FilmsGroupBox.Controls.Add(this.RatingTextBox);
            this.FilmsGroupBox.Controls.Add(this.RatingLabel);
            this.FilmsGroupBox.Controls.Add(this.GenreTextBox);
            this.FilmsGroupBox.Controls.Add(this.GenreLabel);
            this.FilmsGroupBox.Controls.Add(this.ReleaseTextBox);
            this.FilmsGroupBox.Controls.Add(this.FilmFindButton);
            this.FilmsGroupBox.Controls.Add(this.DurationTextBox);
            this.FilmsGroupBox.Controls.Add(this.FilmsListBox);
            this.FilmsGroupBox.Controls.Add(this.TitleTextBox);
            this.FilmsGroupBox.Controls.Add(this.TitleLabel);
            this.FilmsGroupBox.Controls.Add(this.ReleaseLabel);
            this.FilmsGroupBox.Controls.Add(this.DurationLabel);
            this.FilmsGroupBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.FilmsGroupBox.Location = new System.Drawing.Point(399, 3);
            this.FilmsGroupBox.Name = "FilmsGroupBox";
            this.FilmsGroupBox.Size = new System.Drawing.Size(390, 440);
            this.FilmsGroupBox.TabIndex = 1;
            this.FilmsGroupBox.TabStop = false;
            this.FilmsGroupBox.Text = "Films";
            // 
            // RatingTextBox
            // 
            this.RatingTextBox.Location = new System.Drawing.Point(135, 191);
            this.RatingTextBox.Name = "RatingTextBox";
            this.RatingTextBox.Size = new System.Drawing.Size(100, 20);
            this.RatingTextBox.TabIndex = 20;
            this.RatingTextBox.TextChanged += new System.EventHandler(this.RatingTextBox_TextChanged);
            // 
            // RatingLabel
            // 
            this.RatingLabel.AutoSize = true;
            this.RatingLabel.Location = new System.Drawing.Point(132, 175);
            this.RatingLabel.Name = "RatingLabel";
            this.RatingLabel.Size = new System.Drawing.Size(38, 13);
            this.RatingLabel.TabIndex = 19;
            this.RatingLabel.Text = "Rating";
            // 
            // GenreTextBox
            // 
            this.GenreTextBox.Location = new System.Drawing.Point(135, 152);
            this.GenreTextBox.Name = "GenreTextBox";
            this.GenreTextBox.Size = new System.Drawing.Size(100, 20);
            this.GenreTextBox.TabIndex = 18;
            // 
            // GenreLabel
            // 
            this.GenreLabel.AutoSize = true;
            this.GenreLabel.Location = new System.Drawing.Point(132, 136);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(36, 13);
            this.GenreLabel.TabIndex = 17;
            this.GenreLabel.Text = "Genre";
            // 
            // ReleaseTextBox
            // 
            this.ReleaseTextBox.Location = new System.Drawing.Point(135, 113);
            this.ReleaseTextBox.Name = "ReleaseTextBox";
            this.ReleaseTextBox.Size = new System.Drawing.Size(100, 20);
            this.ReleaseTextBox.TabIndex = 14;
            this.ReleaseTextBox.TextChanged += new System.EventHandler(this.YearTextBox_TextChanged);
            // 
            // FilmFindButton
            // 
            this.FilmFindButton.Location = new System.Drawing.Point(135, 221);
            this.FilmFindButton.Name = "FilmFindButton";
            this.FilmFindButton.Size = new System.Drawing.Size(100, 23);
            this.FilmFindButton.TabIndex = 16;
            this.FilmFindButton.Text = "Find";
            this.FilmFindButton.UseVisualStyleBackColor = true;
            this.FilmFindButton.Click += new System.EventHandler(this.FilmFindButton_Click);
            // 
            // DurationTextBox
            // 
            this.DurationTextBox.Location = new System.Drawing.Point(135, 74);
            this.DurationTextBox.Name = "DurationTextBox";
            this.DurationTextBox.Size = new System.Drawing.Size(100, 20);
            this.DurationTextBox.TabIndex = 13;
            this.DurationTextBox.TextChanged += new System.EventHandler(this.DurationTextBox_TextChanged);
            // 
            // FilmsListBox
            // 
            this.FilmsListBox.FormattingEnabled = true;
            this.FilmsListBox.Location = new System.Drawing.Point(6, 19);
            this.FilmsListBox.Name = "FilmsListBox";
            this.FilmsListBox.Size = new System.Drawing.Size(120, 225);
            this.FilmsListBox.TabIndex = 9;
            this.FilmsListBox.SelectedIndexChanged += new System.EventHandler(this.FilmsListBoxIndexChanged);
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(135, 35);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(100, 20);
            this.TitleTextBox.TabIndex = 12;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(132, 19);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(27, 13);
            this.TitleLabel.TabIndex = 9;
            this.TitleLabel.Text = "Title";
            // 
            // ReleaseLabel
            // 
            this.ReleaseLabel.AutoSize = true;
            this.ReleaseLabel.Location = new System.Drawing.Point(132, 97);
            this.ReleaseLabel.Name = "ReleaseLabel";
            this.ReleaseLabel.Size = new System.Drawing.Size(69, 13);
            this.ReleaseLabel.TabIndex = 11;
            this.ReleaseLabel.Text = "Release year";
            // 
            // DurationLabel
            // 
            this.DurationLabel.AutoSize = true;
            this.DurationLabel.Location = new System.Drawing.Point(132, 58);
            this.DurationLabel.Name = "DurationLabel";
            this.DurationLabel.Size = new System.Drawing.Size(47, 13);
            this.DurationLabel.TabIndex = 10;
            this.DurationLabel.Text = "Duration";
            // 
            // RectanglesGroupBox
            // 
            this.RectanglesGroupBox.Controls.Add(this.FindButton);
            this.RectanglesGroupBox.Controls.Add(this.ColorTextBox);
            this.RectanglesGroupBox.Controls.Add(this.WidthTextBox);
            this.RectanglesGroupBox.Controls.Add(this.LengthTextBox);
            this.RectanglesGroupBox.Controls.Add(this.ColorLabel);
            this.RectanglesGroupBox.Controls.Add(this.WidthLabel);
            this.RectanglesGroupBox.Controls.Add(this.LengthLabel);
            this.RectanglesGroupBox.Controls.Add(this.RectanglesListBox);
            this.RectanglesGroupBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.RectanglesGroupBox.Location = new System.Drawing.Point(3, 3);
            this.RectanglesGroupBox.Name = "RectanglesGroupBox";
            this.RectanglesGroupBox.Size = new System.Drawing.Size(390, 440);
            this.RectanglesGroupBox.TabIndex = 0;
            this.RectanglesGroupBox.TabStop = false;
            this.RectanglesGroupBox.Text = "Rectangles";
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(132, 221);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(100, 23);
            this.FindButton.TabIndex = 8;
            this.FindButton.Text = "Find";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // ColorTextBox
            // 
            this.ColorTextBox.Location = new System.Drawing.Point(135, 113);
            this.ColorTextBox.Name = "ColorTextBox";
            this.ColorTextBox.Size = new System.Drawing.Size(100, 20);
            this.ColorTextBox.TabIndex = 7;
            this.ColorTextBox.TextChanged += new System.EventHandler(this.ColorTextBox_TextChanged);
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
            this.RectanglesListBox.Size = new System.Drawing.Size(120, 225);
            this.RectanglesListBox.TabIndex = 1;
            this.RectanglesListBox.SelectedIndexChanged += new System.EventHandler(this.RectanglesListBoxIndexChanged);
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
            this.SeasonGroupBox.ResumeLayout(false);
            this.SeasonGroupBox.PerformLayout();
            this.WeekGroupBox.ResumeLayout(false);
            this.WeekGroupBox.PerformLayout();
            this.EnumsGroupBox.ResumeLayout(false);
            this.EnumsGroupBox.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.FilmsGroupBox.ResumeLayout(false);
            this.FilmsGroupBox.PerformLayout();
            this.RectanglesGroupBox.ResumeLayout(false);
            this.RectanglesGroupBox.PerformLayout();
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
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox RectanglesGroupBox;
        private System.Windows.Forms.ListBox RectanglesListBox;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.TextBox ColorTextBox;
        private System.Windows.Forms.TextBox WidthTextBox;
        private System.Windows.Forms.TextBox LengthTextBox;
        private System.Windows.Forms.Label ColorLabel;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.Label LengthLabel;
        private System.Windows.Forms.GroupBox FilmsGroupBox;
        private System.Windows.Forms.Button FilmFindButton;
        private System.Windows.Forms.ListBox FilmsListBox;
        private System.Windows.Forms.TextBox GenreTextBox;
        private System.Windows.Forms.Label GenreLabel;
        private System.Windows.Forms.TextBox ReleaseTextBox;
        private System.Windows.Forms.TextBox DurationTextBox;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label ReleaseLabel;
        private System.Windows.Forms.Label DurationLabel;
        private System.Windows.Forms.TextBox RatingTextBox;
        private System.Windows.Forms.Label RatingLabel;
    }
}

