using PackIt.Domain.Events;
using PackIt.Domain.Exceptions;
using PackIt.Domain.ValueObjects;
using PackIt.Shared.Abstractions.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackIt.Domain.Entities
{
    public class PackingList:AggregateRoot<PackingListId>
    {
        
        private PackingListName _name;
        private Localization _localization;

        private readonly LinkedList<PackingItem> _items = new();

        internal PackingList(PackingListId id,PackingListName name, Localization localization)
        {
            Id = id;
            _name = name;
            _localization = localization;
           
        }

        public void AddItem(PackingItem item)
        {
            var alreadyExist = _items.Any(w => w.Name == item.Name);
            if (alreadyExist)
                throw new PackingItemAlreadyExistsException(_name, item.Name);

            _items.AddLast(item);
            AddEvent(new PackingItemAdded(this, item));
        }

        public void AddItems(IEnumerable<PackingItem> items) => items.ToList().ForEach(x => AddItem(x));

        public void PackItem(string itemName)
        {
            var item = GetItem(itemName);
            var packedItem = item with { IsPacked = true };
            _items.Find(item).Value = packedItem;
            AddEvent(new PackingItemPacked(this, item));
        }

        public void RemoveItem(string itemName)
        {
            var item = GetItem(itemName);
            _items.Remove(item);
            AddEvent(new PackingItemRemoved(this,item)) ;
        }
        private PackingItem GetItem(string itemName)
        {
            var item = _items.SingleOrDefault(s => s.Name == itemName);

            if (item is null)
            {
                throw new PackingItemNotFoundException(itemName);
            }
            return item;
        }

    } 
}
