using CleanDaemonWinForm.Model;
using System.DirectoryServices;

namespace CleanDaemonWinForm
{
    public partial class ASTMainWindow : Form
    {
        public ASTMainWindow()
        {
            InitializeComponent();
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            foreach (var item in DirectoryListBox.SelectedItems)
            {
                PreviewListBox.Items.Add($"{item.ToString}|{MonthNumericDropDown.Value.ToString()}|{SubDirectoriesCheckBox.Checked}");
            }
        }

        private void ASTMainWindow_Load(object sender, EventArgs e)
        {
            DriveItem[] drives = DriveInfo
                .GetDrives()
                .Select(drv => new DriveItem(drv))
                .ToArray();
            DriveComboBox.Items.AddRange(drives);
            DriveComboBox.SelectedIndex = 0;
        }

        private void DriveComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string drive = (DriveComboBox.SelectedItem as DriveItem).Drive;
            SetDirectories(drive);
        }

        private void SetDirectories(object selectedText)
        {
            DirectoryListBox.Items.Clear();
            string drive = (selectedText as string).Split('-')[0].Trim() ?? "c:\\";
            string[] directories = Directory.GetDirectories(drive);
            DirectoryListBox.Items.AddRange(directories);
        }
    }
}
