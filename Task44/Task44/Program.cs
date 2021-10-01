using System;

namespace Task44
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program error catching

            bool Quant1, Quant2, Error = false;
            Console.Write("First number: ");
            Quant1 = int.TryParse(Console.ReadLine(), out int Numb1);
            Console.Write("Second number: ");
            Quant2 = int.TryParse(Console.ReadLine(), out int Numb2);
            if (Quant1 == true && Quant2 == true)
            {
                try
                {
                    double Sum;
                    Sum = Numb1 / Numb2;
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("\nA runtime error has occurred");
                    Error = true;
                }
                if (!Error) Console.WriteLine("\nResult: {0}", (double)Numb1/Numb2);
            }
        }
    }
}
