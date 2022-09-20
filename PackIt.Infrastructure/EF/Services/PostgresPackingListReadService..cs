using Microsoft.EntityFrameworkCore;
using PackIt.Application.Service;
using PackIt.Infrastructure.EF.Context;
using PackIt.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackIt.Infrastructure.EF.Services
{
    public class PostgresPackingListReadService : IPackingListReadService
    {
        private readonly DbSet<PackingListReadModel> _packingList;

        public PostgresPackingListReadService(ReadDbContext context)
            => _packingList = context.PackingList;

        public Task<bool> ExistsByNameAsync(string name)
            => _packingList.AnyAsync(pl => pl.Name == name);
    }
}
