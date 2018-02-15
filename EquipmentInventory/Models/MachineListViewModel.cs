using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EquipmentInventory.Models
{
    public class MachineListViewModel
    {
        public List<MachineViewModel> Machines { get; set; }
        public int TotalMachines { get; set; }
    }
}