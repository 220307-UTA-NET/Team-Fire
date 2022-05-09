using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project2EntityFramework.Models;

namespace Project2EntityFramework.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly SunCardBackend2Context _context;

        public LoginController(SunCardBackend2Context context)
        {
            _context = context;
        }

        [HttpGet("customers")]
        public IActionResult GetCustomers()
        {
            var customerDetails = _context.CustomerLists.AsQueryable();
            return Ok(customerDetails);
        }

        [HttpPost("register")]
        public IActionResult Register([FromBody] Customer customerObj)
        {
            if(customerObj == null)
            {
                return BadRequest();
            }
            else
            {
                _context.CustomerLists.Add(customerObj);
                _context.SaveChanges();
                return Ok(new
                {
                    StatusCode = 200,
                    Message = "Customer Registered Successfully"
                });                
            }
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] Customer customerObj)
        {
            if(customerObj == null)
            {
                return BadRequest();
            }
            else
            {
                var user = _context.CustomerLists.Where(a =>
                a.FirstName == customerObj.FirstName 
                && a.LastName == customerObj.LastName
                && a.PWord == customerObj.PWord).FirstOrDefault();
                if(user != null)
                {
                    return Ok(new
                    {
                        StatusCode = 200,
                        Message= "Logged In Successfully"
                    });                    
                }
                else
                {
                    return NotFound(new
                    {
                        StatusCode = 404,
                        Message = "User Not Found"
                    });
                }
            }
        }
    }
}
