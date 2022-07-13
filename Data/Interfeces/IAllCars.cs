using MyShop.Data.Models;

namespace MyShop.Data.Interfeces
{
    public interface IAllCars
    {
        IEnumerable<Car> Cars { get; }
        IEnumerable<Car> GetFavCars { get;  }
        Car GetObjectCar(int carId);
    }
}
