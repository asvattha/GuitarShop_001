using System;
using System.Collections.Generic;
using System.Text;

namespace GuitarShop_001
{
    class Inventory
    {
        List<Guitar> guitars;

        public Inventory()
        {
            guitars = new List<Guitar>();
        }

        public void addGuitar(Guitar g)
        {
            guitars.Add(g);
        }

        public List<Guitar> search(GuitarSpec searchGuitar)
        {
            List<Guitar> searchResults = new List<Guitar>();
            foreach (Guitar g in guitars) {
                if (!searchGuitar.Model.ToUpper().Equals(g.guitarSpec.Model.ToUpper()) && !searchGuitar.Model.Equals("")
                    && searchGuitar.Model != null)
                {
                    continue;
                }
                if (!searchGuitar.GuitarType.Equals(g.guitarSpec.GuitarType) && !searchGuitar.GuitarType.Equals(""))
                {
                    continue;
                }
                if (!searchGuitar.BackWood.Equals(g.guitarSpec.BackWood) && !searchGuitar.BackWood.Equals(""))
                {
                    continue;
                }

                if (!searchGuitar.TopWood.Equals(g.guitarSpec.TopWood) && !searchGuitar.TopWood.Equals(""))
                {
                    continue;
                }
                if (!searchGuitar.GuitarBuilder.Equals(g.guitarSpec.GuitarBuilder) && !searchGuitar.GuitarBuilder.Equals(""))
                {
                    continue;
                }
                searchResults.Add(g);
            }

            return searchResults;
        }
    }
}
