using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    internal class Book : BaseEntity
    {
        public string? Name { get; set; }
        public string? Author { get; set; }
        public Library? Library { get; set; }
    }
}
