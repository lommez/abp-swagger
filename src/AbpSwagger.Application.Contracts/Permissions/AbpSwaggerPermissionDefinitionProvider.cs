using AbpSwagger.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace AbpSwagger.Permissions;

public class AbpSwaggerPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(AbpSwaggerPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(AbpSwaggerPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<AbpSwaggerResource>(name);
    }
}
