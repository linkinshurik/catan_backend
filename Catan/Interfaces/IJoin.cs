using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catan.Interfaces
{
    public interface IJoin
    {
        Guid GameId { get; set; }
        Guid UserId { get; set; }
    }
}
