using System;
using System.Collections.Generic;
using System.Text;

namespace GuitarShop_001
{
    abstract class Instrument
    {
        public string SerialNum { get; set; }
        public double Price { get; set; }

        public InstrumentSpec Spec { get; set; }

        public Instrument(string serialNum, double price, InstrumentSpec spec)
        {
            this.SerialNum = serialNum;
            this.Price = price;
            this.Spec = spec;
        }
    }
}
