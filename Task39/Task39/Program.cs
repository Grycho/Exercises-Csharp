using System;

namespace Task39
{
    class Program
    {
        static void Main(string[] args)
        {
            //Check if the string is a palindrome

            string Word, Palindrome="";
            Word = Console.ReadLine();

            for (int i = Word.Length-1; i >= 0; i--)
            {
                Palindrome += Word[i];
            }
            if (Word == Palindrome)
            {
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine();
            }
        }
    }
}
