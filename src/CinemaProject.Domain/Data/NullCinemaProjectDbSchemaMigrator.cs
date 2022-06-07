using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace CinemaProject.Data;

/* This is used if database provider does't define
 * ICinemaProjectDbSchemaMigrator implementation.
 */
public class NullCinemaProjectDbSchemaMigrator : ICinemaProjectDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
