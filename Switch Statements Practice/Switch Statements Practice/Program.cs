using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_Statements_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 1;
            int finish = 5;
            while (counter <= finish)
            {

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Yo yo!\nTry to guess my favorite bird!\n\nIt's either a Pukeko, Wandering Albatross, or a Falcon.");
                string bird = Console.ReadLine().ToLower(); /*<---- that allows the use of lowercase letters and uppercase letters*/
                {
                    switch (bird)
                    {
                        case "pukeko":
                        case "wandering albatross":
                            Console.WriteLine("My apologies, that's the wrong answer");
                            Console.ReadLine();
                            break;
                        case "falcon":
                            Console.WriteLine("Good job! Thats the correct answer.");
                            Console.ReadLine();
                            break;
                        default:
                            Console.WriteLine("I don't think that's an option bro. Sorry");
                            Console.ReadLine();
                            break;
                    }
                    Console.Write("Thanks for playing! Continue to the 2nd part: ");
                    Console.WriteLine("What is the Price of the Fruit!!...yeah not an exciting name for a game");
                    Console.ReadLine();

                    Console.WriteLine("Time to play...");
                    Console.WriteLine("What is the Price of the Fruit!");
                    Console.WriteLine("This isn't really a game, it's more of a price calculator");
                    Console.WriteLine("You can choose between: ");
                    Console.WriteLine("Apples\nBananas\nKiwifruit\nOranges");
                    Console.WriteLine("Choose Now: ");

                    string fruit = Console.ReadLine().ToLower();

                    switch (fruit)
                    {
                        case "apples":
                            Console.WriteLine("Apples: $1.25 /kg");
                            Console.ReadLine();
                            break;
                        case "bananas":
                            Console.WriteLine("Bananas: $3.15/kg");
                            Console.ReadLine();
                            break;
                        case "kiwifruit":
                            Console.WriteLine("Kiwifruit: $4.65/kg");
                            Console.ReadLine();
                            break;
                        case "oranges":
                            Console.WriteLine("Oranges: $2.75/kg");
                            Console.ReadLine();
                            break;
                        default:
                            Console.WriteLine("Either you misspelt a fruit to try and trick me or. You inputted a fruit I didn't list.");
                            Console.ReadLine();
                            Console.WriteLine("Would you like to continue seeing the prices? (Y / N)");
                            string input = Console.ReadLine().ToLower();
                            break;

                    }

          
                }
          
            }

        }
    }
}
