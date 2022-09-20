using PackIt.Domain.ValueObjects;
using PackIt.Shared.Abstractions.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackIt.Application.Commands
{
    public record RemovePackingItem(PackingListId PackingListId,string Name):ICommand;
    
}
