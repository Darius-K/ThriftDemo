using System.Collections.Generic;
using Microsoft.AspNet.Mvc;
using Thrift.Transport;
using Thrift.Protocol;
using BankService.Interfaces;

namespace WebAppDemo.Controllers
{
    [Route("api/[controller]")]
    public class ThriftController : Controller
    {
        // GET: api/thrift
        [HttpGet]
        public List<Account> Get()
        {
            List<Account> accounts;

            using (var transport = new TSocket("localhost", 18801))
            {
                using (var protocol = new TBinaryProtocol(transport))
                {
                    using (var client = new AccountService.Client(protocol))
                    {
                        transport.Open();
                        accounts = client.GetAccounts(123456);
                        transport.Close();
                    }
                }
            }

            return accounts;
        }
    }
}
