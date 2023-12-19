using Volo.Abp.Modularity;

namespace AbpSwagger;

[DependsOn(
    typeof(AbpSwaggerApplicationModule),
    typeof(AbpSwaggerDomainTestModule)
    )]
public class AbpSwaggerApplicationTestModule : AbpModule
{

}
