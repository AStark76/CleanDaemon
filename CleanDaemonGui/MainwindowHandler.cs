using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace CleanDaemonGui
{
    internal class MainwindowHandler
    {
        public ComboBox InitDriveCb(ComboBox inComboBox)
        {
            var result = inComboBox;
            result.Items.Clear();
            DriveInfo.GetDrives().Select(drv => result.Items.Add(drv.Name)).ToArray();
            result.SelectedIndex = 1;

            return result;
        }


        public ListBox InitDirectoryListBox(ListBox inListBox, string inDrive)
        {
            var result = inListBox;
            List<string> dirs = new List<string>();
            dirs.AddRange(Directory.GetFiles(inDrive, "*.*"));
            result.Items.Add(dirs);

            return result;
        }
    }
}
