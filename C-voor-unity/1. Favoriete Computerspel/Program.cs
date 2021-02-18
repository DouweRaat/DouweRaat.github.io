using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string game;
            Console.WriteLine("Wat is jouw favoriete computerspel?");
            game = Console.ReadLine();
            Console.WriteLine("Jouw favoriete computerspel is " + game);
        }
    }
}
