using PackIt.Application.DTO;
using PackIt.Shared.Abstractions.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackIt.Application.Queries
{
    public class GetPackingList:IQuery<PackingListDto>
    {
        public Guid Id { get; set; }
    }
}
