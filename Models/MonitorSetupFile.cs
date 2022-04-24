using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuxiliarySensors.Models
{
    public class MonitorSetupFile
    {
        public string Name { get; set; }
        public string FullName { get; set; }

        public string Contents { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
