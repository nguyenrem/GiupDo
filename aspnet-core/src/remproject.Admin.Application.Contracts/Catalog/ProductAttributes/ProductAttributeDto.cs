﻿using System;
using System.Collections.Generic;
using System.Text;
using remproject.ProductAttributes;
using Volo.Abp.Application.Dtos;

namespace remproject.Admin.Catalog.ProductAttributes
{
    public class ProductAttributeDto : IEntityDto<Guid>
    {
        public string Code { get; set; }
        public AttributeType DataType { get; set; }
        public string Label { get; set; }
        public int SortOrder { get; set; }
        public bool Visibility { get; set; }
        public bool IsActive { get; set; }
        public bool IsRequired { get; set; }
        public bool IsUnique { get; set; }
        public string Note { get; set; }
        public Guid Id { get; set; }
    }
}
