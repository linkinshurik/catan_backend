using System;
using Catan.Interfaces;

namespace Catan.Clases
{
    public class Rock: IGeks
    {
        private byte _identifier;
        public GridItem Coordinates { get; }
        public int Token { get; }

        public Rock(GridItem coordinates, int token)
        {
            _identifier = (byte)EGeks.rock;
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
