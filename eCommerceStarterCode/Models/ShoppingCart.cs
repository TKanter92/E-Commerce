using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eCommerceStarterCode.Models
{
    public class ShoppingCart
    {
        
      [Key]
      public int ShoppingCartId { get; set; }

      [ForeignKey("Product")]
      public int ProductId { get; set; }
      public Product Product { get; set; }

      public int? Quantity { get; set; }

        

      [ForeignKey("Customer")]
      public string CustomerId { get; set; }

      public Customer Customer { get; set; }

    }
}