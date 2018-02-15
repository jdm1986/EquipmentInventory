using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EquipmentInventory.Models
{
    public class Machine
    {
        public int EquipId { get; set; }
        public string EquipMake { get; set; }
        public string EquipModel { get; set; }
        public int Weight { get; set; }

    }
}