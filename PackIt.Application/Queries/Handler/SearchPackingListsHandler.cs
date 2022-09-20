using PackIt.Application.DTO;
using PackIt.Shared.Abstractions.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackIt.Application.Queries.Handler
{
    public class SearchPackingListsHandler : IQueryHandler<SearchPackingLists, IEnumerable<PackingListDto>>
    {
        
        public Task<IEnumerable<PackingListDto>> HandleAsync(SearchPackingLists query)
        {
            throw new NotImplementedException();
        }
    }
}
