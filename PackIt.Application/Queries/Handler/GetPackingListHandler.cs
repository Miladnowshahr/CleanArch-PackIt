using PackIt.Application.DTO;
using PackIt.Domain.Repositories;
using PackIt.Shared.Abstractions.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackIt.Application.Queries.Handler
{
    public class GetPackingListHandler : IQueryHandler<GetPackingList, PackingListDto>
    {
        private readonly IPackingListRepository _repository;

        public GetPackingListHandler(IPackingListRepository repository)
        {
            _repository = repository;
        }

        public async Task<PackingListDto> HandleAsync(GetPackingList query)
        {
            return null;
        }
    }
}
