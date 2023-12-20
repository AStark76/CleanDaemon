using CleanDaemonWinForm.Model;
using System.DirectoryServices;
using System.Text;

namespace CleanDaemonWinForm
{
    public partial class ASTMainWindow : Form
    {
        public ASTMainWindow()
        {
            InitializeComponent();
        }
        private void SetDirectories(object selectedText)
        {
            string drive = (selectedText as string).Split('-')[0].Trim() ?? "c:\\";
            DirectoryItem[] directories = Directory.GetDirectories(drive)
                .Select(dir => new DirectoryItem(new DirectoryInfo(dir)))
                .ToArray();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            PreviewListBox.Items.Clear();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = saveFileDialog.ShowDialog();
            if (DialogResult.OK == dialogResult)
            {
                string fileName = saveFileDialog.FileName;
                StringBuilder sb = new StringBuilder();
                foreach (var item in PreviewListBox.Items)
                {
                    string line = item as string;
                    sb.AppendLine(line);
                }

                File.WriteAllText(fileName, sb.ToString());
            }
        }

        private void FolderSelectButton_Click(object sender, EventArgs e)
        {
            if(DialogResult.OK == folderBrowserDialog1.ShowDialog())
            {
                string selectedFolder = folderBrowserDialog1.SelectedPath;
                PreviewListBox.Items.Add($"{selectedFolder}|{MonthNumericDropDown.Value}" +
                    $"|{SubDirectoriesCheckBox.Checked}|{DeleteEmptySubFolderCheckBox}");
            }
        }
    }
}
