using MyShop.Data.Models;
using System.Web.Mvc;

namespace MyShop.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Car> favCars { get; set; }
    }
}
