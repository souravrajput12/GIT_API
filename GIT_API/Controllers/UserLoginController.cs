
using GIT_API.Data;
using GIT_API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GIT_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserLoginController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public UserLoginController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Post([FromBody] UserLogin model)
        {
            if (model == null || string.IsNullOrWhiteSpace(model.UserName) || string.IsNullOrWhiteSpace(model.UserPassword))
            {
                return BadRequest("Username or Password cannot be empty.");
            }

            var existingUser = _context.UserLogins.FirstOrDefault(u => u.UserName == model.UserName);

            if (existingUser != null)
            {
                return Conflict("Username already exists.");
            }

            
            _context.UserLogins.Add(model);
            _context.SaveChanges();

           
            return Ok("User created successfully.");
        }
    }
}









