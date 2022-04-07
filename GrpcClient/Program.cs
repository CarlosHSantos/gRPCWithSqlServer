// See https://aka.ms/new-console-template for more information
using Grpc.Net.Client;
using GrpcServer;

var channel = GrpcChannel.ForAddress("https://localhost:7015");

var input = new HelloRequest { Name = "Carlos" };
var client = new Greeter.GreeterClient(channel);

var reply = await client.SayHelloAsync(input);

Console.WriteLine(reply.Message);

var inputUsuarioRequest = new UsuarioRequest { Id = 1 };

var clientUsuario = new Usuario.UsuarioClient(channel);
var replyUsuarioRequest = await clientUsuario.GetUsuarioByIdAsync(inputUsuarioRequest);

Console.WriteLine($"Nome: {replyUsuarioRequest.Nome}, Sobrenome: {replyUsuarioRequest.SobreNome}, E-mail: {replyUsuarioRequest.Email}");
Console.ReadLine();
