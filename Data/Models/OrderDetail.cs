namespace MyShop.Data.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int CarId { get; set; }
        public int Price { get; set; }
        public virtual Car car { get; set; }
        public virtual Order order { get; set; }
        
    }
}
