using System;
namespace Catan.DBL
{
    public class Game
    {
        public Guid Id { get; set; }
        public Guid User1 { get; set; }
        public Guid User2 { get; set; }
        public Guid User3 { get; set; }
        public Guid User4 { get; set; }
        public Guid Admin { get; set; }
        public bool Active { get; set; }
    }
}
