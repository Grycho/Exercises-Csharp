using System;

namespace Task07
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read grade(studies) from 2 to 5 and display it in words

            int grade;
            Console.Write("Enter the grade from 2 to 5 you want to display in words: ");
            grade = int.Parse(Console.ReadLine());

            if (grade == 2)
            {
                Console.WriteLine("poor");
            }
            else if (grade == 3)
            {
                Console.WriteLine("satisfactory");
            }
            else if (grade == 4)
            {
                Console.WriteLine("good");
            }
            else if (grade == 5)
            {
                Console.WriteLine("very good");
            }
            else
            {
                Console.WriteLine("grade does not exist!");
            }
        }
    }
}
