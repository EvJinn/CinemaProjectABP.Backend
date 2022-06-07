using CinemaProject.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace CinemaProject.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(CinemaProjectEntityFrameworkCoreModule),
    typeof(CinemaProjectApplicationContractsModule)
    )]
public class CinemaProjectDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
