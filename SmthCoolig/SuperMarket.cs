using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmthCoolig
{
    public class SuperMarket
    {
        public List<Products> Products;

        public SuperMarket(Products[] ListOfProducts)
        {
            Products = new List<Products>();
        }
    }
}
