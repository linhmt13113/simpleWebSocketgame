
using System.Net;
using Project_Net.Application.Handlers;

var wsServer = new WsGameServer(IPAddress.Any, 8080);
wsServer.StartServer();
for (;;)
{
    var type = Console.ReadLine();
    if (!string.IsNullOrEmpty(type = "restart"))
    {
        wsServer.RestartServer();
    }

    if (!string.IsNullOrEmpty(type = "shutdown"))
    {
        wsServer.StopServer();
        break;
    }
}
