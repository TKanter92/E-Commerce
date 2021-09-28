using eCommerceStarterCode.Data;
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
            var shoppingCart = _context.ShoppingCart;
            return Ok(shoppingCart);
        }
        [HttpGet("{Id}")]
        public IActionResult GetSingleCart(int Id)
        {
            var shoppingCart = _context.ShoppingCart.Find(Id);
            return Ok(shoppingCart);
        }

        [HttpPost]

        public IActionResult Post([FromBody]ShoppingCart value)
        {
             _context.ShoppingCart.Add(value);
             _context.SaveChanges();
             return StatusCode(201, value);
        }
          


        [HttpDelete("{Id}")]
        public IActionResult DeleteSingleCart(int Id)
        {
            var shoppingCart = _context.ShoppingCart.Remove(Id);
            return Ok(shoppingCart);



        }

    }
}
