using System;

namespace Boodschappen
{
    
    
    class Program
    {
        static void Main(string[] args)
        {
            const double btwPercentage = 0.21;
            double prijs = 0.00;
            string product;
            bool geldig = false;
            int aantal;
            int productnummer = 0;
            string[] producten = { "Banaan", "Appel", "Peer", "Mandarijn", "Brood", "Pindakaas", "Hagelslag", "Kaas", "Appelstroop", "Jam"};
            double[] prijzen = {0.24, 0.49, 0.34, 0.19, 3.24, 5.65, 3.76, 6.43, 4.23, 4.98};

            Console.WriteLine("We hebben de volgende producten (prijs excl. btw):");
            for (int i = 0; i <= 9; i++)
            {
                Console.WriteLine(producten[i] + " voor " + prijzen[i] + " euro");
            }
            for (int teller = 1; teller <= 3;)
            {
                Console.WriteLine("");
                Console.WriteLine("Wat is uw " + teller + "e product?");
                product = Console.ReadLine();
                for (int i = 0; i <= 9; i++)
                {
                    if (producten[i] == product)
                    {
                        geldig = true;
                        productnummer = i;
                    }
                }
                if (geldig)
                {
                    bool groterdannul = false;
                    while (!groterdannul)
                    {
                        Console.WriteLine("Hoeveel wil je hiervan?");
                        aantal = Convert.ToInt32(Console.ReadLine());
                        if (aantal > 0)
                        {
                            prijs += prijzen[productnummer] * aantal;
                            teller++;
                            groterdannul = true;
                        }
                        else
                        {
                            Console.WriteLine("Voer een getal in dat groter is dan 0.");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Dat hebben wij niet.");
                }
            }
            double btw = getBtw(prijs, btwPercentage);
            prijs = Math.Round(prijs, 2);
            btw = Math.Round(btw, 2);
            Console.WriteLine("");
            Console.WriteLine("Excl btw kost dat " + prijs + " euro.");
            Console.WriteLine("Er komt nog " + btw + " euro btw bij.");
            prijs += btw;
            prijs = Math.Round(prijs, 2);
            Console.WriteLine("In totaal is dat " + prijs + " euro.");
        }
        public static double getBtw(double prijs, double btwPercentage)
        {
            double btw = prijs * btwPercentage;
            return btw;
        }
    }
}
