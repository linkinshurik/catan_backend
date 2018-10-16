using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Catan.Clases;

namespace Catan.DBL
{
    public class GameStatus
    {
        [Key]
        public Guid Game { get; set; }
        public Guid CurrentTurn { get; set; }
        public int Rubber { get; set; }
        public List<int> User1_Raws { get; set; }
        public List<int> User2_Raws { get; set; }
        public List<int> User3_Raws { get; set; }
        public List<int> User4_Raws { get; set; }
        public List<int> User1_Develops { get; set; }
        public List<int> User2_Develops { get; set; }
        public List<int> User3_Develops { get; set; }
        public List<int> User4_Develops { get; set; }
        public List<int> User1_Villages { get; set; }
        public List<int> User2_Villages { get; set; }
        public List<int> User3_Villages { get; set; }
        public List<int> User4_Villages { get; set; }
        public List<int> User1_Towns { get; set; }
        public List<int> User2_Towns { get; set; }
        public List<int> User3_Towns { get; set; }
        public List<int> User4_Towns { get; set; }
        public List<Road> User1_Roads { get; set; }
    }
}
