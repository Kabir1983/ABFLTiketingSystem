using System.ComponentModel.DataAnnotations;

namespace ProductInfoApp.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public decimal StockQty { get; set; }
        public string ProductDescription { get; set; } 
        public string ProductCategory { get; set; }

    }
}
