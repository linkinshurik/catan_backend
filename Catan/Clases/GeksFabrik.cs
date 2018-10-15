using System;
using Catan.Interfaces;

namespace Catan.Clases
{
    public static class GeksFabrik
    {
        public static IGeks GetGeks(int num, GridItem coordinates, int token) {
           return new GeksItem(num, coordinates, token);
        }
    }
}
