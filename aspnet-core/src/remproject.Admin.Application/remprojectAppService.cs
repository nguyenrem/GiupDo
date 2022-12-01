using System;
using System.Collections.Generic;
using System.Text;
using remproject.Localization;
using Volo.Abp.Application.Services;

namespace remproject.Admin;

/* Inherit your application services from this class.
 */
public abstract class remprojectAppService : ApplicationService
{
    protected remprojectAppService()
    {
        LocalizationResource = typeof(remprojectResource);
    }
}
