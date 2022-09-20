using PackIt.Domain.Const;
using PackIt.Shared.Abstractions.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackIt.Application.Commands
{
    public record CreatePackingListWithItems(Guid Id,string Name,ushort Days,Gender Gender,LocalizationWithModel Localization ):ICommand;

    public record LocalizationWithModel(string City,string Country);
    

}
