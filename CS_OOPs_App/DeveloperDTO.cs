using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_OOPs_App
{
    class DeveloperDTO : EmployeeDTO
    {
        public int HRA { get; set; }
        public int OverTimeBonus { get; set; }
        public int TA { get; set; }
        public int DA { get; set; }
        public int TaskBonus { get; set; } 
    }
}
