using eCommerceStarterCode.Data;
using eCommerceStarterCode.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerceStarterCode.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public CartController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult GetAllCart(int Id)
        {
            var shoppingCart = _context.ShoppingCarts;
            return Ok(shoppingCart);
        }
        [HttpGet("{Id}")]
        public IActionResult GetSingleCart(int Id)
        {
            var shoppingCart = _context.ShoppingCarts.Find(Id);
            return Ok(shoppingCart);
        }

        [HttpPost]

        public IActionResult Post([FromBody]ShoppingCart value)
        {
             _context.ShoppingCarts.Add(value);
             _context.SaveChanges();
             return StatusCode(201, value);
        }
          


        [HttpDelete("{Id}")]
        public IActionResult DeleteSingleCart(ShoppingCart cart)
        {
            var shoppingCart = _context.ShoppingCarts.Remove(cart);
            return Ok(shoppingCart);



        }

    }
}
