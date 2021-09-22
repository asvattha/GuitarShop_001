using System;
using System.Collections.Generic;

namespace GuitarShop_001
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();

            initializeInventory(inventory);

            GuitarSpec customerChoice = new GuitarSpec("stratocaster", Type.ACOUSTIC, Wood.ROSEWOOD, Wood.MAPLE, Builder.FENDER, 6);

            List<Guitar> results = inventory.search(customerChoice);

            if(results.Count != 0)
            {
                Console.WriteLine("Congratulations, we found your choice of guitars");
            }
            else
            {
                Console.WriteLine("Sorry, we have no guitar of your choice in our inventory");
            }
        }

        public static void initializeInventory(Inventory inventory)
        {
            inventory.addGuitar(new Guitar("A124", 569.99, new GuitarSpec("stratocaster", Type.ACOUSTIC, Wood.ROSEWOOD, Wood.MAPLE, Builder.FENDER, 6)));
            inventory.addGuitar(new Guitar("E456", 789.99, new GuitarSpec("telecaster", Type.ELECTRIC,  Wood.ALDER, Wood.MAHOGANY, Builder.MARTIN, 12)));
        }
    }
}
