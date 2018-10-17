using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catan.Interfaces
{
    public interface IGame
    {
        Guid Id { get; set; }
        Guid User1 { get; set; }
        Guid User2 { get; set; }
        Guid User3 { get; set; }
        Guid User4 { get; set; }
        bool Active { get; set; }
    }
}
