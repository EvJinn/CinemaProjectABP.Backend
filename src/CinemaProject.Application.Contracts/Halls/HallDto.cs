using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace CinemaProject.Halls
{
    public class HallDto : AuditedEntityDto<Guid>
    {
        public string Name { get; set; }
    }
}
