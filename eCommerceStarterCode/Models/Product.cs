using Microsoft.AspNetCore.Identity;

namespace eCommerceStarterCode.Models
{
    public class Product 
    {
        public string ProductName { get; set; }
        public float  Price { get; set; }
        public string Description { get; set; }
        public string Genre { get; set; }
        public string Reviews { get; set; }
        public int    Rating { get; set; }
       
    }
}