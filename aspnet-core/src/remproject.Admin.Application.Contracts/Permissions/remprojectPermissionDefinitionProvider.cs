using remproject.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace remproject.Admin.Permissions;

public class remprojectPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        //Catalog
        var catalogGroup = context.AddGroup(remprojectPermissions.CatalogGroupName);

        //Add product
        var productPermission = catalogGroup.AddPermission(remprojectPermissions.Product.Default, L("Permission:Catalog.Product"));
        productPermission.AddChild(remprojectPermissions.Product.Create, L("Permission:Catalog.Product.Create"));
        productPermission.AddChild(remprojectPermissions.Product.Update, L("Permission:Catalog.Product.Update"));
        productPermission.AddChild(remprojectPermissions.Product.Delete, L("Permission:Catalog.Product.Delete"));
        productPermission.AddChild(remprojectPermissions.Product.AttributeManage, L("Permission:Catalog.Product.AttributeManage"));

        //Add attribute
        var attributePermission = catalogGroup.AddPermission(remprojectPermissions.Attribute.Default, L("Permission:Catalog.Attribute"));
        attributePermission.AddChild(remprojectPermissions.Attribute.Create, L("Permission:Catalog.Attribute.Create"));
        attributePermission.AddChild(remprojectPermissions.Attribute.Update, L("Permission:Catalog.Attribute.Update"));
        attributePermission.AddChild(remprojectPermissions.Attribute.Delete, L("Permission:Catalog.Attribute.Delete"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<remprojectResource>(name);
    }
}
