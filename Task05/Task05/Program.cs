using System;

namespace Task05
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read the water temperature and view its status

            int temp;
            Console.WriteLine("Enter the water temperature: ");
            temp = int.Parse(Console.ReadLine());

            if (temp > 100)
            {
                Console.WriteLine("STEAM");
            }
            else if (temp < 0)
            {
                Console.WriteLine("ICE");
            }
            else
            {
                Console.WriteLine("LIQUID");
            }
        }
    }
}
