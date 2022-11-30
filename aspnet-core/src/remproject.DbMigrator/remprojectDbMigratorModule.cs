using remproject.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace remproject.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(remprojectEntityFrameworkCoreModule),
    typeof(remprojectApplicationContractsModule)
    )]
public class remprojectDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
