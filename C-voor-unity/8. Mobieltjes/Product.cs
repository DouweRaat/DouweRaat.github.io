using System;

namespace Mobieltjes
{
    public class Product
    {
        public string type;
        public string model;
        public string OS;
        public double productPrijs;
        public string CEO;

        public Product(string nType, string nModel, string nOS, double nProductPrijs, string nCEO)
        {
            type = nType;
            model = nModel;
            OS = nOS;
            productPrijs = nProductPrijs;
            CEO = nCEO;
        }
    }
}
