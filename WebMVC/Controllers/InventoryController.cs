using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebMVC.Models;

namespace WebMVC.Controllers
{
    public class InventoryController : Controller
    {
        private static List<InventoryViewModel> _inventoryViewModels = new List<InventoryViewModel>()
        {
            new InventoryViewModel(2, "Coba02", "I3 Len", 2001),
            new InventoryViewModel(3, "Coba03", "I3 Len", 2001),
            new InventoryViewModel(4, "Mie Goreng Telor", "I3 Len", 2001),
        };

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Save([Bind("Id, Name, Merk, Tahun")] InventoryViewModel inventory)
        {
            _inventoryViewModels.Add(inventory);
            return Redirect("List");
        }

        public IActionResult List()
        {
            return View(_inventoryViewModels);
        }

        public IActionResult Edit(int? id)
        {
            // find with lambda
            InventoryViewModel inventory = _inventoryViewModels.Find(x => x.Id.Equals(id));
            return View(inventory);
        }

        [HttpPost]
        public IActionResult Update(int id, [Bind("Id, Name, Merk, Tahun")] InventoryViewModel inventory)
        {
            // hapus data lama
            InventoryViewModel inventoryOld = _inventoryViewModels.Find(x => x.Id.Equals(id));
            _inventoryViewModels.Remove(inventoryOld);

            // input data baru
            _inventoryViewModels.Add(inventory);
            return Redirect("List");
        }

        public IActionResult Details(int id)
        {
            // find with linq
            InventoryViewModel inventory = (
                    from p in _inventoryViewModels
                    where p.Id.Equals(id)
                    select p
                ).SingleOrDefault(new InventoryViewModel());
            return View(inventory);
        }

        public IActionResult Delete(int? id)
        {
            // find data dulu
            InventoryViewModel inventory = _inventoryViewModels.Find(x => x.Id.Equals(id));
            // remove from list
            _inventoryViewModels.Remove(inventory);

            return Redirect("List");
        }
    }
}
