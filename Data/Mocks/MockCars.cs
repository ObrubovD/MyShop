using MyShop.Data.Interfeces;
using MyShop.Data.Models;

namespace MyShop.Data.Mocks
{
    public class MockCars : IAllCars 
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();
        public IEnumerable<Car> Cars
        {
            get
            {
                return new List<Car>{
                    new Car { Name = "Tesla Model S",
                        ShortDesc = "Быстрый Автомобиль ",
                        LongDesc = "Красивыйц быстрый и очень тихий Автомобиль компании Тесла",
                        Img = " /img/tesla.jpg",
                        price = 45000,
                        IsFavourite = true,
                        Avialable = true,
                        Category=_categoryCars.AllCategories.FirstOrDefault() 
                    },
                    new Car
                    {
                        Name = "Ford Fiesta ",
                        ShortDesc = "Тихий и спокойный",
                        LongDesc = "Удобный Авто для городской жизни",
                        Img = "/img/FordFiesta.jpg",
                        price = 22000,
                        IsFavourite = true,
                        Avialable = true,
                        Category = _categoryCars.AllCategories.Last()
                    },
                    new Car
                    {
                        Name = "BMW 3 ",
                        ShortDesc = "Резвый и дерзкий",
                        LongDesc = "Удобный Авто для городской жизни",
                        Img = "/img/BMW3.jpg",
                        price = 32000,
                        IsFavourite = true,
                        Avialable = true,
                        Category = _categoryCars.AllCategories.Last()
                    },
                };
                
            }
        }
        public IEnumerable<Car> GetFavCars { get; set ; }

        public Car GetObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
