using System;

namespace Problem9
{
    class Program
    {
        static void Main(string[] args)
        {
            float area;
            Console.Write("Input a :");
            float a = Convert.ToSingle(Console.ReadLine());
            Console.Write("Input b :");
            float b = Convert.ToSingle(Console.ReadLine());
            Console.Write("Input c :");
            float c = Convert.ToSingle(Console.ReadLine());
            area = ((a + b ) / 2)*c;
            Console.WriteLine(area);

        }
    }
}
