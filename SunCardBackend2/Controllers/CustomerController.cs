using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SunCardBackend2.Models;
using SunCardBackend2.Data;

namespace SunCardBackend2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly DataContext _context;

        public CustomerController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<CustomerList>>> Get()
        {

            return Ok(await _context.Customer.ToListAsync());
        }

        [HttpGet("{customerId}")]
        public async Task<ActionResult<CustomerList>> Get(int customerId)
        {
            var customer = await _context.Customer.FindAsync(customerId);
            if (customer == null)
                return BadRequest("Customer not found.");
            return Ok(customer);
        }

        [HttpPost]
        public async Task<ActionResult<List<CustomerList>>> RegisterCustomer(CustomerList customer)
        {
            _context.Customer.Add(customer);
            await _context.SaveChangesAsync();

            return Ok(await _context.Customer.ToListAsync());
        }

        [HttpPut]
        public async Task<ActionResult<List<CustomerList>>> UpdateCustomer(CustomerList request)
        {
            var dbCustomer = await _context.Customer.FindAsync(request.CustomerId);
            if (dbCustomer == null)
                return BadRequest("Customer not found.");

            dbCustomer.Pword = request.Pword;
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
            return Ok(await _context.Customer.ToListAsync());
        }

        [HttpDelete("{customerId}")]
        public async Task<ActionResult<CustomerList>> RemoveCustomer(int customerId)
        {
            var dbCustomer = await _context.Customer.FindAsync(customerId);
            if (dbCustomer == null)
                return BadRequest("Customer not found.");

            _context.Customer.Remove(dbCustomer);
            await _context.SaveChangesAsync();
            return Ok(await _context.Customer.ToListAsync());
        }
    }
}
