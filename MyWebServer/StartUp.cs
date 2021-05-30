namespace MyWebServer
{
    using System;
    using System.Net;
    using System.Net.Sockets;
    using System.Text;
    using System.Threading.Tasks;
    using MyWebServer.Server;
    public class StartUp
    {
        public static async Task Main()
        {
            // http://localhost:9090

            var server = new HttpServer("127.0.0.1",9090);
        }
    }
}
