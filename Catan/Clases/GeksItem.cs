using System;
using Catan.Interfaces;

namespace Catan.Clases
{
    public class GeksItem: IGeks
    {
        private EGeks _identifier;
        public GridItem Coordinates { get; }
        public int Token { get; }

        public GeksItem(int num, GridItem coordinates, int token)
        {
            _identifier = (EGeks)num;
            Coordinates = coordinates;
            Token = token;
        }

        public EGeks Identifier
        {
            get
            {
                return _identifier;
            }
        }
    }
}
