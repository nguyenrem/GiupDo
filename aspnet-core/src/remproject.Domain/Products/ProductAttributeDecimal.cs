﻿using System;
using Volo.Abp.Domain.Entities;

namespace remproject.Products
{
    public class ProductAttributeDecimal : Entity<Guid>
    {
        public ProductAttributeDecimal(Guid id, Guid attributeId, Guid productId, decimal value)
        {
            Id = id;
            AttributeId = attributeId;
            ProductId = productId;
            Value = value;
        }
        public Guid AttributeId { get; set; }
        public Guid ProductId { get; set; }
        public decimal Value { get; set; }
    }
}
