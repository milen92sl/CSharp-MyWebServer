namespace MyWebServer
{
    using System.Threading.Tasks;
    using MyWebServer.Server;
    using MyWebServer.Server.Responses;

    public class StartUp
    {
        public static async Task Main()
            => await new HttpServer("127.0.0.1",9090, routes => routes
                    .Map("/",new TextResponse("Hello From Milen!"))
                    .Map("/Cats",new TextResponse("Hello from the Cats!"))
                .Start();
    }
}

