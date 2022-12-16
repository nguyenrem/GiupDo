﻿using AutoMapper;
using remproject.Admin.Manufacturers;
using remproject.Admin.ProductAttributes;
using remproject.Admin.ProductCategories;
using remproject.Admin.Products;
using remproject.Manufacturers;
using remproject.ProductAttributes;
using remproject.ProductCategories;
using remproject.Products;

namespace remproject.Admin;

public class remprojectAdminApplicationAutoMapperProfile : Profile
{
    public remprojectAdminApplicationAutoMapperProfile()
    {
        //Product Category
        CreateMap<ProductCategory, ProductCategoryDto>();
        CreateMap<ProductCategory, ProductCategoryInListDto>();
        CreateMap<CreateUpdateProductCategoryDto, ProductCategory>();

        //Product
        CreateMap<Product, ProductDto>();
        CreateMap<Product, ProductInListDto>();
        CreateMap<CreateUpdateProductDto, Product>();

        CreateMap<Manufacturer, ManufacturerDto>();
        CreateMap<Manufacturer, ManufacturerInListDto>();
        CreateMap<CreateUpdateManufacturerDto, Manufacturer>();

        //Product attribute
        CreateMap<ProductAttribute, ProductAttributeDto>();
        CreateMap<ProductAttribute, ProductAttributeInListDto>();
        CreateMap<CreateUpdateProductAttributeDto, ProductAttribute>();
    }
}
