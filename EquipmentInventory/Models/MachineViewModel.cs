using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace EquipmentInventory.Models
{
    public class MachineViewModel
    {
        public int? EquipId { get; set; }

        [DisplayName("Make")]
        public string EquipMake { get; set; }
        [DisplayName("Model")]
        public string EquipModel { get; set; }
        [DisplayName("Weight")]
        public int? Weight { get; set; }

        [DisplayName("Make and Model")]
        public string MakeModel => EquipMake + " " + EquipModel;
    }
}