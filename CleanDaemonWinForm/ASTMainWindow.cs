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

        /// <summary>
        /// Resets the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetButton_Click(object sender, EventArgs e)
        {
            PreviewListBox.Items.Clear();
            SubDirectoriesCheckBox.Checked = true;
            DeleteEmptySubFolderCheckBox.Checked = false;
        }

        /// <summary>
        /// Stores the collected information in a task file-ASTCD. File is humanfriendly
        /// readable
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Let the user select a dirctionary and than gathers all the 
        /// information from the form and stores it as a string.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
