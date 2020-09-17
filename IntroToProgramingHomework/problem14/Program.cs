using System;

namespace problem14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a :");
            float a = Convert.ToSingle(Console.ReadLine());
            Console.Write("Input b :");
            float b = Convert.ToSingle(Console.ReadLine());
            Console.Write("Input c :");
            float c = Convert.ToSingle(Console.ReadLine());
            if (a > b && a > c)
                Console.WriteLine("Nubmer Max = " + a);
            else if (b > c)
                Console.WriteLine("Number Max = " + b);
            else
                Console.WriteLine("Number Max = " + c);

            Console.ReadLine();
        }
    }
}
