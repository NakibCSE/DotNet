﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTopics
{
    public class Product : IPurchaseable
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public double Tax { get; set; }

        public Product(string name, double price, double tax)
        {
            Name = name;
            Price = price;
            Tax = tax;
        }

        public double CalculatePriceAfterTax()
        {
            return Price + Tax;
        }
        public double CalculateDiscount(double discount)
        {
            return Price * discount / 100;
        }

    }
}
