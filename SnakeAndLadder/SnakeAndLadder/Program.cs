using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class Program
    {
          
        //Constants 
        public const int NO_PLAY = 0;
        public const int LADDER = 1;
        public const int SNAKE = 2;
        public const int FINAL = 100;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the game of snake and ladder");
            Console.WriteLine();
            Console.WriteLine("Single Player mode: Starting position 0");
            Console.WriteLine("GAME START");

            //Variables
            int position = 0;
            int count = 0;

            //creatting random object
            Random die = new Random();
            Random options = new Random();

            while (position < FINAL)
            {
                int dice = die.Next(1, 7);
                Console.WriteLine("The number on this die roll is: " + dice);
                int opt = options.Next(0, 3);

                if (opt == NO_PLAY)
                {
                    Console.WriteLine("No play: Player in same position-- " + position);
                }
                else if (opt == LADDER)
                {
                    position = position + dice;
                    if (position > 100)
                    {
                        Console.WriteLine("Try Again, throw exceeded 100!");
                        position = position - dice;
                    }
                    else
                    {
                        Console.WriteLine("Ladder!!! new postion " + position);
                    }

                }
                else
                {
                    position = position - dice;
                    Console.WriteLine("Snake!!! new position-- " + position);
                }

                if (position < 0)
                {
                    position = 0;
                }
                Console.WriteLine("The position after the {0} die roll is {1} ", count, position);
            }
            Console.WriteLine("The number of times the die thrown is: " + count);
        }
    }
}
