using PackIt.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackIt.Domain.Policies.Temperature
{
    public class HighTemperature : IPackingItemsPolicy
    {
        public IEnumerable<PackingItem> GenerateItems(PolicyData data)
            => new List<PackingItem>
            {
                new("Hat",1),
                new("Sunglasses",1),
                new("Cream With UV filter",1)
            };

        public bool IsApplicable(PolicyData data)
            => data.Temperature > 25D;
    }
}
