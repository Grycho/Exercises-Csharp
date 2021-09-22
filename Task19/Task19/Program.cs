using System;

namespace Task19
{
    class Program
    {
        static void Main(string[] args)
        {
            /*The price of a Bus ticket depends on the length of the route according to the following scheme: 
             *for journeys from 0km to 10km you pay 2$, for journeys from 11 to 30km the rate is 1$ plus 0.10$ 
             *for each kilometer, and for journeys over 30 km the rate is 1$ plus 0.08$ for every kilometer. 
             *If the value is incorrect, the price cost is -1*/

            int km;
            Console.Write("How many kilometers do you want to drive: ");
            km = int.Parse(Console.ReadLine());
            double ticket;
            if (km >= 0 && km <= 10)
            {
                ticket = 2;
                Console.WriteLine($"\nAmount for travel {km}km is: " + "{0}$", ticket);
            }
            else
            {
                Console.WriteLine("\nTicket price: -1$");
            }
            if (km >= 11 && km <= 30)
            {
                ticket = km * (1 + 0.10);
                Console.WriteLine($"\nAmount for travel {km}km is: " + "{0}$", Math.Round(ticket,2));
            }
            else
            {
                Console.WriteLine("\nTicket price: -1$");
            }
        }
    }
}
