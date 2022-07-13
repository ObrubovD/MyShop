using Microsoft.AspNetCore.Mvc;
using MyShop.Data.Interfeces;
using MyShop.Data.Models;
using MyShop.ViewModels;

namespace MyShop.Controlles
{
    public class CarsController:Controller
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCategory;

        public CarsController(IAllCars iAllCars, ICarsCategory iAllCat)
        {
            _allCars= iAllCars;
            _allCategory= iAllCat;
        }
        [Route("Cars/List")]
        [Route("Cars/List/{category}")]
        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Car> cars = null;
            string currCategory = "";
            if(string.IsNullOrEmpty(category))
            {
                cars = _allCars.Cars.OrderBy(i => i.Id);
            }
            else
            {
                if (string.Equals("electro", category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = _allCars.Cars.Where(i => i.Category.CategotyName.Equals("Электромобили")).OrderBy(i => i.Id);
                    currCategory = "Электромобили";
                }
                else if(string.Equals("fuel", category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = _allCars.Cars.Where(i => i.Category.CategotyName.Equals("Классические автомобили")).OrderBy(i => i.Id);
                    currCategory = "Классические автомобили";  
                }

                
 
            }
            var carObj = new CarsListViewModel
            {
                allCars = cars,
                currCategory = currCategory,
            };
            ViewBag.Title = "Страница с автомобилями";
            return View(carObj);
        }
    }
}
