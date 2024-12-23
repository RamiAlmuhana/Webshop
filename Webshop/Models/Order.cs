namespace Webshop.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string city { get; set; }
        public string houseNumber { get; set; }
        public string zipcode { get; set; }
        public string notes { get; set; }
        public DateTime orderDate { get; set; }
        public User user_id { get; set; }
    }
}
