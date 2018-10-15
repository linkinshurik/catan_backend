using System;
using System.Collections.Generic;

namespace Catan.DBL
{
    public class Land
    {
        public Guid Id { get; set; }
        public List<int> Geks { get; set; }
        public List<int> GeksToken { get; set; }
    }
}
