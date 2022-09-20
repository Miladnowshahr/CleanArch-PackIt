using Microsoft.EntityFrameworkCore;
using PackIt.Application.DTO;
using PackIt.Application.Queries;
using PackIt.Domain.Repositories;
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
    internal sealed class GetPackingListHandler : IQueryHandler<GetPackingList, PackingListDto>
    {
        private readonly DbSet<PackingListReadModel> _packingLists;

        public GetPackingListHandler(ReadDbContext context)
            => _packingLists = context.PackingList;


        public async Task<PackingListDto> HandleAsync(GetPackingList query)
        => _packingLists.Include(pl => pl.Items)
            .Where(pl => pl.Id == query.Id)
            .Select(pl => pl.AsDto()).AsNoTracking().SingleOrDefault();
    }
}
