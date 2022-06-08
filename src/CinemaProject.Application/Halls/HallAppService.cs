using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace CinemaProject.Halls
{
    public class HallAppService :
        CrudAppService<
            Hall,
            HallDto,
            Guid,
            PagedAndSortedResultRequestDto,
            CreateHallDto,
            UpdateHallDto>,
        IHallAppService
    {
        public HallAppService(IRepository<Hall, Guid> repository) : base(repository)
        { 
        
        }
    }
}
