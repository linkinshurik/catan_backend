using System;
namespace Catan.DBL
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Guid Token { get; set; }
    }
}