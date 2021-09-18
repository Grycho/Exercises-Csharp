using System;

namespace Task07
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read grade from 2 to 5 and display it in words

            int grade;
            Console.Write("Enter the grade from 2 to 5 you want to display in words: ");
            grade = int.Parse(Console.ReadLine());

            if (grade == 2)
            {
                Console.WriteLine("poor");
            }
        }
    }
}
