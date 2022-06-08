using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace CinemaProject.Seats
{
    public interface ISeatAppService :
        ICrudAppService<
            SeatDto,
            Guid,
            PagedAndSortedResultRequestDto,
            CreateSeatDto,
            UpdateSeatDto
            >
    {

    }
}
