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

        public void roll(int pins)
        {
            rolls[rollCount] = pins;
            rollCount++;
        }

        public int Totalscore()
        {
            int score = 0;
            int index = 0;
            for (int frame = 0; frame < 10; frame++)
            {
                if (rolls[index] + rolls[index + 1] == 10)//Spare
                {
                    score = score + 10 + rolls[index + 2];
                    index += 2;
                }
                else
                {
                    score += rolls[index] + rolls[index + 1];
                    index += 2;
                }
            }
            return score;
        }
    }
}