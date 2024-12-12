// See https://aka.ms/new-console-template for more information
using gRPC.Client;
using Grpc.Net.Client;

class Program
{
    static async Task Main(string[] args)
    {
        var channel = GrpcChannel.ForAddress("http:localhost:7047");
        var greetClient = new Greeter.GreeterClient(channel);
        var response = await greetClient.SayHelloAsync(new HelloRequest());
        Console.WriteLine(response);
    }
}