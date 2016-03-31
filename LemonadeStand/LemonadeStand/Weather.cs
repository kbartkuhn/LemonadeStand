using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Weather
    {
        public int weather;

        public int getweather()
        {

            Random rand = new Random();
            int weathergenerator = rand.Next(1, 5);

            if (weathergenerator.Equals(1))
            {
                weather = 1;
            }

            else if (weathergenerator.Equals(2))
            {
                weather = 2;
            }

            else if (weathergenerator.Equals(3))
            {
                weather = 3;
            }

            else if (weathergenerator.Equals(4))
            {
                weather = 4;
            }
            else if (weathergenerator.Equals(5))
            {
                weather = 5;
            }

            return weather;

        }
      public void displayweather(int weather)
        {
            if (weather.Equals(1))
            {
                Console.WriteLine("It is going to be hot and sunny today with a high of 85");
            }

            else if (weather.Equals(2))
            {
                Console.WriteLine("Its going to be sunny today with a high of 60");
            }
            else if (weather.Equals(3))
            {
                Console.WriteLine("Its going to be overcast today with a high of 50");
            }
            else if (weather.Equals(4))
            {
                Console.WriteLine("Its going to be cloudy today with a high of 40");
            }
            else if (weather.Equals(5))
            {
                Console.WriteLine("Its mother fucking snowing");
            }


        }


    }
}
