using System;
using System.Collections.Generic;
using System.Text;

namespace GuitarShop_001
{
    class GuitarSpec:InstrumentSpec
    {
        public int numOfStrings { get; set; }

        public GuitarSpec(string model, Type type,
            Wood backWood, Wood topWood, Builder builder, int numOfStrings): base(model, type, backWood, topWood, builder)
        {
            this.numOfStrings = numOfStrings;
        }

        public bool matches(GuitarSpec guitarSpec)
        {
            if (base.matches(guitarSpec))
            {
                if (guitarSpec.numOfStrings == this.numOfStrings)
                {
                    return true;
                }
            }
            return false;
            
        }
    }
}
