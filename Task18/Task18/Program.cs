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
            Console.Write("Select: ");
            int menu;
            menu = int.Parse(Console.ReadLine());
            switch (menu)
            {
                case 1: 
                    Console.WriteLine("\n1. Miles -> Kilometers"); 
                    Console.WriteLine("2. Jards -> Meters"); 
                    Console.WriteLine("3. Foots -> Meters"); 
                    Console.WriteLine("4. Inches -> Centimeters");
                    Console.Write("Select: ");
                    double length, result;
                    length = double.Parse(Console.ReadLine());
                    double miles=1.61, jards=0.9144, foots=0.3048, inches=2.54, meters, centimeters;
                    switch (length)
                    {
                        case 1: Console.WriteLine("Result ={0}", (miles * 1)); break;
                        default: Console.WriteLine("\nSelected option out of range!"); break;
                    }
                    ; break;
                case 2: 
                    Console.WriteLine("\n1. Pounds -> Kilograms");
                    Console.WriteLine("2. Ounces -> Grams");
                    Console.WriteLine("3. Carats -> Grams");
                    Console.Write("Select: ");
                    double mass;
                    mass = double.Parse(Console.ReadLine());
                    switch (mass)
                    {
                        case 1:  ;break;
                        default: Console.WriteLine("\nSelected option out of range!"); break;
                    }
                    break;
                case 3: 
                    Console.WriteLine("\n1. Gallons -> Liters");
                    Console.WriteLine("2. Barrels -> Liters");
                    Console.Write("Select: ");
                    double volume;
                    volume = double.Parse(Console.ReadLine());
                    switch (volume)
                    {
                        case 1:  ; break;
                        default: Console.WriteLine("\nSelected option out of range!"); break;
                    }
                    break;
                default: Console.WriteLine("\nSelected option out of range!"); break;
            }
        }
    }
}
