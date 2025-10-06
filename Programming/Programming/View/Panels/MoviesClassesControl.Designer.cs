namespace Programming.View.Panels
{
    partial class MoviesClassesControl
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
            this.FilmsGroupBox.SuspendLayout();
            this.SuspendLayout();
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
            this.FilmsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FilmsGroupBox.Location = new System.Drawing.Point(0, 0);
            this.FilmsGroupBox.Name = "FilmsGroupBox";
            this.FilmsGroupBox.Size = new System.Drawing.Size(258, 305);
            this.FilmsGroupBox.TabIndex = 2;
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
            this.FilmFindButton.Location = new System.Drawing.Point(135, 260);
            this.FilmFindButton.Name = "FilmFindButton";
            this.FilmFindButton.Size = new System.Drawing.Size(100, 23);
            this.FilmFindButton.TabIndex = 16;
            this.FilmFindButton.Text = "Find";
            this.FilmFindButton.UseVisualStyleBackColor = true;
            this.FilmFindButton.TextChanged += new System.EventHandler(this.FilmFindButton_Click);
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
            this.FilmsListBox.Size = new System.Drawing.Size(120, 264);
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
            // MoviesClassesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FilmsGroupBox);
            this.Name = "MoviesClassesControl";
            this.Size = new System.Drawing.Size(258, 305);
            this.FilmsGroupBox.ResumeLayout(false);
            this.FilmsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox FilmsGroupBox;
        private System.Windows.Forms.TextBox RatingTextBox;
        private System.Windows.Forms.Label RatingLabel;
        private System.Windows.Forms.TextBox GenreTextBox;
        private System.Windows.Forms.Label GenreLabel;
        private System.Windows.Forms.TextBox ReleaseTextBox;
        private System.Windows.Forms.Button FilmFindButton;
        private System.Windows.Forms.TextBox DurationTextBox;
        private System.Windows.Forms.ListBox FilmsListBox;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label ReleaseLabel;
        private System.Windows.Forms.Label DurationLabel;
    }
}
