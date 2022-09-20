using PackIt.Shared.Abstractions.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackIt.Application.Commands.Exception
{
    public class PackingListAlredyExistException:PackItException
    {
        public PackingListAlredyExistException(string name):base($"Packing list with name '{name}' already exists.")
        {
            Name = name;
        }

        public string Name { get; }
    }
}
