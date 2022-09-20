using Microsoft.EntityFrameworkCore;
using PackIt.Application.DTO;
using PackIt.Application.Queries;
using PackIt.Infrastructure.EF.Context;
using PackIt.Infrastructure.Models;
using PackIt.Shared.Abstractions.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackIt.Infrastructure.Queries.Handler
{
    internal sealed class SearchPackingListsHandler : IQueryHandler<SearchPackingLists, IEnumerable<PackingListDto>>
    {
        private readonly DbSet<PackingListReadModel> _packingLists;

        public SearchPackingListsHandler(ReadDbContext context)
            => _packingLists = context.PackingList;


        public async Task<IEnumerable<PackingListDto>> HandleAsync(SearchPackingLists query)
        {
            var dbQuery = _packingLists
                .Include(pl => pl.Items)
                .AsQueryable();

            if (query.SearchPhrase is not null)
            {
                dbQuery = dbQuery.Where(pl =>
                    Microsoft.EntityFrameworkCore.EF.Functions.ILike(pl.Name,$"%{query.SearchPhrase}%")
                );
            }
            return await dbQuery.Select(pl=>pl.AsDto())
                .AsNoTracking()
                .ToListAsync();
        }
    }
}
