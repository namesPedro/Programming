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
            this.seasonsEnumsControl2 = new Programming.View.Panels.SeasonsEnumsControl();
            this.weekdayEnumsControl2 = new Programming.View.Panels.WeekdayEnumsControl();
            this.enumerationsEnumsControl3 = new Programming.View.Panels.EnumerationsEnumsControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.moviesClassesControl2 = new Programming.View.Panels.MoviesClassesControl();
            this.rectanglesClassesControl2 = new Programming.View.Panels.RectanglesClassesControl();
            this.rectanglesTabPage = new System.Windows.Forms.TabPage();
            this.rectanglesCollisionControl1 = new Programming.View.Panels.RectanglesCollisionControl();
            this.tabControl1.SuspendLayout();
            this.WeekdayParsingGroupBox.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.rectanglesTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.WeekdayParsingGroupBox);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.rectanglesTabPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 472);
            this.tabControl1.TabIndex = 0;
            // 
            // WeekdayParsingGroupBox
            // 
            this.WeekdayParsingGroupBox.Controls.Add(this.seasonsEnumsControl2);
            this.WeekdayParsingGroupBox.Controls.Add(this.weekdayEnumsControl2);
            this.WeekdayParsingGroupBox.Controls.Add(this.enumerationsEnumsControl3);
            this.WeekdayParsingGroupBox.Location = new System.Drawing.Point(4, 22);
            this.WeekdayParsingGroupBox.Name = "WeekdayParsingGroupBox";
            this.WeekdayParsingGroupBox.Size = new System.Drawing.Size(792, 446);
            this.WeekdayParsingGroupBox.TabIndex = 0;
            this.WeekdayParsingGroupBox.Text = "Enums";
            // 
            // seasonsEnumsControl2
            // 
            this.seasonsEnumsControl2.Location = new System.Drawing.Point(409, 311);
            this.seasonsEnumsControl2.Name = "seasonsEnumsControl2";
            this.seasonsEnumsControl2.Size = new System.Drawing.Size(375, 127);
            this.seasonsEnumsControl2.TabIndex = 2;
            // 
            // weekdayEnumsControl2
            // 
            this.weekdayEnumsControl2.Location = new System.Drawing.Point(8, 311);
            this.weekdayEnumsControl2.Name = "weekdayEnumsControl2";
            this.weekdayEnumsControl2.Size = new System.Drawing.Size(395, 127);
            this.weekdayEnumsControl2.TabIndex = 1;
            // 
            // enumerationsEnumsControl3
            // 
            this.enumerationsEnumsControl3.Location = new System.Drawing.Point(8, 3);
            this.enumerationsEnumsControl3.Name = "enumerationsEnumsControl3";
            this.enumerationsEnumsControl3.Size = new System.Drawing.Size(776, 302);
            this.enumerationsEnumsControl3.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.moviesClassesControl2);
            this.tabPage1.Controls.Add(this.rectanglesClassesControl2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 446);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Classes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // moviesClassesControl2
            // 
            this.moviesClassesControl2.Location = new System.Drawing.Point(351, 6);
            this.moviesClassesControl2.Name = "moviesClassesControl2";
            this.moviesClassesControl2.Size = new System.Drawing.Size(433, 432);
            this.moviesClassesControl2.TabIndex = 1;
            // 
            // rectanglesClassesControl2
            // 
            this.rectanglesClassesControl2.Location = new System.Drawing.Point(6, 6);
            this.rectanglesClassesControl2.Name = "rectanglesClassesControl2";
            this.rectanglesClassesControl2.Size = new System.Drawing.Size(339, 432);
            this.rectanglesClassesControl2.TabIndex = 0;
            // 
            // rectanglesTabPage
            // 
            this.rectanglesTabPage.Controls.Add(this.rectanglesCollisionControl1);
            this.rectanglesTabPage.Location = new System.Drawing.Point(4, 22);
            this.rectanglesTabPage.Name = "rectanglesTabPage";
            this.rectanglesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.rectanglesTabPage.Size = new System.Drawing.Size(792, 446);
            this.rectanglesTabPage.TabIndex = 3;
            this.rectanglesTabPage.Text = "Rectangles";
            this.rectanglesTabPage.UseVisualStyleBackColor = true;
            // 
            // rectanglesCollisionControl1
            // 
            this.rectanglesCollisionControl1.Location = new System.Drawing.Point(8, 4);
            this.rectanglesCollisionControl1.Name = "rectanglesCollisionControl1";
            this.rectanglesCollisionControl1.Size = new System.Drawing.Size(788, 442);
            this.rectanglesCollisionControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 472);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.WeekdayParsingGroupBox.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.rectanglesTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage rectanglesTabPage;
        private View.Panels.SeasonsEnumsControl seasonsEnumsControl1;
        private View.Panels.WeekdayEnumsControl weekdayEnumsControl1;
        private View.Panels.EnumerationsEnumsControl enumerationsEnumsControl2;
        private View.Panels.MoviesClassesControl moviesClassesControl1;
        private View.Panels.RectanglesClassesControl rectanglesClassesControl1;
        private System.Windows.Forms.TabPage WeekdayParsingGroupBox;
        private View.Panels.SeasonsEnumsControl seasonsEnumsControl2;
        private View.Panels.WeekdayEnumsControl weekdayEnumsControl2;
        private View.Panels.EnumerationsEnumsControl enumerationsEnumsControl3;
        private View.Panels.MoviesClassesControl moviesClassesControl2;
        private View.Panels.RectanglesClassesControl rectanglesClassesControl2;
        private View.Panels.RectanglesCollisionControl rectanglesCollisionControl1;
    }
}

