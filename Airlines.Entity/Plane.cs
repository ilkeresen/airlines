using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Airlines.Entity
{
    public class Plane
    {
        public int PlaneId { get; set; }

        [StringLength(50)]
        [Required]
        public string PlaneType { get; set; }

        [StringLength(50)]
        [Required]
        public string PlaneName { get; set; }
    }
}
