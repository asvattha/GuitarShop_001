using System;
using System.Collections.Generic;
using System.Text;

namespace GuitarShop_001
{
    class Guitar
    {
        public string SerialNum { get; set; }
        public double Price { get; set; }
      
        public GuitarSpec guitarSpec { get; set; }
        
        public Guitar(string serialNum, double price, GuitarSpec guitarSpec)
        {
            this.SerialNum = serialNum;
            this.Price = price;
            this.guitarSpec = guitarSpec;
            
        }
    }
}
