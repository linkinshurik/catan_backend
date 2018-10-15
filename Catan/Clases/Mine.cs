using System;
using Catan.Interfaces;

namespace Catan.Clases
{
    public class Mine: IGeks
    {
        private byte _identifier;
        public GridItem Coordinates { get; }
        public int Token { get; }

        public Mine(GridItem coordinates, int token)
        {
            _identifier = (byte)EGeks.mine;
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
