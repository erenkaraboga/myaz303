using Microsoft.Extensions.Hosting;
using System.ComponentModel;

namespace myaz303.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        [DisplayName("Customer Name")]
        public string CustomerName { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
