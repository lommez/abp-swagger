using System.Threading.Tasks;

namespace AbpSwagger.Data;

public interface IAbpSwaggerDbSchemaMigrator
{
    Task MigrateAsync();
}
