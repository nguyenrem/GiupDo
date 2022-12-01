using remproject.Admin;
using Volo.Abp.Modularity;

namespace remproject.Admin;

[DependsOn(
    typeof(remprojectAdminApplicationModule),
    typeof(remprojectDomainTestModule)
    )]
public class remprojectApplicationTestModule : AbpModule
{

}
