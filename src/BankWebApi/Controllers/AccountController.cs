using System.Collections.Generic;
using BankWebApi.Models;
using Microsoft.AspNet.Mvc;

namespace BankWebApi.Controllers
{
    [Route("api/[controller]")]
    public class AccountController : Controller
    {
        [HttpGet("{id:long}")]
        public List<AccountModelThatClientIsNotAwareOf> Get(long id)
        {
            return new List<AccountModelThatClientIsNotAwareOf>
            {
                new AccountModelThatClientIsNotAwareOf
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
    }
}
