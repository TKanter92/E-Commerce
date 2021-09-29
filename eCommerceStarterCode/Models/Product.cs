using Microsoft.AspNetCore.Identity;

namespace eCommerceStarterCode.Models
{
    public class Product 
    {
        private float price = 0;
        private int rating = 0;
        public int    ProductId { get; set; }
        public string ProductName { get; set; }
        public string Artist { get; set; }
        public float  Price { 
            get { return price; } 
            set {
                if (price < 0) { price = 0; }
                else{price = value;}
            }
        }
        public string Description { get; set; }
        public string Genre { get; set; }
        public int    Rating {
            get { return rating; } 
            set {
                if (rating < 0) { rating = 0;}
                else if(rating > 5){ rating = 5;}
                else{ rating = value; }
            } 
        }
       
    }
}