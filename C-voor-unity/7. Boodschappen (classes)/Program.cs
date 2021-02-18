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
            Product product1 = new Product("Banaan", 0.24);
            Product product2 = new Product("Appel", 0.49);
            Product product3 = new Product("Peer", 0.34);
            Product product4 = new Product("Mandarijn", 0.19);
            Product product5 = new Product("Brood", 3.24);
            Product product6 = new Product("Pindakaas", 5.65);
            Product product7 = new Product("Hagelslag", 3.76);
            Product product8 = new Product("Kaas", 6.43);
            Product product9 = new Product("Appelstroop", 4.23);
            Product product10 = new Product("Jam", 4.98);
            Product[] producten = new Product[10];
            producten[0] = product1;
            producten[1] = product2;
            producten[2] = product3;
            producten[3] = product4;
            producten[4] = product5;
            producten[5] = product6;
            producten[6] = product7;
            producten[7] = product8;
            producten[8] = product9;
            producten[9] = product10;

            Console.WriteLine("We hebben de volgende producten (prijs excl. btw):");
            for (int i = 0; i <= 9; i++)
            {
                Console.WriteLine(producten[i].naam + " voor " + producten[i].productPrijs + " euro");
            }
            for (int teller = 1; teller <= 3;)
            {
                geldig = false;
                Console.WriteLine("");
                Console.WriteLine("Wat is uw " + teller + "e product?");
                product = Console.ReadLine();
                for (int i = 0; i <= 9; i++)
                {
                    if (producten[i].naam == product)
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
                            prijs += producten[productnummer].productPrijs * aantal;
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
