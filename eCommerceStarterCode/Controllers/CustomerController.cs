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
    public class CustomerController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public CustomerController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult GetAllUsers(int Id)
        {
            var Customer = _context.Customers;
            return Ok(Customer);
        }
        [HttpGet("{Id}")]
        public IActionResult GetSingleUser(int Id)
        {
            var Customer = _context.Customers.Find(Id);
            return Ok(Customer);
        }

        [HttpPost]

        public IActionResult Post([FromBody] Customer value)
        {
            _context.Customers.Add(value);
            _context.SaveChanges();
            return StatusCode(201, value);
        }



        [HttpDelete("{Id}")]
        public IActionResult DeleteSingleUser(Customer user)
        {
            var Customer = _context.Customers.Remove(user);
            return Ok(Customer);
        }

    }
}

