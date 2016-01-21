namespace BankWebApi.Models
{
    public class AccountModelThatClientIsNotAwareOf
    {
        public long AccountNumber { get; set; }

        public long Balance { get; set; }

        public long CreditAmount { get; set; }

        public string ProductName { get; set; }

        public string AccountOpened { get; set; }

        public bool Active { get; set; }

        public string CurrencyCode { get; set; }

        public int InterestRate { get; set; }

        public int AccumulatedInterest { get; set; }
    }
}
