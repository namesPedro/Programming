namespace Notes
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
            this.notesListBox = new System.Windows.Forms.ListBox();
            this.selectedNoteGroupBox = new System.Windows.Forms.GroupBox();
            this.noteCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.noteCategoryLabel = new System.Windows.Forms.Label();
            this.noteCreateTimeTextBox = new System.Windows.Forms.TextBox();
            this.noteCreateTimeLabel = new System.Windows.Forms.Label();
            this.noteTextTextBox = new System.Windows.Forms.TextBox();
            this.noteTitleTextBox = new System.Windows.Forms.TextBox();
            this.noteTextLabel = new System.Windows.Forms.Label();
            this.noteTitleLabel = new System.Windows.Forms.Label();
            this.noteAddButton = new System.Windows.Forms.Button();
            this.noteSaveButton = new System.Windows.Forms.Button();
            this.noteDeleteButton = new System.Windows.Forms.Button();
            this.selectedNoteGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // notesListBox
            // 
            this.notesListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.notesListBox.FormattingEnabled = true;
            this.notesListBox.Location = new System.Drawing.Point(12, 12);
            this.notesListBox.Name = "notesListBox";
            this.notesListBox.Size = new System.Drawing.Size(274, 407);
            this.notesListBox.TabIndex = 0;
            this.notesListBox.SelectedIndexChanged += new System.EventHandler(this.notesListBox_SelectedIndexChanged);
            // 
            // selectedNoteGroupBox
            // 
            this.selectedNoteGroupBox.Controls.Add(this.noteCategoryComboBox);
            this.selectedNoteGroupBox.Controls.Add(this.noteCategoryLabel);
            this.selectedNoteGroupBox.Controls.Add(this.noteCreateTimeTextBox);
            this.selectedNoteGroupBox.Controls.Add(this.noteCreateTimeLabel);
            this.selectedNoteGroupBox.Controls.Add(this.noteTextTextBox);
            this.selectedNoteGroupBox.Controls.Add(this.noteTitleTextBox);
            this.selectedNoteGroupBox.Controls.Add(this.noteTextLabel);
            this.selectedNoteGroupBox.Controls.Add(this.noteTitleLabel);
            this.selectedNoteGroupBox.Location = new System.Drawing.Point(292, 12);
            this.selectedNoteGroupBox.Name = "selectedNoteGroupBox";
            this.selectedNoteGroupBox.Size = new System.Drawing.Size(532, 304);
            this.selectedNoteGroupBox.TabIndex = 1;
            this.selectedNoteGroupBox.TabStop = false;
            this.selectedNoteGroupBox.Text = "Selected Note";
            // 
            // noteCategoryComboBox
            // 
            this.noteCategoryComboBox.FormattingEnabled = true;
            this.noteCategoryComboBox.Location = new System.Drawing.Point(98, 271);
            this.noteCategoryComboBox.Name = "noteCategoryComboBox";
            this.noteCategoryComboBox.Size = new System.Drawing.Size(187, 21);
            this.noteCategoryComboBox.TabIndex = 7;
            // 
            // noteCategoryLabel
            // 
            this.noteCategoryLabel.AutoSize = true;
            this.noteCategoryLabel.Location = new System.Drawing.Point(40, 274);
            this.noteCategoryLabel.Name = "noteCategoryLabel";
            this.noteCategoryLabel.Size = new System.Drawing.Size(52, 13);
            this.noteCategoryLabel.TabIndex = 6;
            this.noteCategoryLabel.Text = "Category:";
            // 
            // noteCreateTimeTextBox
            // 
            this.noteCreateTimeTextBox.Location = new System.Drawing.Point(98, 245);
            this.noteCreateTimeTextBox.Name = "noteCreateTimeTextBox";
            this.noteCreateTimeTextBox.ReadOnly = true;
            this.noteCreateTimeTextBox.Size = new System.Drawing.Size(187, 20);
            this.noteCreateTimeTextBox.TabIndex = 5;
            // 
            // noteCreateTimeLabel
            // 
            this.noteCreateTimeLabel.AutoSize = true;
            this.noteCreateTimeLabel.Location = new System.Drawing.Point(25, 248);
            this.noteCreateTimeLabel.Name = "noteCreateTimeLabel";
            this.noteCreateTimeLabel.Size = new System.Drawing.Size(67, 13);
            this.noteCreateTimeLabel.TabIndex = 4;
            this.noteCreateTimeLabel.Text = "Create Time:";
            // 
            // noteTextTextBox
            // 
            this.noteTextTextBox.Location = new System.Drawing.Point(98, 45);
            this.noteTextTextBox.Multiline = true;
            this.noteTextTextBox.Name = "noteTextTextBox";
            this.noteTextTextBox.Size = new System.Drawing.Size(376, 194);
            this.noteTextTextBox.TabIndex = 3;
            // 
            // noteTitleTextBox
            // 
            this.noteTitleTextBox.Location = new System.Drawing.Point(98, 19);
            this.noteTitleTextBox.Name = "noteTitleTextBox";
            this.noteTitleTextBox.Size = new System.Drawing.Size(417, 20);
            this.noteTitleTextBox.TabIndex = 2;
            // 
            // noteTextLabel
            // 
            this.noteTextLabel.AutoSize = true;
            this.noteTextLabel.Location = new System.Drawing.Point(61, 48);
            this.noteTextLabel.Name = "noteTextLabel";
            this.noteTextLabel.Size = new System.Drawing.Size(31, 13);
            this.noteTextLabel.TabIndex = 1;
            this.noteTextLabel.Text = "Text:";
            // 
            // noteTitleLabel
            // 
            this.noteTitleLabel.AutoSize = true;
            this.noteTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.noteTitleLabel.Location = new System.Drawing.Point(62, 22);
            this.noteTitleLabel.Name = "noteTitleLabel";
            this.noteTitleLabel.Size = new System.Drawing.Size(30, 13);
            this.noteTitleLabel.TabIndex = 0;
            this.noteTitleLabel.Text = "Title:";
            // 
            // noteAddButton
            // 
            this.noteAddButton.Location = new System.Drawing.Point(12, 425);
            this.noteAddButton.Name = "noteAddButton";
            this.noteAddButton.Size = new System.Drawing.Size(75, 23);
            this.noteAddButton.TabIndex = 2;
            this.noteAddButton.Text = "Add";
            this.noteAddButton.UseVisualStyleBackColor = true;
            this.noteAddButton.Click += new System.EventHandler(this.noteAddButton_Click);
            // 
            // noteSaveButton
            // 
            this.noteSaveButton.Location = new System.Drawing.Point(93, 425);
            this.noteSaveButton.Name = "noteSaveButton";
            this.noteSaveButton.Size = new System.Drawing.Size(75, 23);
            this.noteSaveButton.TabIndex = 3;
            this.noteSaveButton.Text = "Save";
            this.noteSaveButton.UseVisualStyleBackColor = true;
            this.noteSaveButton.Click += new System.EventHandler(this.noteSaveButton_Click);
            // 
            // noteDeleteButton
            // 
            this.noteDeleteButton.Location = new System.Drawing.Point(174, 425);
            this.noteDeleteButton.Name = "noteDeleteButton";
            this.noteDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.noteDeleteButton.TabIndex = 4;
            this.noteDeleteButton.Text = "Delete";
            this.noteDeleteButton.UseVisualStyleBackColor = true;
            this.noteDeleteButton.Click += new System.EventHandler(this.noteDeleteButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 460);
            this.Controls.Add(this.noteDeleteButton);
            this.Controls.Add(this.noteSaveButton);
            this.Controls.Add(this.noteAddButton);
            this.Controls.Add(this.selectedNoteGroupBox);
            this.Controls.Add(this.notesListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.selectedNoteGroupBox.ResumeLayout(false);
            this.selectedNoteGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox notesListBox;
        private System.Windows.Forms.GroupBox selectedNoteGroupBox;
        private System.Windows.Forms.TextBox noteTitleTextBox;
        private System.Windows.Forms.Label noteTextLabel;
        private System.Windows.Forms.Label noteTitleLabel;
        private System.Windows.Forms.Label noteCategoryLabel;
        private System.Windows.Forms.TextBox noteCreateTimeTextBox;
        private System.Windows.Forms.Label noteCreateTimeLabel;
        private System.Windows.Forms.TextBox noteTextTextBox;
        private System.Windows.Forms.ComboBox noteCategoryComboBox;
        private System.Windows.Forms.Button noteAddButton;
        private System.Windows.Forms.Button noteSaveButton;
        private System.Windows.Forms.Button noteDeleteButton;
    }
}

