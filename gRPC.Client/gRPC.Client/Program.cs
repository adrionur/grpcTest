// See https://aka.ms/new-console-template for more information
using gRPC.Client;
using Grpc.Net.Client;

class Program
{
    static async Task Main(string[] args)
    {
        var channel = GrpcChannel.ForAddress("https://localhost:7047");
        var greetClient = new Greeter.GreeterClient(channel);
        HelloReply response = await greetClient.SayHelloAsync(new HelloRequest() { Name = "Berrak" });
        Console.WriteLine(response);

        var orderClient = new Orderer.OrdererClient(channel);
        OrderResponse orderResponse = await orderClient.GetOrderAsync(new OrderRequest() { OrderId = "BB777" });
        Console.WriteLine(orderResponse);
    }
}