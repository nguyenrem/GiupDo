using Volo.Abp.Modularity;

namespace remproject;

[DependsOn(
    typeof(remprojectApplicationModule),
    typeof(remprojectDomainTestModule)
    )]
public class remprojectApplicationTestModule : AbpModule
{

}
