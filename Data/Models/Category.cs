namespace MyShop.Data.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string CategotyName { get; set; }
        public string Desc { get; set; }
        public List<Car> cars { get; set; }

    }
}
