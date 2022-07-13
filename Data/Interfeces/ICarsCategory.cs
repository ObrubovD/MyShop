using MyShop.Data.Models;
namespace MyShop.Data.Interfeces
{
    public interface ICarsCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
