using System;
namespace Catan.Clases
{
    public static class Dice
    {
        public static int ThrowDice() {
            Random rnd = new Random();
            return rnd.Next(1, 7);
        }

        public static int[] ThrowTwoDice() {
            int[] result = new int[] { Dice.ThrowDice(), Dice.ThrowDice() };
            return result;
        }
    }
}
