using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstResponsiveWebAppSoulinthavong.Models;

namespace FirstResponsiveWebAppSoulinthavong.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.AgeThisYear = "";
            return View();
        }
        [HttpPost]
        public IActionResult Index(CalculateAge model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.AgeThisYear = model.AgeThisYear();
            }
            else
            {
                ViewBag.AgeThisYear = "";
            }

            return View(model);
        }
    }
}
