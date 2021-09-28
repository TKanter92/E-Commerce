using Microsoft.AspNetCore.Identity;

namespace eCommerceStarterCode.Models
{
    public class Customer 
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StreetAddress { get; set;}
        public string City {get; set;}
        public string State { get; set;}
        public int ZipCode {get; set;}
        public string Password { get; set;}



    }
}
