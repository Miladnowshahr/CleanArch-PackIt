using PackIt.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackIt.Infrastructure.Models
{
    public class PackingListReadModel
    {
        public Guid Id { get; set; } 
        public int Version { get; set; }
        public string Name { get; set; }
        public LocalizationReadModel Localization { get; set; }

        public ICollection<PackingItemReadModel> Items { get; set; }
    }
}
