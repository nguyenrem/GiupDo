using AutoMapper;
using remproject.Admin.ProductCategories;
using remproject.Admin.Products;
using remproject.ProductCategories;
using remproject.Products;

namespace remproject.Admin;

public class remprojectAdminApplicationAutoMapperProfile : Profile
{
    public remprojectAdminApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */

        //Product Category
        CreateMap<ProductCategory, ProductCategoryDto>();
        CreateMap<ProductCategory, ProductCategoryInListDto>();
        CreateMap<CreateUpdateProductCategoryDto, ProductCategory>();

        //Product
        CreateMap<Product, ProductDto>();
        CreateMap<Product, ProductInListDto>();
        CreateMap<CreateUpdateProductDto, Product>();
    }
}
