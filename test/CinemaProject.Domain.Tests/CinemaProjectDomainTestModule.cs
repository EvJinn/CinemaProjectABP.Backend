using CinemaProject.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace CinemaProject;

[DependsOn(
    typeof(CinemaProjectEntityFrameworkCoreTestModule)
    )]
public class CinemaProjectDomainTestModule : AbpModule
{

}
