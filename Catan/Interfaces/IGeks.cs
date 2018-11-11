using System;
namespace Catan.Interfaces
{
    public interface IGeks
    {
        EGeks Identifier { get; }
    }

    public enum EGeks
    {
        lumber = 0,
        sheep = 1,
        wheat = 2,
        brick = 3,
        ore = 4,
        desert = 5
    }

    public enum Colony
    {
        village = 0,
        town = 1
    }
}
