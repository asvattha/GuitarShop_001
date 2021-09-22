using System;
using System.Collections.Generic;
using System.Text;

namespace GuitarShop_001
{
    class GuitarSpec
    {
        public string Model { get; set; }
        public Type GuitarType { get; set; }
        public Wood BackWood { get; set; }
        public Wood TopWood { get; set; }
        public Builder GuitarBuilder { get; set; }

        public int numOfStrings { get; set; }
        // size
        public GuitarSpec(string model, Type type,
            Wood backWood, Wood topWood, Builder builder, int numOfStrings)
        {
            this.Model = model;
            this.GuitarType = type;
            this.BackWood = backWood;
            this.TopWood = topWood;
            this.GuitarBuilder = builder;
            this.numOfStrings = numOfStrings;
        }

        public bool matches(GuitarSpec searchGuitar)
        {
            if (!searchGuitar.Model.Equals(this.Model))
            {
                return false;
            }
            if (!searchGuitar.GuitarType.Equals(this.GuitarType))
            {
                return false;
            }
            if (!searchGuitar.BackWood.Equals(this.BackWood))
            {
                return false;
            }

            if (!searchGuitar.TopWood.Equals(this.TopWood))
            {
                return false;
            }
            if (!searchGuitar.GuitarBuilder.Equals(this.GuitarBuilder))
            {
                return false;
            }
            if (!(searchGuitar.numOfStrings == this.numOfStrings))
            {
                return false;
            }
            return true;
        }
    }
}
