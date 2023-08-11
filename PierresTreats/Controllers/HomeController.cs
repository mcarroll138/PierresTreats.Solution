using System.Diagnostics;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;
using PierresTreats.Models;
using System.Collections.Generic;
using System.Linq;

namespace PierresTreats.Controllers
{
    // public class HomeController : Controller
    // {
    //     private readonly PierresTreatsContext _db;
    //     public HomeController(PierresTreatsContext db)
    //     {
    //         _db = db;
    //     }
     [HttpGet("/")]
    {
        // List<Engineer> engineers = _db.Engineers.ToList();
        // List<Machine> machines = _db.Machines.ToList();
        // ViewBag.Engineers = engineers;
        // ViewBag.Machines = machines;
        return View();
}
}
