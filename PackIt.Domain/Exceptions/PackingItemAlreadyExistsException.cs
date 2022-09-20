using PackIt.Shared.Abstractions.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackIt.Domain.Exceptions
{
    public class PackingItemAlreadyExistsException:PackItException
    {
        public PackingItemAlreadyExistsException(string listName, string itemName) : base($"Packing list: {listName} already defined item : {itemName}")
        {
            ListName = listName;
            ItemName = itemName;
        }

        public string ListName { get; }
        public string ItemName { get; }
    }
}
