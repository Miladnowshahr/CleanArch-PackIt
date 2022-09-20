using PackIt.Shared.Abstractions.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackIt.Application.Commands
{
    public record AddPackingItem(Guid PackingListId, string Name,uint Quantity) : ICommand;

}
