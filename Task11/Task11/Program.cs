using System;

namespace Task11
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Loads the lengths a, b, c of the three segments. 
             * If any value is less than zero, the program displays an input error message. 
             * Otherwise, the program displays one of the messages: "You can build a triangle out of these sections" 
             * or "You can't build a triangle out of these sections".*/
            int a, b, c;
            bool correct = true;
            Console.Write("Enter the length a: ");
            a = int.Parse(Console.ReadLine());
            if (a <= 0)
            {
                correct = false;
            }
            Console.Write("Enter the length b: ");
            b = int.Parse(Console.ReadLine());
            if (b <= 0)
            {
                correct = false;
            }
            Console.Write("Enter the length c: ");
            c = int.Parse(Console.ReadLine());
            if (c <= 0)
            {
                correct = false;
            }
            if (correct == true)
            {
                Console.WriteLine("You can build a triangle out of these sections");
            }
            else
            {
                Console.WriteLine("You can't build a triangle out of these sections");
            }
        }
    }
}
