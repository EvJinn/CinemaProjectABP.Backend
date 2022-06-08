using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Domain.Entities.Auditing;

namespace CinemaProject.Seats
{
    public class Seat : AuditedAggregateRoot<Guid>
    {
        public int Number { get; set; }
        public int Row { get; set; }
        public Guid HallId { get; set; }

        //public Guid CategoryId { get; set; }
        
        ////Coords for create Hall scheme. Not sure
        //public struct Coords
        //{
        //    public int x_coord { get; set; }
        //    public int y_coord { get; set; }
        //}

        public Seat()
        {

        }

        internal Seat (Guid id, int number, int row, Guid hallId) : base(id)
        {
            SetNumber(number);
            SetRow(row);
            HallId = hallId;
        }
        internal void SetNumber(int number) =>
            Number = number;

        internal void SetRow(int row) =>
            Row = row;
    }
}
