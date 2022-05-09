using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project2EntityFramework.Models;

namespace Project2EntityFramework.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {               
        private readonly SunCardBackend2Context _context;

        public CustomerController(SunCardBackend2Context context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Customer>>> Get()
        {           

            return Ok(await _context.CustomerLists.ToListAsync());
        }

        [HttpGet("{customerId}")]
        public async Task<ActionResult<Customer>> Get(int customerId)
        {
            var customer = await _context.CustomerLists.FindAsync(customerId);
            if (customer == null)
                return BadRequest("Customer not found.");
            return Ok(customer);
        }

        [HttpPost]
        public async Task<ActionResult<List<Customer>>> RegisterCustomer(Customer customer)
        {
            _context.CustomerLists.Add(customer);
            await _context.SaveChangesAsync();

            return Ok(await _context.CustomerLists.ToListAsync());
        }

        [HttpPut]
        public async Task<ActionResult<List<Customer>>> UpdateCustomer(Customer request)
        {
            var dbCustomer = await _context.CustomerLists.FindAsync(request.Customer_ID);
            if (dbCustomer == null)
                return BadRequest("Customer not found.");

            dbCustomer.PWord = request.PWord;
            dbCustomer.FirstName = request.FirstName;
            dbCustomer.LastName = request.LastName;
            dbCustomer.Address1 = request.Address1;
            dbCustomer.Address2 = request.Address2;
            dbCustomer.City = request.City;
            dbCustomer.StateAbb = request.StateAbb;
            dbCustomer.Zip = request.Zip;
            dbCustomer.Phone = request.Phone;
            dbCustomer.Email = request.Email;

            await _context.SaveChangesAsync();
            return Ok(await _context.CustomerLists.ToListAsync());
        }

        [HttpDelete("{customerId}")]
        public async Task<ActionResult<Customer>> RemoveCustomer(int customerId)
        {
            var dbCustomer = await _context.CustomerLists.FindAsync(customerId);
            if (dbCustomer == null)
                return BadRequest("Customer not found.");

            _context.CustomerLists.Remove(dbCustomer);
            await _context.SaveChangesAsync();
            return Ok(await _context.CustomerLists.ToListAsync());
        }
    }
}
