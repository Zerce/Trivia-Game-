/*
 * Trivia Application by Rigoberto Cervantes
 * Introduction to Programming, 9/29/20
 */
using System;
using static System.Console;
namespace Trivia
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();

            Clear();

            //end message
            WriteLine("Good job!");

            //instructions to exit
            WriteLine("Press enter to exit the game.");
            ReadKey();
        }
    }
}