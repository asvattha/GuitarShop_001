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
                if (g.guitarSpec.matches(searchGuitar))
                {
                    searchResults.Add(g);
                }
            }

            return searchResults;
        }
    }
}
