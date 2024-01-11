using System.Threading.Tasks;
using Grpc.Net.Client;
using GrpcGreeterClient;

// The port number must match the port of the gRPC server.

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Start: " + DateTime.Now.Second.ToString() + "." + DateTime.Now.Millisecond.ToString());
    using var channel = GrpcChannel.ForAddress("https://localhost:7139"); // "http://localhost:5093"
    Console.WriteLine(DateTime.Now.Second.ToString() + "." + DateTime.Now.Millisecond.ToString());
    var client = new Greeter.GreeterClient(channel);
    Console.WriteLine(DateTime.Now.Second.ToString() + "." + DateTime.Now.Millisecond.ToString());
    var reply = await client.SayHelloAsync(
                      new HelloRequest { Name = "GreeterClient" });
    Console.WriteLine(DateTime.Now.Second.ToString() + "." + DateTime.Now.Millisecond.ToString());
    Console.WriteLine("Greeting: " + reply.Message);
}
Console.WriteLine("Press any key to exit...");
Console.ReadKey();