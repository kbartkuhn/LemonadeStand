using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Inventory
    {
        public int cups=0;
        public int lemons=0;
        public int sugar=0;
        public int ice= 0;
        public double cash = 20;
        public bool inventoryexists;


        public void purchasesubtract()
        {
            subtractcups();
            subtractice();
            subtractlemons();
            subtractsugar();
            
        }
        public int subtractcups()
        {
            cups = cups - 1;
            return cups;
        }
        public int subtractlemons()
        {
            lemons = lemons - 1;
            return lemons;
        }
        public int subtractice()
        {
            ice = ice - 3;
            return ice;
        }
        public int subtractsugar ()
        {
            sugar = sugar - 2;
            return sugar;
        }


        public bool inventorycheck()
        {
            if (lemons > 0 && ice > 0 && sugar > 1 && cups > 0)
                inventoryexists = true;
            else
                inventoryexists = false;
            return inventoryexists;
        }
    }
    }