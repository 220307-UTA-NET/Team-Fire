using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SunCardBackend2.Models;

namespace SunCardBackend2.Controllers
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
        public async Task<ActionResult<List<CardList>>> Get()
        {

            return Ok(await _context.CardLists.ToListAsync());
        }

        [HttpGet("{cardId}")]
        public async Task<ActionResult<CardList>> Get(int cardId)
        {
            var card = await _context.CardLists.FindAsync(cardId);
            if (card == null)
                return BadRequest("Card not found.");
            return Ok(card);
        }

        [HttpPost]
        public async Task<ActionResult<List<CardList>>> RegisterCard(CardList card)
        {
            _context.CardLists.Add(card);
            await _context.SaveChangesAsync();

            return Ok(await _context.CardLists.ToListAsync());
        }

        [HttpPut]
        public async Task<ActionResult<List<CardList>>> UpdateCard(CardList request)
        {
            var dbCard = await _context.CardLists.FindAsync(request.CardId);
            if (dbCard == null)
                return BadRequest("Card not found.");

            dbCard.CardNumber = request.CardNumber;
            dbCard.PurchaseDate = request.PurchaseDate;
            dbCard.InitialBalance = request.InitialBalance;
            dbCard.CurrentBalance = request.CurrentBalance;

            await _context.SaveChangesAsync();
            return Ok(await _context.CardLists.ToListAsync());
        }

        [HttpDelete("{cardId}")]
        public async Task<ActionResult<CardList>> RemoveCard(int cardId)
        {
            var dbCard = await _context.CardLists.FindAsync(cardId);
            if (dbCard == null)
                return BadRequest("Card not found.");

            _context.CardLists.Remove(dbCard);
            await _context.SaveChangesAsync();
            return Ok(await _context.CardLists.ToListAsync());
        }
    }
}