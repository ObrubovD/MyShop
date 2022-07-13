using MyShop.Data.Models;

namespace MyShop.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {
            if (!content.Category.Any())
                content.Category.AddRange(Categories.Select(c => c.Value));

            if (!content.Car.Any())
            {
                content.AddRange(
                    new Car
                    {
                        Name = "Tesla Model S",
                        ShortDesc = "Быстрый Автомобиль ",
                        LongDesc = "Красивыйц быстрый и очень тихий Автомобиль компании Тесла",
                        Img = " /img/tesla.jpg",
                        price = 45000,
                        IsFavourite = true,
                        Avialable = true,
                        Category = Categories["Электромобили"]
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
                        Category =Categories["Классические автомобили"]
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
                        Category = Categories["Классические автомобили"]
                    }
                    );
            }
            content.SaveChanges();
        }
        private static Dictionary<string, Category> category;
        public static Dictionary<string,Category> Categories
        {
            get
            {
                if(category == null)
                {
                    var list = new Category[]
                    {
                        new Category { CategotyName="Электромобили", Desc="Современный вид транспорта"},
                        new Category{CategotyName="Классические автомобили", Desc="Машины с двигателем внутреннего сгорания"}
                    };
                    category = new Dictionary<string, Category>();
                    foreach (Category el in list)
                        category.Add(el.CategotyName, el);
                }
                return category;
            }
        }
        
    }
}
