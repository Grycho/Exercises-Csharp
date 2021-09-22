using System;

namespace Task18
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Program to convert Anglo-Saxon units of measurement into Polish. 
             *Use the switch selection statement. The program is supposed to perform 
             *the following changes of measures: length units, mass units, volume units*/

            int length, mass, volume;
            Console.WriteLine("Which unit do you want to calculate? Select the appropriate letter for the selected unit\n");

            int menu;
            menu = int.Parse(Console.ReadLine());
            switch (menu)
            {
                case 1: Console.WriteLine("1. Unit of LENGTH: "); break;
                case 2: Console.WriteLine("2. Unit of MASS: "); break;
                case 3: Console.WriteLine("3. Unit of VOLUME: "); break;
                default: Console.WriteLine("Selected option out of range!"); break;
            }
        }
    }
}
