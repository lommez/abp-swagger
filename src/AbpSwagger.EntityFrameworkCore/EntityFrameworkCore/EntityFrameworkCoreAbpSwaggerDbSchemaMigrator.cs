using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AbpSwagger.Data;
using Volo.Abp.DependencyInjection;

namespace AbpSwagger.EntityFrameworkCore;

public class EntityFrameworkCoreAbpSwaggerDbSchemaMigrator
    : IAbpSwaggerDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreAbpSwaggerDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the AbpSwaggerDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<AbpSwaggerDbContext>()
            .Database
            .MigrateAsync();
    }
}
