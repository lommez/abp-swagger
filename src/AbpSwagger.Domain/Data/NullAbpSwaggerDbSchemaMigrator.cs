using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace AbpSwagger.Data;

/* This is used if database provider does't define
 * IAbpSwaggerDbSchemaMigrator implementation.
 */
public class NullAbpSwaggerDbSchemaMigrator : IAbpSwaggerDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
