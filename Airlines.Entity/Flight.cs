using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Airlines.Entity
{
    public class Flight
    {
        public int FlightId { get; set; }

        [StringLength(50)]
        [Required]
        public string  Departure { get; set; }

        [StringLength(50)]
        [Required]
        public string Arrival { get; set; }

        [DataType(DataType.Currency)]
        [Required]
        public decimal Price { get; set; }

        public Plane PlaneId { get; set; }

        public int AirlineNumber { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime FlightDate { get; set; }

    }
}
