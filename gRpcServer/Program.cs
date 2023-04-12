using Grpc.Core;
using ProtoBuf.Grpc.Server;
using Shared;

namespace gRpcServer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Server server = new Server
            {
                Ports = { new ServerPort("localhost", 10042, ServerCredentials.Insecure) },
            };

            var calc = new LoanManager();
            server.Services.AddCodeFirst<ILoanManager>(calc);

            server.Start();
            Console.WriteLine("Server running... press any key");
            Console.ReadKey();
            server.ShutdownAsync().Wait();
        }
    }
}