using PackIt.Domain.Entities;
using PackIt.Domain.ValueObjects;
using PackIt.Shared.Abstractions.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackIt.Domain.Events
{
    public record PackingItemRemoved(PackingList PackingList,PackingItem PackingItem):IDomainEvent
    {
    }
}
