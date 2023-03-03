using abb.residential_web.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace abb.residential_web.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class residential_webController : AbpControllerBase
{
    protected residential_webController()
    {
        LocalizationResource = typeof(residential_webResource);
    }
}
