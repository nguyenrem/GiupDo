﻿using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.AuditLogging;
using Volo.Abp.Domain.Entities;

namespace remproject.Products
{
    public class ProductAttributeDateTime : Entity<Guid>
    {
        public Guid AttributeId { get; set; }
        public Guid ProductId { get; set; }
        public DateTime Value { get; set; }
    }
}
