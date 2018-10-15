using System;
using System.Collections.Generic;

namespace Catan.Clases
{
    public static class IslandGrid
    {
        private static List<int[]> gridStructure = new List<int[]>{
            new int[6] { 1, 5, 9, 13, 8, 4 },
            new int[6] { 2, 6, 10, 14, 9, 5 },
            new int[6] { 3, 7, 11, 15, 10, 6 },
            new int[6] { 8, 13, 18, 23, 17, 12 },
            new int[6] { 9, 14, 19, 24, 18, 13 },
            new int[6] { 10, 15, 20, 25, 19, 14 },
            new int[6] { 11, 16, 21, 26, 20, 15 },
            new int[6] { 17, 23, 29, 34, 28, 22 },
            new int[6] { 18, 24, 30, 35, 29, 23 },
            new int[6] { 19, 25, 31, 36, 30, 24 },
            new int[6] { 20, 26, 32, 37, 31, 25 },
            new int[6] { 21, 27, 33, 38, 32, 26 },
            new int[6] { 29, 35, 40, 44, 39, 34 },
            new int[6] { 30, 36, 41, 45, 40, 35 },
            new int[6] { 31, 37, 42, 46, 41, 36 },
            new int[6] { 32, 38, 43, 47, 42, 37 },
            new int[6] { 40, 45, 49, 52, 48, 44 },
            new int[6] { 41, 46, 50, 53, 49, 45 },
            new int[6] { 42, 47, 51, 54, 50, 46 }
    };

        //private static 
        public static GridItem GetGreedItem(int index) {

            return new GridItem(gridStructure[index]);
        }
    }

    public class GridItem
    {
        public int n { get; }
        public int ne {get; }
        public int se { get; }
        public int s { get; }
        public int sw { get; }
        public int nw {get; }

        public GridItem(int[] coordinates) {
            n = coordinates[0];
            ne = coordinates[1];
            se = coordinates[2];
            s = coordinates[3];
            sw = coordinates[4];
            nw = coordinates[5];
        }
    }

}

/* GRID
 *                      1       2       3
 *                  4       5       6       7
 *                     (1)     (2)      (3)
 *                  8       9       10      11
 *              12      13      14      15      16
 *                  (4)     (5)     (6)     (7)
 *              17      18      19      20      21
 *          22      23      24      25      26      27
 *              (8)     (9)    (10)    (11)    (12)
 *          28      29      30      31      32      33
 *              34      35      36      37      38
 *                 (13)    (14)    (15)    (16)
 *              39      40      41      42      43
 *                  44      45      46      47
 *                     (17)    (18)    (19)
 *                  48      49      50      51
 *                      52      53      54
 */