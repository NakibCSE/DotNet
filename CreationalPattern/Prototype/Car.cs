﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace CreationalPattern.Prototype
{
    public class Car
    {
        public string Model { get; set; }
        public double Speed { get; set; }
        public double Fuel { get; set; }

        #region Prototype pattern : If we need multiple copy of instance, instead of creating the instance again and again. 
        public Car Copy()
        {
            return new Car { Fuel = Fuel, Model = Model };
        }
        #endregion
    }
}
