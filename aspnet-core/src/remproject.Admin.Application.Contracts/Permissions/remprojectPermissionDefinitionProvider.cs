using remproject.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace remproject.Admin.Permissions;

public class remprojectPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(remprojectPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(remprojectPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<remprojectResource>(name);
    }
}
