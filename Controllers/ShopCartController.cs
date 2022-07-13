using MyShop.Data.Models;
using Microsoft.AspNetCore.Mvc;
using MyShop.ViewModels;
using MyShop.Data.Interfeces;

namespace MyShop.Controllers
{
    public class ShopCartController:Controller
    {
        private IAllCars _carRep;
       
        private readonly ShopCart _shopCart;

        public ShopCartController(IAllCars carRep,ShopCart shopCart)
        {
            _carRep = carRep;
            _shopCart=shopCart;
        }
        public ViewResult Index()
        {
            var items = _shopCart.getShopItems();
            _shopCart.listShopItems=items;

            var obj = new ShopCartViewModel
            {
                shopCart = _shopCart
            }; 
            return View(obj);
        }
        public RedirectToActionResult addToCart(int id)
        {
            var item=_carRep.Cars.FirstOrDefault(i=>i.Id==id);
            if(item != null)
            {
                _shopCart.AddToCart(item);
            }
            return RedirectToAction("Index");
        }
    }
}
