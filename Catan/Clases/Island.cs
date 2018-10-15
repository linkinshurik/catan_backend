using System;
using System.Collections.Generic;
using Catan.DBL;
using Catan.Interfaces;

namespace Catan.Clases
{
    public class Island
    {
        public Land GetLand()
        {
            List<EGeks> geks = new List<EGeks> {
                EGeks.forest,
                EGeks.forest,
                EGeks.forest,
                EGeks.forest,
                EGeks.pasture,
                EGeks.pasture,
                EGeks.pasture,
                EGeks.pasture,
                EGeks.arable,
                EGeks.arable,
                EGeks.arable,
                EGeks.arable,
                EGeks.rock,
                EGeks.rock,
                EGeks.rock,
                EGeks.mine,
                EGeks.mine,
                EGeks.mine,
                EGeks.desert,
            };
            geks = Shuffle<EGeks>(geks);
            List<int> shuffleGeksBytes = new List<int>();
            foreach (var item in geks)
            {
                shuffleGeksBytes.Add((int)item);
            }

            //make it correct
            List<int> tokens = new List<int> {2, 3, 3, 4, 4, 5, 5, 6, 6, 8, 8, 9, 9, 10, 10, 11, 11, 12 };
            List<int> shuffledTokens = Shuffle<int>(tokens);

            return new Land()
            {
                Id = Guid.NewGuid(),
                Geks = new List<int>(shuffleGeksBytes),
                GeksToken = new List<int>(shuffledTokens)
            };
        }

        public List<T> Shuffle<T>(List<T> list)
        {
            Random rng = new Random();
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }

            return list;
        }
    }
}
