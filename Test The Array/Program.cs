using System;

namespace Test_The_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Your Entity: ");
            string Word = Console.ReadLine();
            for (int i = 0; i < Word.Length; i++)
            {
                Console.Write(" {0} ",Word[i]);
            }
            Console.ReadKey();
        }
    }
}
