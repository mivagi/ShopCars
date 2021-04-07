using Microsoft.AspNetCore.Mvc;
using ShopCars.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopCars.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAllCars allCars;

        public HomeController(IAllCars allCars)
        {
            this.allCars = allCars;
        }
        public IActionResult Index()
        {
            return View(allCars.Cars);
        }
    }
}
