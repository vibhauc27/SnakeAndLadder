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

            int count = 0;

            while(position != 100)
            {
                int numOnDie = random.Next(1, 7);
                count++;
                Console.WriteLine($"Num on Die {numOnDie}");
                int options = random.Next(1, 4);

                switch (options)
                {
                    case Ladder:
                        position += numOnDie;
                        position = position > 100 ? position -= numOnDie : position;
                        break;

                    case Snake:
                        position -= numOnDie;
                        position = position < 0 ? 0 : position; //Turnery operator
                        break;

                    case NoPlay:
                        //Console.WriteLine("POSITION " + position);
                        break;


                }
                Console.WriteLine($"Die count : {count} position: {position}");
            }
            Console.WriteLine("POSITION " + position);
        }
    }
}
