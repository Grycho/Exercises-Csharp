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
                    double length;
                    length = double.Parse(Console.ReadLine());
                    double miles = 1.61, jards = 0.9144, foots = 0.3048, inches = 2.54;
                    double meters, centimeters, kilometers;
                    switch (length)
                    {
                        case 1:
                            Console.Write("\nHow many Miles convert: ");
                            kilometers = double.Parse(Console.ReadLine());
                            Console.WriteLine("\nIt is {0} kilometers", miles * kilometers);
                            break;
                        case 2:
                            Console.Write("\nHow many Jards convert: ");
                            meters = double.Parse(Console.ReadLine());
                            Console.WriteLine("\nIt is {0} meters", jards * meters);
                            break;
                        case 3:
                            Console.Write("\nHow many Foots convert: ");
                            meters = double.Parse(Console.ReadLine());
                            Console.WriteLine("\nIt is {0} meters", foots * meters);
                            break;
                        case 4:
                            Console.Write("\nHow many Inches convert: ");
                            centimeters = double.Parse(Console.ReadLine());
                            Console.WriteLine("\nIt is {0} centimeters", inches * centimeters);
                            break;
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
                    double pounds = 0.45359237, ounces = 28.3495231, carats = 0.2, kilo, grams;
                    switch (mass)
                    {
                        case 1:
                            Console.Write("\nHow many Pounds convert: ");
                            kilo = double.Parse(Console.ReadLine());
                            Console.WriteLine("\nIt is {0} kilograms", pounds * kilo);
                            break;
                        case 2:
                            Console.Write("\nHow many Ounces convert: ");
                            grams = double.Parse(Console.ReadLine());
                            Console.WriteLine("\nIt is {0} grams", ounces * grams);
                            break;
                        case 3:
                            Console.Write("\nHow many Carats convert: ");
                            grams = double.Parse(Console.ReadLine());
                            Console.WriteLine("\nIt is {0} grams", carats * grams);
                            break;
                        default: Console.WriteLine("\nSelected option out of range!"); break;
                    }
                    break;
                case 3: 
                    Console.WriteLine("\n1. Gallons -> Liters");
                    Console.WriteLine("2. Barrels -> Liters");
                    Console.Write("Select: ");
                    double volume;
                    volume = double.Parse(Console.ReadLine());
                    double gallons = 4.54609, barrels = 158.987295, liters;
                    switch (volume)
                    {
                        case 1:
                            Console.Write("\nHow many Gallons convert: ");
                            liters = double.Parse(Console.ReadLine());
                            Console.WriteLine("\nIt is {0} meters", gallons * liters);
                            break;
                        case 2:
                            Console.Write("\nHow many Inches convert: ");
                            liters = double.Parse(Console.ReadLine());
                            Console.WriteLine("\nIt is {0} centimeters", barrels * liters);
                            break;
                        default: Console.WriteLine("\nSelected option out of range!"); break;
                    }
                    break;
                default: Console.WriteLine("\nSelected option out of range!"); break;
            }
        }
    }
}
