using System.Diagnostics;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;
using PierresTreats.Models;
using System.Collections.Generic;
using System.Linq;

namespace PierresTreats.Controllers
{
    public class HomeController : Controller
    {



        public ActionResult Index()
        {
            return View();
        }
    }
}
