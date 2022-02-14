using System;

namespace DiceRoll
{
    internal class RollDice
    {
        private Random random;
        private int sidesCount;
        public RollDice(int sidesCount)
        {
            random = new Random();
            this.sidesCount = sidesCount;
        }

        public int Roll()
        {
            return random.Next(1, sidesCount + 1);
        }

        public override string ToString()
        {
            return String.Format("Rolling a die with {0} sides", sidesCount);
        }
    }
}