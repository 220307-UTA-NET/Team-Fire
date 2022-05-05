namespace Project2EntityFramework.Models
{
    public class Customer
    {
        public int Customer_ID { get; set; } 
        public string PWord { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Address1 { get; set; } = string.Empty;
        public string Address2 { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string StateAbb { get; set; } = string.Empty;

        public string Zip { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        public Customer() { }

        public Customer(int Customer_ID, string PWord, string FirstName, string LastName, string Address1, string Address2, string City,
            string StateAbb, string Zip, string Phone, string Email)
        {
            this.Customer_ID = Customer_ID;
            this.PWord = PWord;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Address1 = Address1;
            this.Address2 = Address2;
            this.City = City;
            this.StateAbb = StateAbb;
            this.Zip = Zip;
            this.Phone = Phone;
            this.Email = Email;
        }
    }

}
