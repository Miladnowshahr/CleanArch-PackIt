using PackIt.Domain.Entities;
using PackIt.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackIt.Domain.Repositories
{
    public interface IPackingListRepository
    {
        Task<PackingList> GetAsync(PackingListId id);
        Task AddAsync(PackingList packingList);
        Task UpdateAsync(PackingList packingList);
        Task DeleteAsync(PackingList id);
    }
}
