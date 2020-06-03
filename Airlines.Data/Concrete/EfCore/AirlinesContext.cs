using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Airlines.Entity;

namespace Airlines.Data.Concrete.EfCore
{
    public class AirlinesContext: DbContext
    {
        public AirlinesContext(DbContextOptions<AirlinesContext> options):base(options)
        {

        }
        public DbSet<Flight> Flights { get; set; }

        public DbSet<Plane> Planes { get; set; }

        public DbSet<Seat> Seats { get; set; }

        public DbSet<User> Users { get; set; }
    }
}
