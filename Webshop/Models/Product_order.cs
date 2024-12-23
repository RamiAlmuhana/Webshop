namespace Webshop.Models
{
    public class product_order
    {
        public int Id { get; set; }
        public Product product_id { get; set; }
        public Order order_id { get; set; }
    }
}
