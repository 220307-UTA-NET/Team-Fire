using Project2EntityFramework.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project2EntityFramework
{
    public class Card
    {
        public int cardId { get; set; }
        public long cardNumber { get; set; }
        public string cardPurchaseDate { get; set; }

        public decimal cardInitialBalance { get; set; }

        public decimal cardCurrentBalance { get; set; }
        public int customerId { get; set; }
    }
}
