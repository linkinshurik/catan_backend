using System;
namespace Catan.Interfaces
{
    public interface IGeks
    {
        int Identifier { get; }
    }

    public enum EGeks
    {
        forest = 0,
        pasture = 1,
        arable = 2,
        mine = 3,
        rock = 4,
        desert = 5
    }
}
