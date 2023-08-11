using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using PierresTreats.Models;
using System.Collections.Generic;
using System.Linq;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;

namespace PierresTreats.Controllers
{
    public class FlavorsController : Controller
    {
        private readonly PierresTreatsContext _db;

        public FlavorsController(PierresTreatsContext db)
        {
            _db = db;
        }


        public ActionResult Index()
        {
            return View(_db.Flavors.ToList());
        }
        public ActionResult Details(int id)
        {
            Flavor thisFlavor = _db.Flavors
                                        .Include(flavor => flavor.JoinEntities)
                                        .ThenInclude(join => join.Treat)
                                        .FirstOrDefault(flavor => flavor.FlavorId == id);
            return View(thisFlavor);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Flavor flavor)
        {
            if (!ModelState.IsValid)
            {
                return View(flavor);
            }
            else
            {
                _db.Flavors.Add(flavor);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
        }

        // public ActionResult AddTreat(int id)
        // {
        //     Flavor thisFlavor = _db.Flavors.FirstOrDefault(flavor => flavor.FlavorId == id);
        //     ViewBag.TreatId = new SelectList(_db.Treats, "TreatId", "Description");
        //     return View(thisFlavor);
        // }
        //         [HttpPost]
        //         public ActionResult AddTreat(Flavor flavor, int treatId)
        //         {
        // #nullable enable
        //             FlavorTreat? joinEntity = _db.FlavorTreat.FirstOrDefault(join => (join.TreatId == treatId && join.FlavorId == flavor.FlavorId));
        // #nullable disable
        //             if (joinEntity == null && treatId != 0)//check here? is not or is?
        //             {
        //                 _db.FlavorTreats.Add(new FlavorTreat() { TreatId = treatId, FlavorId = flavor.FlavorId });
        //                 _db.SaveChanges();
        //             }
        //             return RedirectToAction("Details", new { id = flavor.FlavorId });
        //         }

        public ActionResult Edit(int id)
        {
            Flavor thisFlavor = _db.Flavors.FirstOrDefault(flavor => flavor.FlavorId == id);
            return View(thisFlavor);
        }

        [HttpPost]
        public ActionResult Edit(Flavor flavor)
        {
            _db.Flavors.Update(flavor);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            Flavor thisFlavor = _db.Flavors.FirstOrDefault(flavor => flavor.FlavorId == id);
            return View(thisFlavor);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Flavor thisFlavor = _db.Flavors.FirstOrDefault(flavor => flavor.FlavorId == id);
            _db.Flavors.Remove(thisFlavor);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        // [HttpPost]
        // public ActionResult DeleteJoin(int joinId)
        // {
        //     FlavorTreat joinEntry = _db.FlavorTreats.FirstOrDefault(entry => entry.FlavorTreatId == joinId);
        //     _db.FlavorTreats.Remove(joinEntry);
        //     _db.SaveChanges();
        //     return RedirectToAction("Index");
        // }
    }
}