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

        //public int numOfStrings { get; set; }

        public GuitarSpec(string model, Type type,
            Wood backWood, Wood topWood, Builder builder)
        {
            this.Model = model;
            this.GuitarType = type;
            this.BackWood = backWood;
            this.TopWood = topWood;
            this.GuitarBuilder = builder;
            //this.numOfStrings = numOfStrings;
        }
    }
}
