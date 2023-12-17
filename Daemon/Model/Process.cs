using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daemon.Model
{
    public class Process
    {
        private string _processfile;
        public string ProcessFile => _processfile;
        private bool _isSimulation = false;
        public bool IsSimulation
        {
            get => _isSimulation;
            set
            {
                _isSimulation = value;
            }
        }

        public Process() { }

        public Process(string inDutyFile)
        {
            this._processfile = inDutyFile;
        }
    }
}
