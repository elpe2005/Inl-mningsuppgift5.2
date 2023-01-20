using System;

namespace uppgift51
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in hur många heltal du vill skriva");
            int antal = int.Parse(Console.ReadLine());
            int[] heltal = new int[antal];
            Console.WriteLine("Skriv in dina heltal");
            for (int i = 0; i < antal; i++)
            {
                heltal[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Här är de heltal du skrev in");
            for (int i = 0; i < antal; i++)
            {
                Console.WriteLine(heltal[i]);
            }
        }
    }
}