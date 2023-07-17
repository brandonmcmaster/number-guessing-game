using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessingGame;

class Program
{
     static void Main(string[] args)
    {
        Random random = new Random();

        int winNum = random.Next(0, 100);

        bool win = false;

        do
        {
            Console.WriteLine("Guess a number between 0 and 100");
            string s = Console.ReadLine();

            int i = int.Parse(s);
            if (i > winNum) 
            {
                Console.WriteLine("Too high, my guy! Try lower.");
            }
            else if (i < winNum)
            {
                Console.WriteLine("Too low, dont'cha know! Try higher.");
            }
            else if (i == winNum)
            {
                Console.WriteLine("WINNER, WINNER!! CHICKEN DINNER!!!!");
                win = true;
            }

            Console.WriteLine();
        } while (win == false);

        Console.WriteLine("CONGRATULATIONS!!");
    }
}