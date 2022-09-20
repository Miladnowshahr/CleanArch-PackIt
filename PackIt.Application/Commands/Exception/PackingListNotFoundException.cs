using PackIt.Shared.Abstractions.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackIt.Application.Commands.Exception
{
    public class PackingListNotFoundException:PackItException
    {
        public PackingListNotFoundException(Guid id):base($"Cannot be found in Packing List {id}.")
        {
            Id = id;
        }

        public Guid Id { get; }
    }
}
