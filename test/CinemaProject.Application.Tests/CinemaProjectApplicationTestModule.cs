using Volo.Abp.Modularity;

namespace CinemaProject;

[DependsOn(
    typeof(CinemaProjectApplicationModule),
    typeof(CinemaProjectDomainTestModule)
    )]
public class CinemaProjectApplicationTestModule : AbpModule
{

}
