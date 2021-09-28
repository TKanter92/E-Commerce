using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace eCommerceStarterCode.Models
{
    public class ShoppingCart
    {
      public int UserId { get; set; }
      public int ProductId { get; set; }
      public int? Quantity { get; set; }

      [ForeignKey("IdentityUser")]
      public string IdentityUserId { get; set; }

      public IdentityUser IdentityUser { get; set; }

    }
}