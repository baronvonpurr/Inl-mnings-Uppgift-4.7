using System;

namespace Uppgift4_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv ett tal");
            string svar = (Console.ReadLine());
            Console.WriteLine("Hur många steg ska talet flyttas?");
            int steg = int.Parse(Console.ReadLine());
            for (int position = 0; position < svar.Length; position++)
            {
                for (int j = 0; j < steg; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine(svar[position]);
            }
            Console.ReadKey();
        }
    }
}