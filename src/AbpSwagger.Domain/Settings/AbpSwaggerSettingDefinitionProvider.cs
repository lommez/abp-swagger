using Volo.Abp.Settings;

namespace AbpSwagger.Settings;

public class AbpSwaggerSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(AbpSwaggerSettings.MySetting1));
    }
}
