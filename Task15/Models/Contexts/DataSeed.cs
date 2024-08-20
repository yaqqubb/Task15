using Task15.Models.Entities;

namespace Task15.Models.Contexts
{
    public static class DataSeed
    {

        internal static IApplicationBuilder Seed(this IApplicationBuilder app)
        {
            using (var scope = app.ApplicationServices.CreateScope())
            {

                var db = scope.ServiceProvider.GetRequiredService<DataContexts>();

                var list = new[]
                {
                   new Countries {Id=1, Name="Azerbaijan", Code=994 },
                   new Countries {Id=2, Name="Czeh Republic",Code=420},
                   new Countries {Id=3, Name="Poland" , Code=48},
                   new Countries {Id=4, Name="Norway", Code=47}





                };

                db.Countries.AddRange(list);
                db.SaveChanges();



            }

            return app;
        }

    }
}
