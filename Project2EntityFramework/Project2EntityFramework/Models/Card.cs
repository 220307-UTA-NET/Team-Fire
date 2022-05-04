using Project2EntityFramework.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project2EntityFramework
{
    public class Card
    {
        public int Card_ID { get; set; }
        public long Card_Number { get; set; }
        public string PurchaseDate { get; set; }

        public decimal InitialBalance { get; set; }

        public decimal CurrentBalance { get; set; }
        public int Customer { get; set; }
    }
}
