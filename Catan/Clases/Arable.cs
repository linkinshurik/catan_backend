using System;
using Catan.Interfaces;

namespace Catan.Clases
{
	public class Arable: IGeks
    {
        private byte _identifier;
        public GridItem Coordinates { get; }
        public int Token { get; } 

        public Arable(GridItem coordinates, int token)
        {
            _identifier = (byte)EGeks.arable;
            Coordinates = coordinates;
            Token = token;
        }

        public int Identifier { 
            get 
            {
                return _identifier;
            } 
        }
    }
}
