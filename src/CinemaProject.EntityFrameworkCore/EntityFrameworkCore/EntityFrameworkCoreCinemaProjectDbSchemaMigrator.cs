using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CinemaProject.Data;
using Volo.Abp.DependencyInjection;

namespace CinemaProject.EntityFrameworkCore;

public class EntityFrameworkCoreCinemaProjectDbSchemaMigrator
    : ICinemaProjectDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreCinemaProjectDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the CinemaProjectDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<CinemaProjectDbContext>()
            .Database
            .MigrateAsync();
    }
}
