using System.ComponentModel.DataAnnotations.Schema;

namespace myaz303.Models
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }
        [NotMapped]
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public DateTime CreatedDate { get; set; }
        public double TotalPrice { get; set; }
     
    }
}
