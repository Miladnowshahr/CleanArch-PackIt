using PackIt.Application.DTO;
using PackIt.Shared.Abstractions.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackIt.Application.Queries
{
    public class SearchPackingLists:IQuery<IEnumerable<PackingListDto>>
    {
        public string SearchPhrase { get; set; }
    }
}
