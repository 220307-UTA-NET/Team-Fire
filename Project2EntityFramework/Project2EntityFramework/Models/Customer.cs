namespace Project2EntityFramework.Models
{
    public class Customer
    {
        public int customerId { get; set; } 
        public string customerPWord { get; set; } = string.Empty;
        public string customerFirstName { get; set; } = string.Empty;
        public string customerLastName { get; set; } = string.Empty;
        public string customerAddress1 { get; set; } = string.Empty;
        public string customerAddress2 { get; set; } = string.Empty;
        public string customerCity { get; set; } = string.Empty;
        public string customerStateAbb { get; set; } = string.Empty;
        public string customerZip { get; set; } = string.Empty;
        public string customerPhone { get; set; } = string.Empty;
        public string customerEmail { get; set; } = string.Empty;
    }
}
