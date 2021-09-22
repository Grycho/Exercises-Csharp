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

            Console.WriteLine("Which unit do you want to calculate?");
            Console.WriteLine("1. Unit of LENGTH");
            Console.WriteLine("2. Unit of MASS");
            Console.WriteLine("3. Unit of VOLUME");
            Console.Write("\nSelect: ");
            int menu;
            menu = int.Parse(Console.ReadLine());
            switch (menu)
            {
                case 1: 
                    Console.WriteLine("1. Miles -> Kilometers"); 
                    Console.WriteLine("2. Jards -> Meters"); 
                    Console.WriteLine("3. Foots -> Meters"); 
                    Console.WriteLine("4. Inches -> Centimeters");
                    double length;
                    length = double.Parse(Console.ReadLine());
                    switch (length)
                    {
                        case 1:  ;break;
                        default:  ;break;
                    }
                    ; break;
                case 2: 
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    break;
                case 3: 
                    Console.WriteLine();
                    Console.WriteLine();
                    break;
                default: Console.WriteLine("\nSelected option out of range!"); break;
            }
        }
    }
}
