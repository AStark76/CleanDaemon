using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanDaemonWinForm.Model
{
    public class DriveItem
    {
        private string _drive = @"c:\";
        public string Drive => _drive;
        private string _driveType;

        public DriveItem(DriveInfo inDriveInfo)
        {
            _drive = inDriveInfo.Name;
            _driveType = inDriveInfo.DriveType.ToString();
        }

        public override string ToString() => $"{_drive} - {_driveType}";
    }
}
