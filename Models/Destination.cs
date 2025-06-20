﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Destination
    {
        public string Name { get; set; }
        public double BasePrice { get; set; }
        public string Country { get; set; }

        public Destination() { }

        public Destination(string name, double basePrice, string country)
        {
            Name = name;
            BasePrice = basePrice;
            Country = country;
        }

        public double PriceWithTax()
        {
            return BasePrice * 1.15; // 15% impuesto turístico 
        }
    }
}
