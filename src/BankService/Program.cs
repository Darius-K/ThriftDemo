using BankService.Interfaces;
using Thrift.Server;
using Thrift.Transport;

namespace BankService
{
    public class Program
    {
        static void Main()
        {
            var processor = new AccountService.Processor(new AccountServiceHandler());
            var transport = new TServerSocket(18801);
            var server = new TThreadPoolServer(processor, transport);
            server.Serve();
        }
    }
}
