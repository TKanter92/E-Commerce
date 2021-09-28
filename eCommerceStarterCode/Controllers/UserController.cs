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
    public class UserController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public UserController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult GetAllUsers(int Id)
        {
            var User = _context.User;
            return Ok(User);
        }
        [HttpGet("{Id}")]
        public IActionResult GetSingleUser(int Id)
        {
            var User = _context.User.Find(Id);
            return Ok(User);
        }

        [HttpPost]

        public IActionResult Post([FromBody] User value)
        {
            _context.User.Add(value);
            _context.SaveChanges();
            return StatusCode(201, value);
        }



        [HttpDelete("{Id}")]
        public IActionResult DeleteSingleUser(User user)
        {
            var User = _context.User.Remove(user);
            return Ok(User);
        }

    }
}

