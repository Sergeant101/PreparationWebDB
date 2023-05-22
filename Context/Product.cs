using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticalApps.Context
{
    internal class Product
    {
        public int ProductID {get; set;}
        public string ProductName {get; set;} = null!;
        public decimal UnitPrice {get; set;}
        public short UnitsInStock {get; set;}
        public  int CategoryID {get; set;}
        public bool Discontinued {get; set;}

        
    }
}