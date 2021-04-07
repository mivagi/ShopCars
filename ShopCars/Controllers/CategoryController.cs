using Microsoft.AspNetCore.Mvc;
using ShopCars.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopCars.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IAllCars allCars;

        public CategoryController(IAllCars allCars)
        {
            this.allCars = allCars;
        }
        [Route("/Category/List")]
        [Route("/Category/List/{category}")]
        public IActionResult List(string category)
        {
            if (!string.IsNullOrEmpty(category))
            {
                if (string.Equals("electro", category))
                {
                    var cars = allCars.Category.Where(p => p.Category.Name.Equals("electro"));
                    return View(cars);
                }
                else if (string.Equals("fuil", category))
                {
                    var cars = allCars.Category.Where(p => p.Category.Name.Equals("fuil"));
                    return View(cars);
                }
            }

            return RedirectToAction("Index", "Home");
        }
    }
}
