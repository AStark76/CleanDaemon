namespace CleanDaemonWinForm
{
    partial class ASTMainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MonthLabel1 = new Label();
            MonthNumericDropDown = new NumericUpDown();
            MonthLabel2 = new Label();
            ConfigLabel = new Label();
            PreviewListBox = new ListBox();
            SubDirectoriesCheckBox = new CheckBox();
            saveFileDialog = new SaveFileDialog();
            SaveButton = new Button();
            ResetButton = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            FolderSelectButton = new Button();
            ((System.ComponentModel.ISupportInitialize)MonthNumericDropDown).BeginInit();
            SuspendLayout();
            // 
            // MonthLabel1
            // 
            MonthLabel1.AutoSize = true;
            MonthLabel1.Location = new Point(14, 11);
            MonthLabel1.Name = "MonthLabel1";
            MonthLabel1.Size = new Size(61, 20);
            MonthLabel1.TabIndex = 4;
            MonthLabel1.Text = "älter als";
            // 
            // MonthNumericDropDown
            // 
            MonthNumericDropDown.Location = new Point(14, 34);
            MonthNumericDropDown.Name = "MonthNumericDropDown";
            MonthNumericDropDown.Size = new Size(74, 27);
            MonthNumericDropDown.TabIndex = 5;
            MonthNumericDropDown.Value = new decimal(new int[] { 6, 0, 0, 0 });
            // 
            // MonthLabel2
            // 
            MonthLabel2.AutoSize = true;
            MonthLabel2.Location = new Point(94, 36);
            MonthLabel2.Name = "MonthLabel2";
            MonthLabel2.Size = new Size(60, 20);
            MonthLabel2.TabIndex = 6;
            MonthLabel2.Text = "Monate";
            // 
            // ConfigLabel
            // 
            ConfigLabel.AutoSize = true;
            ConfigLabel.Location = new Point(223, 11);
            ConfigLabel.Name = "ConfigLabel";
            ConfigLabel.Size = new Size(100, 20);
            ConfigLabel.TabIndex = 9;
            ConfigLabel.Text = "Konfiguration";
            // 
            // PreviewListBox
            // 
            PreviewListBox.FormattingEnabled = true;
            PreviewListBox.Location = new Point(223, 46);
            PreviewListBox.Name = "PreviewListBox";
            PreviewListBox.Size = new Size(565, 324);
            PreviewListBox.TabIndex = 8;
            // 
            // SubDirectoriesCheckBox
            // 
            SubDirectoriesCheckBox.AutoSize = true;
            SubDirectoriesCheckBox.Checked = true;
            SubDirectoriesCheckBox.CheckState = CheckState.Checked;
            SubDirectoriesCheckBox.Location = new Point(11, 70);
            SubDirectoriesCheckBox.Name = "SubDirectoriesCheckBox";
            SubDirectoriesCheckBox.Size = new Size(141, 24);
            SubDirectoriesCheckBox.TabIndex = 10;
            SubDirectoriesCheckBox.Text = "inkl. Unterordner";
            SubDirectoriesCheckBox.UseVisualStyleBackColor = true;
            // 
            // saveFileDialog
            // 
            saveFileDialog.DefaultExt = "ASTCD";
            saveFileDialog.Filter = " AST CleanDaemon Files (*.astcd)|*.astcd";
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(522, 399);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(94, 29);
            SaveButton.TabIndex = 11;
            SaveButton.Text = "Speichern";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // ResetButton
            // 
            ResetButton.Location = new Point(396, 399);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(87, 29);
            ResetButton.TabIndex = 12;
            ResetButton.Text = "Neu";
            ResetButton.UseVisualStyleBackColor = true;
            ResetButton.Click += ResetButton_Click;
            // 
            // FolderSelectButton
            // 
            FolderSelectButton.Location = new Point(14, 115);
            FolderSelectButton.Name = "FolderSelectButton";
            FolderSelectButton.Size = new Size(163, 29);
            FolderSelectButton.TabIndex = 13;
            FolderSelectButton.Text = "Verzeichnisse suchen";
            FolderSelectButton.UseVisualStyleBackColor = true;
            FolderSelectButton.Click += FolderSelectButton_Click;
            // 
            // ASTMainWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(FolderSelectButton);
            Controls.Add(ResetButton);
            Controls.Add(SaveButton);
            Controls.Add(SubDirectoriesCheckBox);
            Controls.Add(ConfigLabel);
            Controls.Add(PreviewListBox);
            Controls.Add(MonthLabel2);
            Controls.Add(MonthNumericDropDown);
            Controls.Add(MonthLabel1);
            Name = "ASTMainWindow";
            Text = "AST CleanDaemon";
            ((System.ComponentModel.ISupportInitialize)MonthNumericDropDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label MonthLabel1;
        private NumericUpDown MonthNumericDropDown;
        private Label MonthLabel2;
        private Label ConfigLabel;
        private ListBox PreviewListBox;
        private CheckBox SubDirectoriesCheckBox;
        private SaveFileDialog saveFileDialog;
        private Button SaveButton;
        private Button ResetButton;
        private FolderBrowserDialog folderBrowserDialog1;
        private Button FolderSelectButton;
    }
}
