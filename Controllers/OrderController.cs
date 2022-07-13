using Microsoft.AspNetCore.Mvc;
using MyShop.Data.Interfeces;
using MyShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyShop.Controllers
{
    public class OrderController: Controller
    {
        private readonly IAllOrders allOders;
        private readonly ShopCart shopCart;

        public OrderController(IAllOrders allOders, ShopCart shopCart)
        {
            this.allOders = allOders;
            this.shopCart = shopCart;
        }

        public IActionResult Checkout()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            shopCart.listShopItems = shopCart.getShopItems();

            if(shopCart.listShopItems.Count==0)
            {
                ModelState.AddModelError("", "Добавтье товары в корзину");
            }
            if (ModelState.IsValid)
            {
                allOders.createOrder(order);
                return RedirectToAction("Complete");
            }

            return View(order);
        }
        public IActionResult Complete()
        {
            ViewBag.Message = "Заказ успешно обработан";
            return View();
        }
    }
} 
