namespace MyShop.Data.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortDesc { get; set; }
        public string LongDesc   { get; set; }
        public string Img { get; set; }
        public int price { get; set; }
        public bool IsFavourite { get; set; }
        public bool Avialable { get;set; }
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}
