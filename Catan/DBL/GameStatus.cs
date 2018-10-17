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
        public List<Road> User2_Roads { get; set; }
        public List<Road> User3_Roads { get; set; }
        public List<Road> User4_Roads { get; set; }


        public GameStatus(Guid id)
        {
            Game = id;
            CurrentTurn = id;
            Rubber = 7;
            User1_Raws = new List<int>();
            User2_Raws = new List<int>();
            User3_Raws = new List<int>();
            User4_Raws = new List<int>();
            User1_Develops = new List<int>();
            User2_Develops = new List<int>();
            User3_Develops = new List<int>();
            User4_Develops = new List<int>();
            User1_Villages = new List<int>();
            User2_Villages = new List<int>();
            User3_Villages = new List<int>();
            User4_Villages = new List<int>();
            User1_Towns = new List<int>();
            User2_Towns = new List<int>();
            User3_Towns = new List<int>();
            User4_Towns = new List<int>();
            User1_Roads = new List<Road>();
            User2_Roads = new List<Road>();
            User3_Roads = new List<Road>();
            User4_Roads = new List<Road>();
        }

        public GameStatus ()
        {

        }
    }
}
