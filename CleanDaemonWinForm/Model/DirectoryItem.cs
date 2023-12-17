using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanDaemonWinForm.Model
{
    public class DirectoryItem
    {
        private string _path;
        private string _name;

        public DirectoryItem(DirectoryInfo inDirectoryInfo)
        {
            _path = inDirectoryInfo.FullName;
            _name = inDirectoryInfo.Name;
        }

        public override string ToString() => _path;
    }
}
