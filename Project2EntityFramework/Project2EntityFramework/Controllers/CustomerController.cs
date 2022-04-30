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
        private readonly DataContext _context;

        public CustomerController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Customer>>> Get()
        {           

            return Ok(await _context.Customer.ToListAsync());
        }

        [HttpGet("{customerId}")]
        public async Task<ActionResult<Customer>> Get(int customerId)
        {
            var customer = await _context.Customer.FindAsync(customerId);
            if (customer == null)
                return BadRequest("Customer not found.");
            return Ok(customer);
        }

        [HttpPost]
        public async Task<ActionResult<List<Customer>>> RegisterCustomer(Customer customer)
        {
            _context.Customer.Add(customer);
            await _context.SaveChangesAsync();

            return Ok(await _context.Customer.ToListAsync());
        }

        [HttpPut]
        public async Task<ActionResult<List<Customer>>> UpdateCustomer(Customer request)
        {
            var dbCustomer = await _context.Customer.FindAsync(request.customerId);
            if (dbCustomer == null)
                return BadRequest("Customer not found.");

            dbCustomer.customerPWord = request.customerPWord;
            dbCustomer.customerFirstName = request.customerFirstName;
            dbCustomer.customerLastName = request.customerLastName;
            dbCustomer.customerAddress1 = request.customerAddress1;
            dbCustomer.customerAddress2 = request.customerAddress2;
            dbCustomer.customerCity = request.customerCity;
            dbCustomer.customerStateAbb = request.customerStateAbb;
            dbCustomer.customerZip = request.customerZip;
            dbCustomer.customerPhone = request.customerPhone;
            dbCustomer.customerEmail = request.customerEmail;

            await _context.SaveChangesAsync();
            return Ok(await _context.Customer.ToListAsync());
        }

        [HttpDelete("{customerId}")]
        public async Task<ActionResult<Customer>> RemoveCustomer(int customerId)
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
