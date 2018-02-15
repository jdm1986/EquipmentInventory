using EquipmentInventory.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace EquipmentInventory.Controllers
{
    public class MachineController : Controller
    {
        public static List<Machine> Machines = new List<Machine>
                    {
                        new Machine { EquipId = 1, EquipMake = "CAT", EquipModel = "D8"},
                        new Machine { EquipId = 2, EquipMake = "CAT", EquipModel = "D5K LGP"},
                        new Machine { EquipId = 3, EquipMake = "CAT", EquipModel = "420E IT"},
                        new Machine { EquipId = 4, EquipMake = "Deere", EquipModel = "250G"},
                        new Machine { EquipId = 5, EquipMake = "Deere", EquipModel = "9520"},
                        new Machine { EquipId = 6, EquipMake = "Deere", EquipModel = "1810"},
                        new Machine { EquipId = 7, EquipMake = "Takeuchi", EquipModel = "TB1140"},
                        new Machine { EquipId = 8, EquipMake = "Takeuchi", EquipModel = "TB290"},
                        new Machine { EquipId = 9, EquipMake = "Takeuchi", EquipModel = "TL10"},
                    };

        public ActionResult Index()
        {
            var machineList = new MachineListViewModel
            {
                
                Machines = Machines.Select(m => new MachineViewModel
                {
                    EquipId = m.EquipId,
                    EquipMake = m.EquipMake,
                    EquipModel = m.EquipModel
                }).ToList()
            };

            machineList.TotalMachines = machineList.Machines.Count;

            return View(machineList);
        }

        public ActionResult MachineDetail(int id)
        {
            var machine = Machines.SingleOrDefault(m => m.EquipId == id);
            if (machine != null)
            {
                var machineViewModel = new MachineViewModel
                {
                    EquipId = machine.EquipId,
                    EquipMake = machine.EquipMake,
                    EquipModel = machine.EquipModel
                };

                return View(machineViewModel);
            }

            return new HttpNotFoundResult();
        }

        public ActionResult MachineAdd()
        {
            var machineViewModel = new MachineViewModel();

            return View("AddEditMachine", machineViewModel);
        }

        [HttpPost]
        public ActionResult AddMachine(MachineViewModel machineViewModel)
        {
            var nextMachineId = Machines.Max(m => m.EquipId) + 1;

            var machine = new Machine
            {
                EquipId = nextMachineId,
                EquipMake = machineViewModel.EquipMake,
                EquipModel = machineViewModel.EquipModel
            };

            Machines.Add(machine);

            return RedirectToAction("Index");
        }

        public ActionResult MachineEdit(int id)
        {
            var machine = Machines.SingleOrDefault(m => m.EquipId == id);
            if (machine != null)
            {
                var machineViewModel = new MachineViewModel
                {
                    EquipId = machine.EquipId,
                    EquipMake = machine.EquipMake,
                    EquipModel = machine.EquipModel
                };

                return View("AddEditMachine", machineViewModel);
            }

            return new HttpNotFoundResult();
        }

        [HttpPost]
        public ActionResult EditMachine(MachineViewModel machineViewModel)
        {
            var machine = Machines.SingleOrDefault(m => m.EquipId == machineViewModel.EquipId);

            if (machine != null)
            {
                machine.EquipMake = machineViewModel.EquipMake;
                machine.EquipMake = machineViewModel.EquipModel;

                return RedirectToAction("Index");
            }

            return new HttpNotFoundResult();
        }

        [HttpPost]
        public ActionResult DeleteMachine(MachineViewModel machineViewModel)
        {
            var machine = Machines.SingleOrDefault(m => m.EquipId == machineViewModel.EquipId);

            if (machine != null)
            {
                Machines.Remove(machine);

                return RedirectToAction("Index");
            }

            return new HttpNotFoundResult();
        }
    }
}