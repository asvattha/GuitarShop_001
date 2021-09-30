using System;
using System.Collections.Generic;
using System.Text;

namespace GuitarShop_001
{
    class Inventory
    {
        List<Instrument> instruments;

        public Inventory()
        {
            instruments = new List<Instrument>();
        }

        public void addInstrument(Instrument i)
        {
            instruments.Add(i);
        }

        public List<Instrument> search(InstrumentSpec searchInstrument)
        {
            List<Instrument> searchResults = new List<Instrument>();
            foreach (Instrument i in instruments) {
                if (i.Spec.matches(searchInstrument))
                {
                    searchResults.Add(i);
                }
            }

            return searchResults;
        }
    }
}
