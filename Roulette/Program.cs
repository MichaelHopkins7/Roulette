using System;

namespace Roulette
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();
            Wheel roulette = new Wheel();
            do
            {
                Console.WriteLine("");
                Console.WriteLine("Press Enter to spin.");
                Console.ReadLine();
                roulette.Spin(rng);
                roulette.SayNumber();
                roulette.ByEvenOdd();
                roulette.RedBlack();
                roulette.HighLow();
                roulette.ByDozen();
                roulette.Column();
                roulette.Street();
                roulette.Sixes();
                roulette.Splits();
                roulette.Corners();
            }
            while (true);
        }
    }
}
