using AutoMapper;
using remproject.Admin.ProductCategories;
using remproject.ProductCategories;

namespace remproject.Admin;

public class remprojectAdminApplicationAutoMapperProfile : Profile
{
    public remprojectAdminApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<ProductCategory, ProductCategoryDto>();
        CreateMap<ProductCategory, ProductCategoryInListDto>();
        CreateMap<CreateUpdateProductCategoryDto, ProductCategory>();
    }
}
