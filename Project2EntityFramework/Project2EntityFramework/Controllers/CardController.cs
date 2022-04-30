using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Project2EntityFramework.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardController : ControllerBase
    {
        private readonly DataContext _context;

        public CardController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Card>>> Get()
        {

            return Ok(await _context.Card.ToListAsync());
        }

        [HttpGet("{cardId}")]
        public async Task<ActionResult<Card>> Get(int cardId)
        {
            var card = await _context.Card.FindAsync(cardId);
            if (card == null)
                return BadRequest("Card not found.");
            return Ok(card);
        }

        [HttpPost]
        public async Task<ActionResult<List<Card>>> RegisterCard(Card card)
        {
            _context.Card.Add(card);
            await _context.SaveChangesAsync();

            return Ok(await _context.Card.ToListAsync());
        }

        [HttpPut]
        public async Task<ActionResult<List<Card>>> UpdateCard(Card request)
        {
            var dbCard = await _context.Card.FindAsync(request.cardId);
            if (dbCard == null)
                return BadRequest("Card not found.");

            dbCard.cardNumber = request.cardNumber;
            dbCard.cardPurchaseDate = request.cardPurchaseDate;
            dbCard.cardInitialBalance = request.cardInitialBalance;
            dbCard.cardCurrentBalance = request.cardCurrentBalance;
            
            await _context.SaveChangesAsync();
            return Ok(await _context.Card.ToListAsync());
        }

        [HttpDelete("{cardId}")]
        public async Task<ActionResult<Card>> RemoveCard(int cardId)
        {
            var dbCard = await _context.Card.FindAsync(cardId);
            if (dbCard == null)
                return BadRequest("Card not found.");

            _context.Card.Remove(dbCard);
            await _context.SaveChangesAsync();
            return Ok(await _context.Card.ToListAsync());
        }
    }
}
