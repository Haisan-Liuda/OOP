using System;

namespace problem15
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
            float i = a * b * c;
            if (i<0)
            {
                Console.WriteLine("Negative");

            }
            else
            {
                Console.WriteLine("Positive");
            }
        }
    }
}
