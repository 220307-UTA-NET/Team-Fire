using System;
using System.Collections.Generic;

namespace SunCardBackend2.Models
{
    public partial class CardList
    {
        public int CardId { get; set; }
        public long? CardNumber { get; set; }
        public string? PurchaseDate { get; set; }
        public decimal? InitialBalance { get; set; }
        public decimal? CurrentBalance { get; set; }
        public int? Customer { get; set; }
    }
}
