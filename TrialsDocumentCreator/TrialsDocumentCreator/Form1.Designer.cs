namespace TrialsDocumentCreator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TrialTypeLabel = new System.Windows.Forms.Label();
            this.TrialTypeComboBox = new System.Windows.Forms.ComboBox();
            this.CreateButton = new System.Windows.Forms.Button();
            this.PlayersLabel = new System.Windows.Forms.Label();
            this.PlayersTextBox = new System.Windows.Forms.TextBox();
            this.PathLabel = new System.Windows.Forms.Label();
            this.SavePathTextBox = new System.Windows.Forms.TextBox();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.TrialsEditButton = new System.Windows.Forms.Button();
            this.DifficultyEditButton = new System.Windows.Forms.Button();
            this.RigsEditButton = new System.Windows.Forms.Button();
            this.AmphsEditButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TrialTypeLabel
            // 
            this.TrialTypeLabel.AutoSize = true;
            this.TrialTypeLabel.Font = new System.Drawing.Font("Courier New", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TrialTypeLabel.Location = new System.Drawing.Point(20, 14);
            this.TrialTypeLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.TrialTypeLabel.Name = "TrialTypeLabel";
            this.TrialTypeLabel.Size = new System.Drawing.Size(142, 22);
            this.TrialTypeLabel.TabIndex = 0;
            this.TrialTypeLabel.Text = "Trial Type:";
            // 
            // TrialTypeComboBox
            // 
            this.TrialTypeComboBox.FormattingEnabled = true;
            this.TrialTypeComboBox.Location = new System.Drawing.Point(172, 11);
            this.TrialTypeComboBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TrialTypeComboBox.Name = "TrialTypeComboBox";
            this.TrialTypeComboBox.Size = new System.Drawing.Size(204, 30);
            this.TrialTypeComboBox.TabIndex = 1;
            this.TrialTypeComboBox.Text = "Trial Type";
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(24, 391);
            this.CreateButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(449, 36);
            this.CreateButton.TabIndex = 2;
            this.CreateButton.Text = "Create Document";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // PlayersLabel
            // 
            this.PlayersLabel.AutoSize = true;
            this.PlayersLabel.Font = new System.Drawing.Font("Courier New", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlayersLabel.Location = new System.Drawing.Point(20, 56);
            this.PlayersLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.PlayersLabel.Name = "PlayersLabel";
            this.PlayersLabel.Size = new System.Drawing.Size(106, 22);
            this.PlayersLabel.TabIndex = 3;
            this.PlayersLabel.Text = "Players:";
            // 
            // PlayersTextBox
            // 
            this.PlayersTextBox.Location = new System.Drawing.Point(134, 53);
            this.PlayersTextBox.Name = "PlayersTextBox";
            this.PlayersTextBox.Size = new System.Drawing.Size(100, 30);
            this.PlayersTextBox.TabIndex = 4;
            this.PlayersTextBox.Text = "1";
            // 
            // PathLabel
            // 
            this.PathLabel.AutoSize = true;
            this.PathLabel.Font = new System.Drawing.Font("Courier New", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PathLabel.Location = new System.Drawing.Point(20, 357);
            this.PathLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.PathLabel.Name = "PathLabel";
            this.PathLabel.Size = new System.Drawing.Size(130, 22);
            this.PathLabel.TabIndex = 5;
            this.PathLabel.Text = "Save Path:";
            // 
            // SavePathTextBox
            // 
            this.SavePathTextBox.Location = new System.Drawing.Point(158, 354);
            this.SavePathTextBox.Name = "SavePathTextBox";
            this.SavePathTextBox.Size = new System.Drawing.Size(218, 30);
            this.SavePathTextBox.TabIndex = 6;
            this.SavePathTextBox.Text = "C:\\";
            // 
            // BrowseButton
            // 
            this.BrowseButton.Location = new System.Drawing.Point(382, 354);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(91, 30);
            this.BrowseButton.TabIndex = 7;
            this.BrowseButton.Text = "Browse";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // TrialsEditButton
            // 
            this.TrialsEditButton.Location = new System.Drawing.Point(455, 116);
            this.TrialsEditButton.Name = "TrialsEditButton";
            this.TrialsEditButton.Size = new System.Drawing.Size(453, 30);
            this.TrialsEditButton.TabIndex = 8;
            this.TrialsEditButton.Text = "Edit Trials";
            this.TrialsEditButton.UseVisualStyleBackColor = true;
            // 
            // DifficultyEditButton
            // 
            this.DifficultyEditButton.Location = new System.Drawing.Point(455, 158);
            this.DifficultyEditButton.Name = "DifficultyEditButton";
            this.DifficultyEditButton.Size = new System.Drawing.Size(453, 30);
            this.DifficultyEditButton.TabIndex = 9;
            this.DifficultyEditButton.Text = "Edit Difficulty";
            this.DifficultyEditButton.UseVisualStyleBackColor = true;
            // 
            // RigsEditButton
            // 
            this.RigsEditButton.Location = new System.Drawing.Point(455, 200);
            this.RigsEditButton.Name = "RigsEditButton";
            this.RigsEditButton.Size = new System.Drawing.Size(453, 30);
            this.RigsEditButton.TabIndex = 10;
            this.RigsEditButton.Text = "Edit Rigs";
            this.RigsEditButton.UseVisualStyleBackColor = true;
            // 
            // AmphsEditButton
            // 
            this.AmphsEditButton.Location = new System.Drawing.Point(455, 242);
            this.AmphsEditButton.Name = "AmphsEditButton";
            this.AmphsEditButton.Size = new System.Drawing.Size(453, 30);
            this.AmphsEditButton.TabIndex = 11;
            this.AmphsEditButton.Text = "Edit Amphs";
            this.AmphsEditButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(931, 486);
            this.Controls.Add(this.AmphsEditButton);
            this.Controls.Add(this.RigsEditButton);
            this.Controls.Add(this.DifficultyEditButton);
            this.Controls.Add(this.TrialsEditButton);
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.SavePathTextBox);
            this.Controls.Add(this.PathLabel);
            this.Controls.Add(this.PlayersTextBox);
            this.Controls.Add(this.PlayersLabel);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.TrialTypeComboBox);
            this.Controls.Add(this.TrialTypeLabel);
            this.Font = new System.Drawing.Font("Courier New", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.Name = "Form1";
            this.Text = "Trials Document Creator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TrialTypeLabel;
        private System.Windows.Forms.ComboBox TrialTypeComboBox;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Label PlayersLabel;
        private System.Windows.Forms.TextBox PlayersTextBox;
        private System.Windows.Forms.Label PathLabel;
        private System.Windows.Forms.TextBox SavePathTextBox;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.Button TrialsEditButton;
        private System.Windows.Forms.Button DifficultyEditButton;
        private System.Windows.Forms.Button RigsEditButton;
        private System.Windows.Forms.Button AmphsEditButton;
    }
}

