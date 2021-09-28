using System;
using System.Collections.Generic;
using System.Text;

namespace GuitarShop_001
{
    abstract class InstrumentSpec
    {
        public string Model { get; set; }
        public Type Type { get; set; }
        public Wood BackWood { get; set; }
        public Wood TopWood { get; set; }
        public Builder Builder { get; set; }
        public InstrumentSpec(string model, Type type,
            Wood backWood, Wood topWood, Builder builder)
        {
            this.Model = model;
            this.Type = type;
            this.BackWood = backWood;
            this.TopWood = topWood;
            this.Builder = builder;
        }

        public bool matches(InstrumentSpec searchInstrument)
        {
            if (!searchInstrument.Model.Equals(this.Model))
            {
                return false;
            }
            if (!searchInstrument.Type.Equals(this.Type))
            {
                return false;
            }
            if (!searchInstrument.BackWood.Equals(this.BackWood))
            {
                return false;
            }

            if (!searchInstrument.TopWood.Equals(this.TopWood))
            {
                return false;
            }
            if (!searchInstrument.Builder.Equals(this.Builder))
            {
                return false;
            }
            return true;
        }

    }
}
