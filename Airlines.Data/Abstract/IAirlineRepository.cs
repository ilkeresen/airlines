using Airlines.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Airlines.Data.Abstract
{
    public interface IAirlineRepository
    {
        IQueryable<Flight> GetAll();
        Flight GetById(int FlightId);
        Flight GetByName(string Departure, string Arrival, DateTime FlightDate);
        void AddAirline(Flight entity);
        void UpdateAirline(Flight entity);
        void DeleteAirline(int FlightId);
    }
}
