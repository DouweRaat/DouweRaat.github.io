using System;

namespace Opdracht_3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            double getal1;
            double getal2;
            double uitkomst;
            string operatie;
            Console.WriteLine("Eerste getal:");
            getal1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Tweede getal:");
            getal2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Operatie (+, -, x of /):");
            operatie = Console.ReadLine();
            if (operatie == "+")
            {
                uitkomst = getal1 + getal2;
                Console.WriteLine(getal1 + "+" + getal2 + "=" + uitkomst);
            }
            else if (operatie == "-")
            {
                uitkomst = getal1 - getal2;
                Console.WriteLine(getal1 + "-" + getal2 + "=" + uitkomst);
            }
            else if (operatie == "x")
            {
                uitkomst = getal1 * getal2;
                Console.WriteLine(getal1 + "x" + getal2 + "=" + uitkomst);
            }
            else if (operatie == "/")
            {
                if (getal2 == 0)
                {
                    Console.WriteLine("Je kan niet door 0 delen.");
                }
                else
                {
                    uitkomst = getal1 / getal2;
                    Console.WriteLine(getal1 + "/" + getal2 + "=" + uitkomst);
                }
            }
        }
    }
}
