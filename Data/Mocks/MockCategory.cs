using MyShop.Data.Interfeces;
using MyShop.Data.Models;

namespace MyShop.Data.Mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category { CategotyName = "Электромобиль", Desc = "Современный вид транспорта " },
                    new Category { CategotyName = "Классические автомобили", Desc = "Машины с двигателем внутреннего сгорания" }
                };
            }
        }
    }
}
