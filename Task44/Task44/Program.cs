using System;

namespace Task44
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program error catching

            int Numb1, Numb2;
            bool Error = false;
            double Sum;
            bool Quant1, Quant2;
            Quant1 = int.TryParse(Console.ReadLine(), out Numb1);
            Quant2 = int.TryParse(Console.ReadLine(), out Numb2);

            if (Quant1 == true && Quant2 == true)
            {

            }
        }
    }
}
