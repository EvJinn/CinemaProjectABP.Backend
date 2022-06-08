using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace CinemaProject.Halls
{
    public class UpdateHallDto
    {
        [Required]
        public string Name { get; set; }
    }
}
