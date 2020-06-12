using Airlines.Data.Abstract;
using Airlines.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Airlines.Data.Concrete.EfCore
{
    public class EfAirlineRepository : IAirlineRepository
    {
        private AirlinesContext context;

        public EfAirlineRepository(AirlinesContext _context)
        {
            context = _context;
        }
        public void AddAirline(Flight entity)
        {
            context.Flights.Add(entity);
            context.SaveChanges();
        }

        public void DeleteAirline(int FlightId)
        {
            var airline = context.Flights.FirstOrDefault(p => p.FlightId == FlightId);
            if (airline != null)
            {
                context.Flights.Remove(airline);
                context.SaveChanges();
            }
        }

        public IQueryable<Flight> GetAll()
        {
            return context.Flights;
        }

        public Flight GetByName(string Departure, string Arrival, DateTime Date)
        {
            return context.Flights.Where(p => p.Departure == Departure && p.Arrival == Arrival && p.FlightDate == Date).FirstOrDefault();
        }

        public Flight GetById(int FlightId)
        {
            return context.Flights.FirstOrDefault(p=> p.FlightId == FlightId);
        }
        public void UpdateAirline(Flight entity)
        {
            context.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }
    }
}
