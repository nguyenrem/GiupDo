using System;
using System.Collections.Generic;
using System.Text;
using remproject.Localization;
using Volo.Abp.Application.Services;

namespace remproject.Admin;

/* Inherit your application services from this class.
 */
public abstract class remprojectAdminAppService : ApplicationService
{
    protected remprojectAdminAppService()
    {
        LocalizationResource = typeof(remprojectResource);
    }
}
