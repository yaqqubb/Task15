using Microsoft.CodeAnalysis.FlowAnalysis;
using Microsoft.EntityFrameworkCore;
using Task15.Models.Contexts;

namespace Task15
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<DataContexts>(cfg =>
           {
               cfg.UseInMemoryDatabase("CountriesDb");




                }) ;



            var app = builder.Build();

             app.MapGet("/", () => "Hello World!");
         

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Countries}/{action=Index}/{id?}");


            app.Seed();

            


            app.Run();
        }
    }
}
