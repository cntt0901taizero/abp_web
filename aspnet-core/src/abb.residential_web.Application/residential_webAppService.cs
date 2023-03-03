using System;
using System.Collections.Generic;
using System.Text;
using abb.residential_web.Localization;
using Volo.Abp.Application.Services;

namespace abb.residential_web;

/* Inherit your application services from this class.
 */
public abstract class residential_webAppService : ApplicationService
{
    protected residential_webAppService()
    {
        LocalizationResource = typeof(residential_webResource);
    }
}
