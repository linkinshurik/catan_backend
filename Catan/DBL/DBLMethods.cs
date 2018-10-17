using System;
using System.Collections.Generic;
using System.Linq;
using Catan.Clases;
using Catan.Interfaces;

namespace Catan.DBL
{
    public static class DBLMethods
    {
        public static Land SaveLand(Land land) {
            using (DatabaseLayer db = new DatabaseLayer())
            {
                db.Add(land);
                db.SaveChanges();
            }

            return land;
        }

        public static User AddUser(User user) {
            using (DatabaseLayer db = new DatabaseLayer())
            {
                db.Add(user);
                db.SaveChanges();
            }

            return user;
        }

        public static bool JoinGame(IJoin join)
        {
            //implement creating the game and joining
            return true;
        }

        public static List<IGeks> GetCurrentBoard(Guid id) {
            using (DatabaseLayer db = new DatabaseLayer())
            {
                var land = db.Lands.First((l) => l.Id == id);

                List<IGeks> gridList = new List<IGeks>();

                for (int i = 0, n = 0; i < 19; i++)
                {
                    if (land.Geks[i] != (int)EGeks.desert)
                    {
                        gridList.Add(GeksFabrik.GetGeks(land.Geks[i], IslandGrid.GetGreedItem(i), land.GeksToken[n]));
                        n++;
                    }
                    else
                    {
                        gridList.Add(GeksFabrik.GetGeks(land.Geks[i], IslandGrid.GetGreedItem(i), 7));
                    }
                }

                return gridList;
            }
        }

        public static GameStatus GetGameStatus(Guid id)
        {
            using (DatabaseLayer db = new DatabaseLayer())
            {
                var gameStatus = db.GameLogs.FirstOrDefault((l) => l.Game == id);

                if (gameStatus == null)
                {
                    gameStatus = new GameStatus(id);
                }
                db.Add(gameStatus);
                db.SaveChanges();

                return gameStatus;
            }
        }
    }
}
