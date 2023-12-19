using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace AbpSwagger;

[Dependency(ReplaceServices = true)]
public class AbpSwaggerBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "AbpSwagger";
}
