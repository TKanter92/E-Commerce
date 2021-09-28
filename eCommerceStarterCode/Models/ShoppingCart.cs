using Microsoft.AspNetCore.Identity;

namespace eCommerceStarterCode.Models
{
    public class ShoppingCart : IdentityUser
    {
      public int UserId { get; set; }
      public int ProductId { get; set; }
      public int? Quantity { get; set; }

      
      public virtual  Product Product { get; set; }

      public virtual User User { get; set; }
      
    }
}