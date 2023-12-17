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
            DriveLabel = new Label();
            DriveComboBox = new ComboBox();
            DirectoryLabel = new Label();
            DirectoryListBox = new ListBox();
            MonthLabel1 = new Label();
            MonthNumericDropDown = new NumericUpDown();
            MonthLabel2 = new Label();
            SelectButton = new Button();
            ConfigLabel = new Label();
            PreviewListBox = new ListBox();
            SubDirectoriesCheckBox = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)MonthNumericDropDown).BeginInit();
            SuspendLayout();
            // 
            // DriveLabel
            // 
            DriveLabel.AutoSize = true;
            DriveLabel.Location = new Point(15, 17);
            DriveLabel.Name = "DriveLabel";
            DriveLabel.Size = new Size(76, 20);
            DriveLabel.TabIndex = 0;
            DriveLabel.Text = "Laufwerke";
            // 
            // DriveComboBox
            // 
            DriveComboBox.FormattingEnabled = true;
            DriveComboBox.Location = new Point(15, 40);
            DriveComboBox.Name = "DriveComboBox";
            DriveComboBox.Size = new Size(151, 28);
            DriveComboBox.TabIndex = 1;
            DriveComboBox.SelectedIndexChanged += DriveComboBox_SelectedIndexChanged;
            // 
            // DirectoryLabel
            // 
            DirectoryLabel.AutoSize = true;
            DirectoryLabel.Location = new Point(15, 81);
            DirectoryLabel.Name = "DirectoryLabel";
            DirectoryLabel.Size = new Size(96, 20);
            DirectoryLabel.TabIndex = 2;
            DirectoryLabel.Text = "Verzeichnisse";
            // 
            // DirectoryListBox
            // 
            DirectoryListBox.FormattingEnabled = true;
            DirectoryListBox.Location = new Point(15, 104);
            DirectoryListBox.Name = "DirectoryListBox";
            DirectoryListBox.Size = new Size(214, 324);
            DirectoryListBox.TabIndex = 3;
            // 
            // MonthLabel1
            // 
            MonthLabel1.AutoSize = true;
            MonthLabel1.Location = new Point(235, 19);
            MonthLabel1.Name = "MonthLabel1";
            MonthLabel1.Size = new Size(61, 20);
            MonthLabel1.TabIndex = 4;
            MonthLabel1.Text = "älter als";
            // 
            // MonthNumericDropDown
            // 
            MonthNumericDropDown.Location = new Point(235, 42);
            MonthNumericDropDown.Name = "MonthNumericDropDown";
            MonthNumericDropDown.Size = new Size(74, 27);
            MonthNumericDropDown.TabIndex = 5;
            MonthNumericDropDown.Value = new decimal(new int[] { 6, 0, 0, 0 });
            // 
            // MonthLabel2
            // 
            MonthLabel2.AutoSize = true;
            MonthLabel2.Location = new Point(315, 44);
            MonthLabel2.Name = "MonthLabel2";
            MonthLabel2.Size = new Size(60, 20);
            MonthLabel2.TabIndex = 6;
            MonthLabel2.Text = "Monate";
            // 
            // SelectButton
            // 
            SelectButton.Location = new Point(261, 243);
            SelectButton.Name = "SelectButton";
            SelectButton.Size = new Size(94, 29);
            SelectButton.TabIndex = 7;
            SelectButton.Text = "Übernehmen";
            SelectButton.UseVisualStyleBackColor = true;
            SelectButton.Click += SelectButton_Click;
            // 
            // ConfigLabel
            // 
            ConfigLabel.AutoSize = true;
            ConfigLabel.Location = new Point(396, 17);
            ConfigLabel.Name = "ConfigLabel";
            ConfigLabel.Size = new Size(100, 20);
            ConfigLabel.TabIndex = 9;
            ConfigLabel.Text = "Konfiguration";
            // 
            // PreviewListBox
            // 
            PreviewListBox.FormattingEnabled = true;
            PreviewListBox.Location = new Point(396, 46);
            PreviewListBox.Name = "PreviewListBox";
            PreviewListBox.Size = new Size(392, 324);
            PreviewListBox.TabIndex = 8;
            // 
            // SubDirectoriesCheckBox
            // 
            SubDirectoriesCheckBox.AutoSize = true;
            SubDirectoriesCheckBox.Checked = true;
            SubDirectoriesCheckBox.CheckState = CheckState.Checked;
            SubDirectoriesCheckBox.Location = new Point(232, 78);
            SubDirectoriesCheckBox.Name = "SubDirectoriesCheckBox";
            SubDirectoriesCheckBox.Size = new Size(141, 24);
            SubDirectoriesCheckBox.TabIndex = 10;
            SubDirectoriesCheckBox.Text = "inkl. Unterordner";
            SubDirectoriesCheckBox.UseVisualStyleBackColor = true;
            // 
            // ASTMainWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SubDirectoriesCheckBox);
            Controls.Add(ConfigLabel);
            Controls.Add(PreviewListBox);
            Controls.Add(SelectButton);
            Controls.Add(MonthLabel2);
            Controls.Add(MonthNumericDropDown);
            Controls.Add(MonthLabel1);
            Controls.Add(DirectoryListBox);
            Controls.Add(DirectoryLabel);
            Controls.Add(DriveComboBox);
            Controls.Add(DriveLabel);
            Name = "ASTMainWindow";
            Text = "AST CleanDaemon";
            Load += ASTMainWindow_Load;
            ((System.ComponentModel.ISupportInitialize)MonthNumericDropDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label DriveLabel;
        private ComboBox DriveComboBox;
        private Label DirectoryLabel;
        private ListBox DirectoryListBox;
        private Label MonthLabel1;
        private NumericUpDown MonthNumericDropDown;
        private Label MonthLabel2;
        private Button SelectButton;
        private Label ConfigLabel;
        private ListBox PreviewListBox;
        private CheckBox SubDirectoriesCheckBox;
    }
}
