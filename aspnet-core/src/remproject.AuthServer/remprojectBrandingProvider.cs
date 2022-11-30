using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace remproject;

[Dependency(ReplaceServices = true)]
public class remprojectBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "remproject";
}
