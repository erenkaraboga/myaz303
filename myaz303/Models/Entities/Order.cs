namespace myaz303.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }

        public OrderDetail OrderDetail { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
