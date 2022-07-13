using MyShop.Data.Interfeces;
using MyShop.ViewModels;
using Microsoft.AspNetCore.Mvc;


namespace MyShop.Controllers
{
    public class HomeController:Controller
    {
        private IAllCars _carRep;


        public HomeController(IAllCars carRep)
        {
            _carRep = carRep;
        }
        public ViewResult Index()
        {
            var homeCars = new HomeViewModel
            {
                favCars = _carRep.GetFavCars
            };
            return View(homeCars);
        }
    }
}
