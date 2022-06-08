using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace CinemaProject.Seats
{
    public class UpdateSeatDto
    {
        [Required]
        public int Number { get; set; }

        [Required]
        public int Row { get; set; }

        [Required]
        public Guid HallId { get; set; }
    }
}
