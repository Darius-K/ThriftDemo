using BankService.Interfaces;
using System.Collections.Generic;

namespace BankService
{
    public class AccountServiceHandler : AccountService.Iface
    {
        public List<Account> GetAccounts(long customerId)
        {
            return new List<Account>
            {
                new Account
                {
                    AccountNumber = 123,
                    AccountOpened = "2016-01-19",
                    AccumulatedInterest = 234324324,
                    Balance = 324234,
                    CreditAmount = 34455,
                    CurrencyCode = "NOK",
                    InterestRate = 2,
                    ProductName = "Saving",
                    Active = true
                }
            };
        }

        public long CreateAccount(long customerId, Account account)
        {
            return 123;
        }
    }
}