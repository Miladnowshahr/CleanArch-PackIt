﻿using PackIt.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackIt.Domain.Policies.Temperature
{
    public class LowTemperaturePolicy : IPackingItemsPolicy
    {
        public IEnumerable<PackingItem> GenerateItems(PolicyData data)
            => new List<PackingItem>
            {
                new("Winter Hat",1),
                new("Scarf",1),
                new("Gloves",1),
                new("Hoodie",1),
                new("Warm jacket",1)
            };

        public bool IsApplicable(PolicyData data)
            => data.Temperature < 10D;
    }
}
