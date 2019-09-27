using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            
            int kasutaja;


            Console.WriteLine("Roll a dice 1-6 ");
            kasutaja = Int32.Parse(Console.ReadLine());

            Random randomGenerator = new Random();
            int dice = randomGenerator.Next(1, 7);
            Console.WriteLine(dice);

            if (kasutaja > dice)
            {
                Console.WriteLine($"{kasutaja} Kasutaja number is bigger");
            }

            else if (kasutaja < dice)
            {
                Console.WriteLine($"{dice} PC number is bigger");
            }
            */




            /*
            int userRoll;
            int cpuRoll;
            int rolls = 0;
            int userScore = 0;
            int cpuScore = 0;

            Random rnd = new Random();

            while (rolls < 3)
            {
                userRoll = rnd.Next(1, 7);
                cpuRoll = rnd.Next(1, 7);

                Console.WriteLine($"You rolled {userRoll}, CPu rolled {cpuRoll}");

                if(userRoll > cpuRoll)
                {
                    //userScore = userScore + 1;
                    userScore++;

                }

                else if (userRoll < cpuRoll)
                {
                    cpuScore++;

                }

                else
                {
                    continue;
                }
                // rolls + 1
                rolls++;
                Console.ReadLine();
            }
            
            if (userScore > cpuScore)
            {
                Console.WriteLine("Congratulation! you won!");
            }

            else if (userScore < cpuScore)
            {
                Console.WriteLine("CPU won!");
            }

            else
            {
                Console.WriteLine("Tie, nobody wins");
            }

            Console.WriteLine($"You scored {userScore}, CPU scored {cpuScore}");
            Console.ReadLine();
            */

            /*
            Random rnd = Random();
            int randomNumber = rnd.Next(1, 6);
            Console.WriteLine($"CPU generated {randomNumber}");

            switch(randomNumber)
            {
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;

                default:
                    Console.WriteLine("CPU generated nothing")
               
            }
            */

            Console.WriteLine("Pick a color (red, black, blue): ");
            string answer = Console.ReadLine();

            switch(answer)
            {
                case "red":
                    Console.WriteLine("you are a romantic type");
                break;

                case "black":
                    Console.WriteLine("you are a loner");
                    break;

                case "blue":
                    Console.WriteLine("you are a love with a sea");
                    break;

                default:
                    Console.WriteLine("Cannot recognize the color");
                    break;

            }

            Console.ReadLine();

        }
    }
}
