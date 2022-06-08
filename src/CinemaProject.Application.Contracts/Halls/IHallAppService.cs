using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace CinemaProject.Halls
{
    public interface IHallAppService :
        ICrudAppService<
            HallDto,
            Guid,
            PagedAndSortedResultRequestDto,
            CreateHallDto,
            UpdateHallDto
            >
    {

    }
}
