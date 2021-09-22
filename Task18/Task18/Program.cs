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
            int menu;
            Console.WriteLine("Which unit do you want to calculate?");
            Console.WriteLine("1. Unit of LENGTH");
            Console.WriteLine("2. Unit of MASS");
            Console.WriteLine("3. Unit of VOLUME");
            Console.Write("Select: ");
            menu = int.Parse(Console.ReadLine());
            switch (menu)
            {
                case 1: 
                    Console.WriteLine("\n1. Miles -> Kilometers"); 
                    Console.WriteLine("2. Jards -> Meters"); 
                    Console.WriteLine("3. Feets -> Meters"); 
                    Console.WriteLine("4. Inches -> Centimeters");
                    Console.Write("Select: ");
                    double length;
                    length = double.Parse(Console.ReadLine());
                    double miles = 1.61, jard = 0.9144, feet = 0.3048, inch = 2.54;             //declared value in converted variables
                    double m, cm, km;
                    switch (length)
                    {
                        case 1:
                            Console.Write("\nHow many Miles convert: ");                       //user is typing how many miles want check for convert
                            km = double.Parse(Console.ReadLine());                             //for example miles to kilometers - 1.61 miles * 1 kilometer
                            Console.WriteLine("\nIt is {0} kilometers", (miles * km));         //because 1km is 1.61mile
                            break;
                        case 2:
                            Console.Write("\nHow many Jards convert: ");
                            m = double.Parse(Console.ReadLine());
                            Console.WriteLine("\nIt is {0} meters", Math.Round(jard * m,2));
                            break;
                        case 3:
                            Console.Write("\nHow many Feets convert: ");
                            m = double.Parse(Console.ReadLine());
                            Console.WriteLine("\nIt is {0} meters", Math.Round(feet * m,2));
                            break;
                        case 4:
                            Console.Write("\nHow many Inches convert: ");
                            cm = double.Parse(Console.ReadLine());
                            Console.WriteLine("\nIt is {0} centimeters", (inch * cm));
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
                    double pound = 0.45359237, ounc = 28.3495231, carat = 0.2;
                    double kilo, gr;
                    switch (mass)
                    {
                        case 1:
                            Console.Write("\nHow many Pounds convert: ");
                            kilo = double.Parse(Console.ReadLine());
                            Console.WriteLine("\nIt is {0} kilograms", Math.Round(pound * kilo,3));
                            break;
                        case 2:
                            Console.Write("\nHow many Ounces convert: ");
                            gr = double.Parse(Console.ReadLine());
                            Console.WriteLine("\nIt is {0} grams", Math.Round(ounc * gr,2));
                            break;
                        case 3:
                            Console.Write("\nHow many Carats convert: ");
                            gr = double.Parse(Console.ReadLine());
                            Console.WriteLine("\nIt is {0} grams", Math.Round(carat * gr,2));
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
                    double gall = 4.54609, barr = 158.987295;
                    double liter;
                    switch (volume)
                    {
                        case 1:
                            Console.Write("\nHow many Gallons convert: ");
                            liter = double.Parse(Console.ReadLine());
                            Console.WriteLine("\nIt is {0} liters", Math.Round(gall * liter,3));
                            break;
                        case 2:
                            Console.Write("\nHow many Barrels convert: ");
                            liter = double.Parse(Console.ReadLine());
                            Console.WriteLine("\nIt is {0} liters", Math.Round(barr * liter,3));
                            break;
                        default: Console.WriteLine("\nSelected option out of range!"); break;
                    }
                    break;
                default: Console.WriteLine("\nSelected option out of range!"); break;
            }
        }
    }
}
