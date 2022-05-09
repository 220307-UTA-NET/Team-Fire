using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project2EntityFramework.Models;
namespace Project2EntityFramework.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardController : ControllerBase
    {
        private readonly SunCardBackend2Context _context;

        public CardController(SunCardBackend2Context context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Card>>> Get()
        {

            return Ok(await _context.CardLists.ToListAsync());
        }

        [HttpGet("{cardNum:long}")]
        public async Task<ActionResult<decimal>> Get(long cardNum)
        {
            var card = await _context.CardLists.Where(cardFind => cardFind.Card_Number == cardNum).FirstOrDefaultAsync();
            string error = "Card_not_found.";

            if (card == null)
                return BadRequest(error);
            return Ok(card.CurrentBalance);
        }

        [HttpPost]
        public async Task<ActionResult<List<Card>>> RegisterCard(Card card)
        {
            _context.CardLists.Add(card);
            await _context.SaveChangesAsync();

            return Ok(await _context.CardLists.ToListAsync());
        }

        [HttpPut]
        public async Task<ActionResult<List<Card>>> UpdateCard(Card request)
        {
            var dbCard = await _context.CardLists.FindAsync(request.Card_ID);
            if (dbCard == null)
                return BadRequest("Card not found.");

            dbCard.Card_Number = request.Card_Number;
            dbCard.PurchaseDate = request.PurchaseDate;
            dbCard.InitialBalance = request.InitialBalance;
            dbCard.CurrentBalance = request.CurrentBalance;

            await _context.SaveChangesAsync();
            return Ok(await _context.CardLists.ToListAsync());
        }
    }
}
