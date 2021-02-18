using System;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nummers = new int[20];
            int huidigeGetal = 1;
            int vorigeGetal = 0;
            int nieuweGetal = 0;
            for (int i = 0; i < 20; i++)
            {
                nummers[i] = huidigeGetal;
                Console.WriteLine(nummers[i]);
                nieuweGetal = huidigeGetal + vorigeGetal;
                vorigeGetal = huidigeGetal;
                huidigeGetal = nieuweGetal;
            }
            Console.ReadLine();
        }
    }
}
