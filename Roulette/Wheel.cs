using System;
using System.Collections.Generic;
using System.Text;

namespace Roulette
{
    class Wheel
    {
        string[] number;
        string[] color;
        int num;

        public Wheel()
        {
            this.number = new string[] {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14",
                "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32",
                "33", "34", "35", "36", "00"};

            this.color = new string[] {"Green", "Red", "Black", "Red", "Black", "Red", "Black", "Red", "Black", "Red",
                "Black", "Black", "Red", "Black", "Red", "Black", "Red", "Black", "Red", "Red", "Black", "Red", "Black",
                "Red", "Black", "Red", "Black", "Red", "Black", "Black", "Red", "Black", "Red", "Black", "Red", "Black",
                "Red", "Green"};
            return;
        }

        public void Spin(Random rng)
        {
            this.num = rng.Next(0, 37);
            return;
        }

        public void SayNumber()
        {
            Console.WriteLine($"The winning slot is {number[num]} {color[num]}.");
            return;
        }

        public void ByEvenOdd()
        {
            if (num == 0 || num == 37)
            {
                return;
            }
            else if (num%2 == 0)
            {
                Console.WriteLine("Evens win.");
            }
            else if (num%2 == 1)
            {
                Console.WriteLine("Odds win.");
            }
            return;
        }

        public void RedBlack()
        {
            int[] black = { 2, 4, 6, 8, 10, 11, 13, 15, 17, 20, 22, 24, 26, 28, 29, 31, 33, 36 };
            bool isRed = true;
            int n = 0;
            do
            {
                if (black[n] == num)
                {
                    Console.WriteLine("Black wins.");
                    isRed = false;
                }
                n++;
            }
            while (n < 18 && isRed);

            if (num == 0 || num == 37)
            {
                return;
            }
            else if (isRed)
            {
                Console.WriteLine("Red wins.");
            }
            return;
        }

        public void HighLow()
        {
            if (num >= 1 && num <=18)
            {
                Console.WriteLine("Lows win.");
            }
            else if (num >= 19 && num <= 36)
            {
                Console.WriteLine("Highs win.");
            }
            return;
        }

        public void ByDozen()
        {
            if (num >= 1 && num <= 12)
            {
                Console.WriteLine("The 1st 12 wins.");
            }
            else if (num >=13 && num <= 24)
            {
                Console.WriteLine("The 2nd 12 wins.");
            }
            else if (num >= 25 && num <= 36)
            {
                Console.WriteLine("The 3rd 12 wins.");
            }
            return;
        }

        public void Column()
        {
            if (num == 0 || num == 00)
            {
                return;
            }
            else if (num%3 == 1)
            {
                Console.WriteLine("The 1st column wins.");
            }
            else if (num % 3 == 2)
            {
                Console.WriteLine("The 2nd column wins.");
            }
            else if (num % 3 == 0)
            {
                Console.WriteLine("The 3rd column wins.");
            }
            return;
        }

        public void Street()
        {
            if (num == 0 || num == 00)
            {
                return;
            }
            else if (num % 3 == 1)
            {
                Console.WriteLine($"Street {num}, {num + 1}, and {num + 2}.");
            }
            else if (num % 3 == 2)
            {
                Console.WriteLine($"Street {num - 1}, {num}, and {num + 1}.");
            }
            else if (num % 3 == 0)
            {
                Console.WriteLine($"Street {num - 2}, {num - 1}, and {num}.");
            }
            return;
        }

        public void Sixes()
        {
            if (num == 0 || num == 00)
            {
                return;
            }
            else if (num <= 3)
            {
                Console.WriteLine("Double street 1, 2, 3, 4, 5, and 6 wins.");
            }
            else if (num % 3 == 1)
            {
                Console.WriteLine($"Double Street {num - 3}, {num - 2}, {num - 1}, {num}, {num + 1}, and {num + 2} wins.");
                Console.WriteLine($"And Double Street {num}, {num + 1}, {num + 2}, {num + 3}, {num + 4}, and {num + 5} wins.");
            }
            else if (num % 3 == 2)
            {
                Console.WriteLine($"Double street {num - 4}, {num - 3}, {num - 2}, {num - 1}, {num}, and {num + 1} wins.");
                Console.WriteLine($"And Double street {num - 1}, {num}, {num + 1}, {num + 2}, {num + 3}, and {num + 4}  wins.");
            }
            else if (num % 3 == 0)
            {
                Console.WriteLine($"Double street {num - 5}, {num - 4}, {num - 3}, {num - 2}, {num - 1}, and {num} wins.");
                Console.WriteLine($"And Double street {num - 2}, {num - 1}, {num}, {num + 1}, {num + 2}, and {num + 3} wins.");
            }
            return;
        }

        public void Splits()
        {
            if (num == 0 || num == 00)
            {
                return;
            }
            else if (num == 1)
            {
                Console.WriteLine("Splits 1/2 and 1/4 win.");
            }
            else if (num == 2)
            {
                Console.WriteLine("Splits 1/2, 2/3, and 2/5 win.");
            }
            else if (num == 3)
            {
                Console.WriteLine("Splits 2/3 and 3/6 win.");
            }
            else if (num % 3 == 1)
            {
                Console.WriteLine($"Splits {num - 3}/{num}, {num}/{num + 1}, and {num}/{num + 3}.");
            }
            else if (num % 3 == 2)
            {
                Console.WriteLine($"Splits {num - 3}/{num}, {num-1}/{num}, {num}/{num + 1}, and {num}/{num + 3}.");
            }
            else if (num % 3 == 0)
            {
                Console.WriteLine($"Splits {num - 3}/{num}, {num - 1}/{num}, and {num}/{num + 3}.");
            }
            return;
        }

        public void Corners()
        {
            if (num == 0 || num == 00)
            {
                return;
            }
            else if (num == 1)
            {
                Console.WriteLine("Corner 1/2/4/5 wins.");
            }
            else if (num == 2)
            {
                Console.WriteLine("Corner 1/2/4/5 and 2/3/5/6 win.");
            }
            else if (num == 3)
            {
                Console.WriteLine("Corner 2/3/5/6 wins.");
            }
            else if (num % 3 == 1)
            {
                Console.WriteLine($"Corners {num - 3}/{num - 2}/{number}/{num + 1} and {num}/{num + 1}/{num + 3}/{num + 4}.");
            }
            else if (num % 3 == 2)
            {
                Console.WriteLine($"Corners {num - 4}/{num -3}/{num -1}/{num}, {num - 3}/{num - 2}/{num}/{num + 1}, {num - 1}/{num}/{num + 2}/{num + 3}, and {num}/{num + 1}/{num + 3}/{num + 4}.");
            }
            else if (num % 3 == 0)
            {
                Console.WriteLine($"Corners {num - 4}/{num - 3}/{num - 1}/{num} and {num - 1}/{num}/{num + 2}/{num + 3}");
            }
            return;
        }
    }
}
    