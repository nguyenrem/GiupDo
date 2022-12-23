using remproject.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace remproject.Admin.Permissions;

public class remprojectPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        //Catalog
        var catalogGroup = context.AddGroup(remprojectPermissions.CatalogGroupName, L("Permission:Catalog"));

        //Manufacture
        var manufacturerPermission = catalogGroup.AddPermission(remprojectPermissions.Manufacturer.Default, L("Permission:Catalog.Manufacturer"));
        manufacturerPermission.AddChild(remprojectPermissions.Manufacturer.Create, L("Permission:Catalog.Manufacturer.Create"));
        manufacturerPermission.AddChild(remprojectPermissions.Manufacturer.Update, L("Permission:Catalog.Manufacturer.Update"));
        manufacturerPermission.AddChild(remprojectPermissions.Manufacturer.Delete, L("Permission:Catalog.Manufacturer.Delete"));

        //Product Category
        var productCategoryPermission = catalogGroup.AddPermission(remprojectPermissions.ProductCategory.Default, L("Permission:Catalog.ProductCategory"));
        productCategoryPermission.AddChild(remprojectPermissions.ProductCategory.Create, L("Permission:Catalog.ProductCategory.Create"));
        productCategoryPermission.AddChild(remprojectPermissions.ProductCategory.Update, L("Permission:Catalog.ProductCategory.Update"));
        productCategoryPermission.AddChild(remprojectPermissions.ProductCategory.Delete, L("Permission:Catalog.ProductCategory.Delete"));

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
