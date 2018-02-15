using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EquipmentInventory.Models;


namespace EquipmentInventory.Controllers
{
    public class MachineController : Controller
    {
        // GET: Machine
        public ActionResult Index()
        {
            var machineList = new MachineListViewModel
            {
                Machines = new List<MachineViewModel>
                {
                    new MachineViewModel { EquipId = 1, EquipMake = "CAT", EquipModel = "D8"},
                    new MachineViewModel { EquipId = 2, EquipMake = "CAT", EquipModel = "D5K LGP"},
                    new MachineViewModel { EquipId = 3, EquipMake = "CAT", EquipModel = "420E IT"},
                    new MachineViewModel { EquipId = 4, EquipMake = "Deere", EquipModel = "250G"},
                    new MachineViewModel { EquipId = 5, EquipMake = "Deere", EquipModel = "9520"},
                    new MachineViewModel { EquipId = 6, EquipMake = "Deere", EquipModel = "1810"},
                    new MachineViewModel { EquipId = 7, EquipMake = "Takeuchi", EquipModel = "TB1140"},
                    new MachineViewModel { EquipId = 8, EquipMake = "Takeuchi", EquipModel = "TB290"},
                    new MachineViewModel { EquipId = 9, EquipMake = "Takeuchi", EquipModel = "TL10"},

                }
            };
            machineList.TotalMachines = machineList.Machines.Count;

            return View(machineList);
        }
    }
}