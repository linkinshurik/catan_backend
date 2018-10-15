using System;
using Catan.Interfaces;

namespace Catan.Clases
{
    public class Pasture: IGeks
    {
        private byte _identifier;
        public GridItem Coordinates { get; }
        public int Token { get; }

        public Pasture(GridItem coordinates, int token)
        {
            _identifier = (byte)EGeks.pasture;
            Coordinates = coordinates;
            Token = token;
        }

        public int Identifier
        {
            get
            {
                return _identifier;
            }
        }
    }
}
