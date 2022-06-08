using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace CinemaProject.Seats
{
    public class SeatDto : AuditedEntityDto<Guid>
    {
        public int Number { get; set; }
        public int Row { get; set; }
        public Guid HallId { get; set; }
    }
}
