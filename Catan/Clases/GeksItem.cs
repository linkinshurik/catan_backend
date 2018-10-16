using System;
using Catan.Interfaces;

namespace Catan.Clases
{
    public class GeksItem: IGeks
    {
        public EGeks Identifier { get; }
        public GridItem Coordinates { get; }
        public int Token { get; }

        public GeksItem(int num, GridItem coordinates, int token)
        {
            Identifier = (EGeks)num;
            Coordinates = coordinates;
            Token = token;
        }

        public Boolean BuildColony(Colony colony) {
            return true;
        }
    }
}
