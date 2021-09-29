using System;

namespace Task38
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program remembers the inverted inscription.
            //Tip: "Consecutive letters should be attached to the inscription,
            //starting with the final one."

            string Word, Remembered = "";
            Word = Console.ReadLine();
            for (int i = Word.Length - 1; i >= 0; i--)
            {
                Remembered += Word[i];
            }
            Console.WriteLine(Remembered);
        }
    }
}
