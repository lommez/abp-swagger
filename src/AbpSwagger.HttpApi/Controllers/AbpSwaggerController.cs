using AbpSwagger.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace AbpSwagger.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class AbpSwaggerController : AbpControllerBase
{
    protected AbpSwaggerController()
    {
        LocalizationResource = typeof(AbpSwaggerResource);
    }
}
