using System;
using System.Collections.Generic;

namespace SunCardBackend2.Models
{
    public partial class CustomerList
    {
        public int CustomerId { get; set; }
        public string? Pword { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Address1 { get; set; }
        public string? Address2 { get; set; }
        public string? City { get; set; }
        public string? StateAbb { get; set; }
        public string? Zip { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
    }
}
