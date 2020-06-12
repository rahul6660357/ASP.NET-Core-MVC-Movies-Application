using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using DemoMVC_ASPCORE.Data;

namespace DemoMVC_ASPCORE.Models
{
    public class SeedData
    {
        public static void Initialise(IServiceProvider serviceProvider)
        {
using (var context = new DemoMVC_ASPCOREContext (serviceProvider.GetRequiredService<DbContextOptions<DemoMVC_ASPCOREContext>>()))
            {
                if(context.Movie.Any())
                {
                    return;
                }
                context.Movie.AddRange(
                    new Movie
                    {
                        title = "When Harry Met Sally",
                        releasedate = DateTime.Parse("1989-2-12"),
                        genric = "Romantic Comedy",
                        price = 7.99M
                    },

                    new Movie
                    {
                        title = "Ghostbusters ",
                        releasedate = DateTime.Parse("1984-3-13"),
                        genric = "Comedy",
                        price = 8.99M
                    },

                    new Movie
                    {
                        title = "Ghostbusters 2",
                        releasedate = DateTime.Parse("1986-2-23"),
                        genric = "Comedy",
                        price = 9.99M
                    },

                    new Movie
                    {
                        title = "Rio Bravo",
                        releasedate = DateTime.Parse("1959-4-15"),
                        genric = "Western",
                        price = 3.99M
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}

