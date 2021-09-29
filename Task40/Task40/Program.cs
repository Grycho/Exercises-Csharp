using System;

namespace Task40
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program loads 10 subtitles and displays them from the end.
            string[] Words = new string[10];

            for (int i = 0; i < 10; i++)
            {
                Words[i] = Console.ReadLine();
            }
            for (int i = 9; i >= 0; i--)
            {
                Console.WriteLine(Words[i]);
            }
        }
    }
}
