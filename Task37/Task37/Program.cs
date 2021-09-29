using System;

namespace Task37
{
    class Program
    {
        static void Main(string[] args)
        {
            //[Palindrome]Program prints the loaded string from the end

            string Word;
            Word = Console.ReadLine();
            for (int i = Word.Length - 1; i >= 0 ; i--)
            {
                Console.Write(Word[i]);
            }
        }
    }
}
