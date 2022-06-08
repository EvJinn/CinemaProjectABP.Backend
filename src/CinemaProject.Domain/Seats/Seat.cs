using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace CinemaProject.Seats
{
    public class Seat : AuditedAggregateRoot<Guid>
    {
        public int Number { get; set; }
        public int Row { get; set; }
        public Guid Hall { get; set; }

        //public Guid Category { get; set; }
        
        ////Coords for create Hall scheme. Not sure
        //public struct Coords
        //{
        //    public int x_coord { get; set; }
        //    public int y_coord { get; set; }
        //}
    }
}
