using System;
using Catan.Interfaces;

namespace Catan.Clases
{
	public class Forest: IGeks
    {
        private byte _identifier;
        public GridItem Coordinates { get; }
        public int Token { get; }

        public Forest(GridItem coordinates, int token)
        {
            _identifier = (byte)EGeks.arable;
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
