namespace MyWebServer
{
    using MyWebServer.Server;
    using System.Threading.Tasks;
    class Startup
    {
        public static async Task Main()
        {
            // http://liclhost:9090

            var server = new HttpServer("127.0.0.1", 9090);

            await server.Start();
        }
    }
}
