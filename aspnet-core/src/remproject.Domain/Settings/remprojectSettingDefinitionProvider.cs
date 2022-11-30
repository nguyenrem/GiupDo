using Volo.Abp.Settings;

namespace remproject.Settings;

public class remprojectSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(remprojectSettings.MySetting1));
    }
}
