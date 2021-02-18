using System;

namespace GuessGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretWord = "informatica";
            string guessedWord = "";
            for(int kansen = 3; kansen > 0 && guessedWord != secretWord; kansen --)
            {
                Console.Write("Enter guess: ");
                guessedWord = Console.ReadLine();
            }
            if (guessedWord != secretWord)
            {
                Console.WriteLine("You've lost!");
            }
            else
            {
                Console.WriteLine("You've won!");
            }
            Console.ReadLine();
        }
    }
}