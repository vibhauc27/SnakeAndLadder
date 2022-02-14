using System;

namespace SnakeandLadder1 
{
    class Program
    {
        static void Main(string[] args)
        {

            //UC1
            int position = 0;
            Random random = new Random();

            int numOnDie = random.Next(1, 7);
            Console.WriteLine($"Num on Die {numOnDie}");
        }
    }

            
}
