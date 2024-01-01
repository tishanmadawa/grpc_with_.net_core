// See https://aka.ms/new-console-template for more information
using Grpc.Net.Client;
using GRPC_Client;

var data = new HelloRequest { Name = "Joydip" };
var grpcChannel = GrpcChannel.ForAddress("https://localhost:7107");
var client = new Greeter.GreeterClient(grpcChannel);
var response = await client.SayHelloAsync(data);
Console.WriteLine(response.Message);
Console.ReadLine();

