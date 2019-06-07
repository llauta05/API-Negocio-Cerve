using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Google.Cloud.Firestore;

namespace API_Negocio
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
