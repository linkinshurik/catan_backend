using System;
using Catan.Interfaces;

namespace Catan.Clases
{
    public static class GeksFabrik
    {
        public static IGeks GetGeks(int num, GridItem coordinates, int token) {
            switch((EGeks)num) {
                case EGeks.arable:
                    return new Arable(coordinates, token);
                case EGeks.desert:
                    return new Desert(coordinates, token);
                case EGeks.forest:
                    return new Forest(coordinates, token);
                case EGeks.mine:
                    return new Forest(coordinates, token);
                case EGeks.pasture:
                    return new Pasture(coordinates, token);
                case EGeks.rock:
                    return new Rock(coordinates, token);
                default:
                    throw new Exception();
            }
        }
    }
}
