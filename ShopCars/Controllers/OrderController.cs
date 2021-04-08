using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ShopCars.Data.Interfaces;
using ShopCars.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopCars.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrders orderRep;
        private readonly Cart cart;

        public OrderController(IOrders orderRep, Cart cart)
        {
            this.orderRep = orderRep;
            this.cart = cart;
        }
        [Authorize]
        public IActionResult List()
        {
            return View(orderRep.GetAllOrders);
        }
        public IActionResult Checkout()
        {
            return View(new Order());
        }
        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            if (ModelState.IsValid)
            {
                orderRep.SaveOrder(order);
                return RedirectToAction("Complete");
            }
            return View(order);
        }
        public IActionResult Complete()
        {
            cart.ClearCart();
            return View();
        }
        [HttpPost]
        public IActionResult DeleteOrder(int id)
        {
            orderRep.DeleteOrder(id);
            return RedirectToAction("List");
        }
    }
}
