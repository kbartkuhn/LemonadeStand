using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Game
    {
        public int determine = 1;
        public double pricepercup;
        public Weather weathersim = new Weather();
        public NewStore storefront = new NewStore();


        List<Customer> Customerbuying = new List<Customer>();
        List<Customer> CustomerPurchased = new List<Customer>();

        Customer john = new Customer(.10, 1);
        Customer fernando = new Customer(.20, 1);
        Customer mary = new Customer(.30, 1);
        Customer lucy = new Customer(.40, 1);
        Customer tom = new Customer(.50, 1);
        Customer lary = new Customer(.60, 2);
        Customer thom = new Customer(.70, 2);
        Customer alexa = new Customer(.8, 2);
        Customer julia = new Customer(.90, 3);
        Customer jake = new Customer(1.05, 3);
        Customer ashley = new Customer(1.05, 3);
        Customer ginger = new Customer(1.05, 3);
        Customer penelope = new Customer(1.05, 4);
        Customer ladyfingers = new Customer(1.05, 5);
        Customer manfingers = new Customer(1.05, 5);
        Customer jesus = new Customer(1.05, 6);
        Customer marley = new Customer(1.05, 6);
        Customer peter = new Customer(1.05, 7);
        Customer paul = new Customer(1.05, 7);
        Customer moses = new Customer(1.05, 7);
        Customer god = new Customer(1.05, 7);
        Customer mathias = new Customer(1.05, 7);
        Customer david = new Customer(1.05, 7);
        Customer maria = new Customer(1.05, 7);
        Customer moose = new Customer(1.05, 7);


        public void addcustomers()
        {
            Customerbuying.Add(john);
            Customerbuying.Add(fernando);
            Customerbuying.Add(mary);
            Customerbuying.Add(lucy);
            Customerbuying.Add(tom);
            Customerbuying.Add(lary);
            Customerbuying.Add(thom);
            Customerbuying.Add(alexa);
            Customerbuying.Add(julia);
            Customerbuying.Add(jake);
            Customerbuying.Add(ashley);
            Customerbuying.Add(ginger);
            Customerbuying.Add(penelope);
            Customerbuying.Add(ladyfingers);
            Customerbuying.Add(manfingers);
            Customerbuying.Add(jesus);
            Customerbuying.Add(marley);
            Customerbuying.Add(peter);
            Customerbuying.Add(paul);
            Customerbuying.Add(moses);
            Customerbuying.Add(god);
            Customerbuying.Add(mathias);
            Customerbuying.Add(david);
            Customerbuying.Add(maria);
            Customerbuying.Add(moose);

        }
        public double getprice()
        {
            Console.WriteLine("Hello, please enter how much you would like to charge for a cup of lemonade. Enter in the 0.00 format.");
            pricepercup = double.Parse(Console.ReadLine());
            return pricepercup;
        }


        public void customerwilbuy()
        {
            if (weathersim.weather.Equals(1))
            {
                foreach (Customer customer in Customerbuying)
                {
                    if (pricepercup > customer.money)
                    {
                        Console.WriteLine("This person did not want to purchase lemonade");
                        
                    }
                    else if (pricepercup < customer.money && customer.moodfactor > 1)
                    {
                        Console.WriteLine("The customer purchased your killer lemonade.");
                        
                            storefront.inventory.purchasesubtract();
                            storefront.inventory.cash = storefront.inventory.cash + pricepercup;
                            
                        
                    }

                }

            }
            else if (weathersim.weather.Equals(2))
            {
                foreach (Customer customer in Customerbuying)
                {
                    if (pricepercup > customer.money)
                    {
                        Console.WriteLine("This person did not want to purchase lemonade");
                        
                    }
                    else if (pricepercup < customer.money && customer.moodfactor > 3)
                    {
                        Console.WriteLine("The customer purchased your killer lemonade.");
                        foreach (Customer purchasingcustomer in Customerbuying)
                        {
                            CustomerPurchased.Add(purchasingcustomer);
                            storefront.inventory.purchasesubtract();
                            storefront.inventory.cash = storefront.inventory.cash + pricepercup;
                            
                        }
                    }
                }

            }
            else if (weathersim.weather.Equals(3))
            {
                foreach (Customer customer in Customerbuying)
                {
                    if (pricepercup > customer.money)
                    {
                        Console.WriteLine("This person did not want to purchase lemonade");
                        
                    }
                    else if (pricepercup < customer.money && customer.moodfactor > 4)
                    {
                        Console.WriteLine("The customer purchased your killer lemonade.");
                            storefront.inventory.purchasesubtract();
                            storefront.inventory.cash = storefront.inventory.cash + pricepercup;
                            
                        }
                    }
                }

            
            else if (weathersim.weather.Equals(4))
            {
                foreach (Customer customer in Customerbuying)
                {
                    if (pricepercup > customer.money)
                    {
                        Console.WriteLine("This person did not want to purchase lemonade");
                       
                    }
                    else if (pricepercup < customer.money && customer.moodfactor > 5)
                    {
                        Console.WriteLine("The customer purchased your killer lemonade.");
                        foreach (Customer purchasingcustomer in Customerbuying)
                        {
                            CustomerPurchased.Add(purchasingcustomer);
                            storefront.inventory.purchasesubtract();
                            storefront.inventory.cash = storefront.inventory.cash + pricepercup;
                            
                        }
                    }
                }

            }
            else if (weathersim.weather.Equals(5))
            {
                foreach (Customer customer in Customerbuying)
                {
                    if (pricepercup > customer.money)
                    {
                        Console.WriteLine("This person did not want to purchase lemonade");
                        
                    }
                    else if (pricepercup < customer.money && customer.moodfactor > 6)
                    {
                        Console.WriteLine("The customer purchased your killer lemonade.");
                        foreach (Customer purchasingcustomer in Customerbuying)
                        {
                            CustomerPurchased.Add(purchasingcustomer);
                            storefront.inventory.purchasesubtract();
                            storefront.inventory.cash = storefront.inventory.cash + pricepercup;
                           
                        }
                    }
                }

            }

        }

        public void Startinginfo()
        {
            Console.WriteLine("Hello, welcome to lemonade stand.");
            Console.WriteLine("Your goal is to make as much money as you can in 7 days by selling lemonade at your lemonade stand.");
            Console.WriteLine("Buy cups, lemons, sugar, and ice cubes, then based on the weather and conditions set your price and sell your lemonade at the stand.");
            Console.WriteLine("Try changing up the price based on the weather conditions as well.");
            Console.WriteLine("A1t the end of the game, you'll see how much money you made. Write it down and play again to try and beat your score!");
            Console.WriteLine("To make one cup of lemonade it takes 3 ice cubes, 2 sugars, 1 lemon, and 1 cup.");
        }

        public void endofdaycheck()
        {
            Console.WriteLine("You have made {0} moneys", storefront.inventory.cash);
            Console.WriteLine("your current inventory is {0} lemons, {1} cups, {2} cups of sugar, and {3} ice cubes.Your current cash is {4}", storefront.inventory.lemons, storefront.inventory.cups, storefront.inventory.sugar, storefront.inventory.ice, storefront.inventory.cash);
        }
        
    }



}










