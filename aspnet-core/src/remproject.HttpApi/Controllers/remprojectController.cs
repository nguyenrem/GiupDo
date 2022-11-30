using remproject.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace remproject.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class remprojectController : AbpControllerBase
{
    protected remprojectController()
    {
        LocalizationResource = typeof(remprojectResource);
    }
}
