using Grpc.Core;
using ProtoBuf.Grpc.Client;
using Shared;

namespace Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var channel = new Channel("localhost", 10042, ChannelCredentials.Insecure);
            try
            {
                var loanManager = channel.CreateGrpcService<ILoanManager>();

                

                var res = loanManager.GetText("Hello, world");
                Console.WriteLine($"{res}");


                //var amount = loanManager.GetNextPaymentAmount("1.23", new DateTime(2023, 3, 1));
                //Console.WriteLine($"Amount = {amount}");

                //var amount = loanManager.GetFirstPaymentAmount("1.23");
                //Console.WriteLine($"Amount = {amount}");




                Console.WriteLine("Client running... press any key");
                Console.ReadKey();
            }
            finally
            {
                //await channel.ShutdownAsync();
                channel.ShutdownAsync();
            }
        }
    }
}