using System;

namespace Task05
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read the water temperature and view its status

            int temp;
            Console.Write("Enter the water temperature: ");
            temp = int.Parse(Console.ReadLine());

            if (temp > 100)                     // if the entered temperature is above 100 degrees Celsius show this is Steam
            {
                Console.WriteLine("STEAM");
            }
            else if (temp < 0)                  // if the entered temperature is less than 0 degrees Celsius show this is Ice
            {
                Console.WriteLine("ICE");
            }
            else                                // if the entered temperature is not above 100 and not less than 0 degrees Celsius show this is Liquid
            {
                Console.WriteLine("LIQUID");
            }
            Console.WriteLine("\nEnd of test! Push Enter for leave...");
        }
    }
}
