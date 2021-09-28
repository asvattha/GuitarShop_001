using System;
using System.Collections.Generic;
using System.Text;

namespace GuitarShop_001
{
    class MandolinSpec: InstrumentSpec
    {
        string Style;
        public MandolinSpec(string model, Type type,
            Wood backWood, Wood topWood, Builder builder, string Style): base(model, type, backWood, topWood, builder)
        {
            this.Style = Style;
        }

        public bool matches(MandolinSpec searchMandolin)
        {
            if (base.matches(searchMandolin))
            {
                if (searchMandolin.Style == this.Style)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
