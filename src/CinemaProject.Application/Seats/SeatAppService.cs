using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace CinemaProject.Seats
{
    public class SeatAppService :
        CrudAppService<
            Seat,
            SeatDto,
            Guid,
            PagedAndSortedResultRequestDto,
            CreateSeatDto,
            UpdateSeatDto>,
        ISeatAppService
    {
        public SeatAppService(IRepository<Seat, Guid> repository) : base(repository)
        {

        }
    }
}
