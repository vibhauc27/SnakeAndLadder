using System;

namespace SnakeandLadder1 
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initializing constant
            const int Ladder = 1;
            const int NoPlay = 2;
            const int Snake = 3;

            //UC1
            int position = 0;
            Random random = new Random();

            while(position <= 100)
            {
                int numOnDie = random.Next(1, 7);
                Console.WriteLine($"Num on Die {numOnDie}");
                int options = random.Next(1, 4);

                switch (options)
                {
                    case Ladder:
                        position += numOnDie;
                        break;

                    case Snake:
                        position -= numOnDie;
                        break;

                    case NoPlay:
                        Console.WriteLine("POSITION " + position);
                        break;


                }
                Console.WriteLine("POSITION " + position);


            }


        }
    }

            
}
