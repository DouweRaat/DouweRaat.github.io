using System;

namespace Boodschappen
{
    public class Product
    {
        public string naam;
        public double productPrijs;

        public Product(string nNaam, double nProductPrijs)
        {
            naam = nNaam;
            productPrijs = nProductPrijs;
        }
    }
}
