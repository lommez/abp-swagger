using AbpSwagger.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace AbpSwagger;

[DependsOn(
    typeof(AbpSwaggerEntityFrameworkCoreTestModule)
    )]
public class AbpSwaggerDomainTestModule : AbpModule
{

}
