using System;
using System.Collections.Generic;
using System.Text;
using AbpSwagger.Localization;
using Volo.Abp.Application.Services;

namespace AbpSwagger;

/* Inherit your application services from this class.
 */
public abstract class AbpSwaggerAppService : ApplicationService
{
    protected AbpSwaggerAppService()
    {
        LocalizationResource = typeof(AbpSwaggerResource);
    }
}
