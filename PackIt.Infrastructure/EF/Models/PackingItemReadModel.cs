using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackIt.Infrastructure.Models
{
    public class PackingItemReadModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public bool IsPacked { get; set; }

        public PackingListReadModel PackingList { get; set; }
    }
}
