using AbpSwagger.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace AbpSwagger.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AbpSwaggerEntityFrameworkCoreModule),
    typeof(AbpSwaggerApplicationContractsModule)
    )]
public class AbpSwaggerDbMigratorModule : AbpModule
{
}
