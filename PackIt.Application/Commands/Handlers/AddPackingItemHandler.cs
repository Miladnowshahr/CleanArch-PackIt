using PackIt.Application.Commands.Exception;
using PackIt.Domain.Repositories;
using PackIt.Shared.Abstractions.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackIt.Application.Commands.Handlers
{
    public class AddPackingItemHandler : ICommandHandler<AddPackingItem>
    {
        private readonly IPackingListRepository _repository;

        public async Task HandleAsync(AddPackingItem command)
        {
            var packingList = await _repository.GetAsync(command.PackingListId);

            if (packingList is null)
            {
                throw new PackingListNotFoundException(command.PackingListId);
            }

            packingList.PackItem(command.Name);

            await _repository.UpdateAsync(packingList);
        }
    }
}
