using remproject.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace remproject;

[DependsOn(
    typeof(remprojectEntityFrameworkCoreTestModule)
    )]
public class remprojectDomainTestModule : AbpModule
{

}
