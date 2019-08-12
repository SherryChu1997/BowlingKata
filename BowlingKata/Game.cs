using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingKata
{
    internal class Game
    {
        private int rollCount = 0;
        private int[] rolls = new int[21];//第10局有機會出現第21球
        private int score = 0;

        public void roll(int pins)
        {
            rolls[rollCount] = pins;
            rollCount++;
        }

        public int Totalscore()
        {
            for (int i = 0; i < rolls.Length; i++)
            {
                score += rolls[i];
            }
            return score;
        }
    }
}