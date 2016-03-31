using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class NewStore
    {
        string choice;
        public Inventory inventory = new Inventory();
        public void Storefront()
        {
            Console.WriteLine("Hello, welcome to the walmart from hell, what would you like to purchase?");
            Console.WriteLine("your current inventory is {0} lemons, {1} cups, {2} cups of sugar, and {3} ice cubes.Your current cash is {4}", inventory.lemons, inventory.cups, inventory.sugar, inventory.ice, inventory.cash);
            Console.WriteLine("Would you like to buy lemons, cups, sugar, or ice");
            Console.WriteLine("For sugar, enter [S], for ice enter [I], for lemons enter [L], and for cups enter [C].");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "L":
                    Console.WriteLine("You have purchased 50 lemons for $3.00"); ;
                    BuyLemons();
                    Buymore();
                    break;
                 
                case "I":
                    Console.WriteLine("You have purchased 300 ice cubes for 2.89");
                    BuyIce();
                    Buymore();
                    break;
                case "S":
                    Console.WriteLine("You have purchased 40 cups of sugar for 2.84.");
                    BuySugar();
                    Buymore();
                    break;
                case "C":
                    Console.WriteLine("You have purchased 50 cups for 1.50.");
                    BuyCups();
                    Buymore();
                    break;
                default:
                    Console.WriteLine("Invalid entry please enter reenter a correct letter to pick a shop");
                    Storefront();
                    break;
            }
        }
        
        public void Buymore()
        {
            Console.WriteLine("Would you like to buy more supplies? Y/N");
            choice = Console.ReadLine();
            if (choice.Equals("Y"))
            {
                Storefront();
            }
            else if (choice.Equals("N"))
            {
                
            }
        }

        public int BuyCups()
        {

            inventory.cups = inventory.cups + 50;
            inventory.cash = inventory.cash - 1.50;
            return inventory.cups;
        }
        public int BuyLemons()
        {
            inventory.lemons = inventory.lemons + 50;
            inventory.cash = inventory.cash - 3.00;
            return inventory.lemons;

        }
        public int BuySugar()
        {
            inventory.sugar = inventory.sugar + 40;
            inventory.cash = inventory.cash - 2.84;
            return inventory.sugar;
            
            
        }
        public int BuyIce()
        {
            inventory.ice = inventory.ice + 300;
            inventory.cash = inventory.cash - 2.89;
            return inventory.ice;
        }
        
    }
}
