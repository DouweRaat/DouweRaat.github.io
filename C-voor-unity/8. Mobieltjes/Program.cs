using System;

namespace Mobieltjes
{
    class Program
    {
        static void Main(string[] args)
        {
            const double btwPercentage = 0.21;
            double prijs = 0.00;
            string product;
            bool geldig = false;
            bool klaar = false;
            int aantal;
            int productnummer = 0;
            int teller = 1;
            Product product1 = new Product("iPhone", "iPhone XS", "Apple IOS", 676.86, "Steve Jobs");
            Product product2 = new Product("Samsung", "Galaxy S7", "Android", 231.40, "Kim Hyun-suk, Koh Dong-Jin en Kim Ki Nam");
            Product product3 = new Product("Google Pixel", "Pixel 3", "Chrome OS", 247.11, "Sundar Pichai");
            Product[] producten = new Product[3];
            producten[0] = product1;
            producten[1] = product2;
            producten[2] = product3;

            Console.WriteLine("We hebben de volgende producten (prijs excl. btw en vanaf 2000 euro krijgt u 10% korting):");
            for (int i = 0; i <= 2; i++)
            {
                Console.WriteLine("");
                Console.WriteLine("Type:  " + producten[i].type);
                Console.WriteLine("Model: " + producten[i].model);
                Console.WriteLine("OS:    " + producten[i].OS);
                Console.WriteLine("Prijs: " + producten[i].productPrijs);
                Console.WriteLine("CEO:   " + producten[i].CEO);
            }
            while (!klaar)
            {
                geldig = false;
                Console.WriteLine("");
                Console.WriteLine("Wat is uw " + teller + "e product?");
                product = Console.ReadLine();
                for (int i = 0; i <= 2; i++)
                {
                    if (producten[i].model == product)
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
                            groterdannul = true;
                            Console.WriteLine("Wil je meer mobieltjes kopen? (voer ja in als je dat wil)");
                            string jaOfNee = Console.ReadLine();
                            if (jaOfNee == "ja")
                            {
                                teller++;
                            }
                            else
                            {
                                klaar = true;
                            }
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
            if (prijs > 2000)
            {
                Console.WriteLine("De prijs zonder korting is " + prijs + " euro.");
                prijs = prijs * 0.9;
                Console.WriteLine("U krijgt 10% korting.");
            }
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
