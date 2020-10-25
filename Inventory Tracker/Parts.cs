using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Tracker
{
    class Parts
    {
        public string PartNumber { get; set; } = "";
        public string SerialNumber { get; set; } = "";
        public string Status { get; set; } = "Allocated";
        public string TechName { get; set; } = "Not Required";

        public Parts()
        {
            // Intentonally Blank
        }
    } 
}
