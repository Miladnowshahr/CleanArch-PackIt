using PackIt.Shared.Abstractions.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackIt.Domain.Exceptions
{
    public class PackingItemNotFoundException : PackItException
    {
        public PackingItemNotFoundException(string itemName) : base($"Packing item {itemName} was not found.")
        {
            ItemName = itemName;
        }

        public string ItemName { get; }
    }
}
