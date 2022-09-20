using Microsoft.EntityFrameworkCore;
using PackIt.Domain.Entities;
using PackIt.Domain.Repositories;
using PackIt.Domain.ValueObjects;
using PackIt.Infrastructure.EF.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackIt.Infrastructure.EF.Repositories
{
    public class PostgresPackingListRepository : IPackingListRepository
    {
        private readonly DbSet<PackingList> _packingLists;
        private readonly WriteDbContext _writeDbContext;

        public PostgresPackingListRepository(WriteDbContext writeDbContext)
        {
            _packingLists = writeDbContext.packingList;
            _writeDbContext = writeDbContext;
        }

        public async Task AddAsync(PackingList packingList)
        {
            await _packingLists.AddAsync(packingList);
            await _writeDbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(PackingList id)
        {
            _packingLists.Remove(id);
            await _writeDbContext.SaveChangesAsync();
        }



        public async Task<PackingList> GetAsync(PackingListId id)
            => await _packingLists.Include("_items").SingleOrDefaultAsync(pl => pl.Id == id);

        public async Task UpdateAsync(PackingList packingList)
        {
            _packingLists.Update(packingList);
            await _writeDbContext.SaveChangesAsync();
        }
    }
}
