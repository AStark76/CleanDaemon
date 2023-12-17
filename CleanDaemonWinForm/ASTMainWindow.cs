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
                PreviewListBox.Items.Add($"{item.ToString}|{MonthNumericDropDown.Value.ToString()}");
            }
        }

        private void ASTMainWindow_Load(object sender, EventArgs e)
        {
            string[] drives = DriveInfo
                .GetDrives()
                .Select(drv => $"{drv.Name} - {drv.DriveType}")
                .ToArray();

            DriveComboBox.Items.AddRange(drives);
            DriveComboBox.SelectedIndex = 0;
            string[] directories = 
        }
    }
}
