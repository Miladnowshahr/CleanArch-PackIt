﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackIt.Application.DTO
{
    public class PackingItemDto
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public bool IsPacked { get; set; }
    }
}
