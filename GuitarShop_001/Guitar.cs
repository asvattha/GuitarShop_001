using System;
using System.Collections.Generic;
using System.Text;

namespace GuitarShop_001
{
    class Guitar: Instrument
    {  
        public Guitar(string serialNum, double price, GuitarSpec guitarSpec): base(serialNum, 
            price, guitarSpec)
        {
            
        }
    }
}
