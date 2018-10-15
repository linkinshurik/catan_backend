using System;
using Catan.Interfaces;

namespace Catan.Clases
{
	public class Desert: IGeks
    {
        private byte _identifier;
        public GridItem Coordinates { get; }
        public int Token { get; }

        public Desert(GridItem coordinates, int Token)
        {
            _identifier = (byte)EGeks.desert;
            Coordinates = coordinates;
            this.Token = Token;
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
