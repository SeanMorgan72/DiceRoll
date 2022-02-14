using System;

namespace DiceRoll
{
    class Program
    {
        static void Main(string[] args)
        {
            RollDice sixSides = new RollDice(6);
            RollDice twentySides = new RollDice(20);

            Console.WriteLine(sixSides);

            for(int i = 0; i < 20; i++)
            {
                Console.Write(sixSides.Roll() + " ");
            }

            Console.WriteLine("\n\n" + twentySides);

            for (int i = 0; i < 20; i++)
            {
                Console.Write(twentySides.Roll() + " ");
            }
        }
    }
}
