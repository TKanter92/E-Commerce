using Microsoft.AspNetCore.Identity;


namespace eCommerceStarterCode.Models
{
    public class User : IdentityUser
    {
        //User is IdentityUser
        public string FirstName { get; set; }
        public string LastName { get; set; }
      
    }
}
