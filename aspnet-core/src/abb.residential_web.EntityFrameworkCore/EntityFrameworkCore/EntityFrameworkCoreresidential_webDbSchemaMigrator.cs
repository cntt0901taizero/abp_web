using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using abb.residential_web.Data;
using Volo.Abp.DependencyInjection;

namespace abb.residential_web.EntityFrameworkCore;

public class EntityFrameworkCoreresidential_webDbSchemaMigrator
    : Iresidential_webDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreresidential_webDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the residential_webDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<residential_webDbContext>()
            .Database
            .MigrateAsync();
    }
}
