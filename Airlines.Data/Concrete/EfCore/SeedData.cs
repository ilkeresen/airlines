using Microsoft.AspNetCore.Builder;
using Airlines.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Airlines.Data.Concrete.EfCore
{
    public static class SeedData
    {
        public static void Seed(IApplicationBuilder app)
        {
            AirlinesContext context = app.ApplicationServices.GetRequiredService<AirlinesContext>();

            context.Database.Migrate();

            if (!context.Users.Any())
            {
                context.Users.AddRange(

                    new User() { UserAuthority = "Admin", UserName = "İlker Esen", UserEmail = "ilkeresen@hotmail.com", UserPassword = "123456", UserPhone = "05309665154" },
                    new User() { UserAuthority = "User", UserName = "Deneme User", UserEmail = "denemeuser@hotmail.com", UserPassword = "123456", UserPhone = "05309665154" }
                    

                );

                context.SaveChanges();
            }

            if (!context.Flights.Any())
            {
                context.Flights.AddRange(

                    new Flight() { Departure = "İstanbul", Arrival = "Ankara", FlightDate = DateTime.Now.AddDays(-5), AirlineNumber = 1, Price = 150 },
                    new Flight() { Departure = "İstanbul", Arrival = "İzmir", FlightDate = DateTime.Now.AddDays(-5), AirlineNumber = 2, Price = 200 },
                    new Flight() { Departure = "İstanbul", Arrival = "Yozgat", FlightDate = DateTime.Now.AddDays(-5), AirlineNumber = 3, Price = 130 },
                    new Flight() { Departure = "İstanbul", Arrival = "Antalya", FlightDate = DateTime.Now.AddDays(-5), AirlineNumber = 4, Price = 200 },
                    new Flight() { Departure = "İstanbul", Arrival = "Balıkesir", FlightDate = DateTime.Now.AddDays(-5), AirlineNumber = 5, Price = 150 },
                    new Flight() { Departure = "İstanbul", Arrival = "Trabzon", FlightDate = DateTime.Now.AddDays(-5), AirlineNumber = 6, Price = 210 },
                    new Flight() { Departure = "İstanbul", Arrival = "Çanakkale", FlightDate = DateTime.Now.AddDays(-5), AirlineNumber = 7, Price = 120 },
                    new Flight() { Departure = "İstanbul", Arrival = "Hakkari", FlightDate = DateTime.Now.AddDays(-5), AirlineNumber = 8, Price = 300 },
                    new Flight() { Departure = "İstanbul", Arrival = "Van", FlightDate = DateTime.Now.AddDays(-5), AirlineNumber = 9, Price = 300 },
                    new Flight() { Departure = "İstanbul", Arrival = "Mardin", FlightDate = DateTime.Now.AddDays(-5), AirlineNumber = 10, Price = 300 },
                    new Flight() { Departure = "İstanbul", Arrival = "Samsun", FlightDate = DateTime.Now.AddDays(-20), AirlineNumber = 11, Price = 250 }

                );

                context.SaveChanges();
            }
        }
    }
}
