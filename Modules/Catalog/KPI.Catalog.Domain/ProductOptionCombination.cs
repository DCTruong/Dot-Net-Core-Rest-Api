﻿using KPI.Infrastructure;

namespace KPI.Catalog.Domain
{
    public class ProductOptionCombination : Entity
    {
        public long ProducdtId { get; set; }

        public virtual Product Product { get; set; }

        public long OptionId { get; set; }

        public virtual ProductOption Option { get; set; }

        public string Value { get; set; }
    }
}
