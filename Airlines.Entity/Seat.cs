using System;
using System.Collections.Generic;
using System.Text;

namespace Airlines.Entity
{
    public class Seat
    {
        public int SeatId { get; set; }
        public string SeatNumber { get; set; }

        public Flight Flight { get; set; }

        public  Plane Plane { get; set; }

        public bool IsBooked { get; set; } = false;
    }
}
