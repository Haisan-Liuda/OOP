using System;

namespace avg
{
    class Program
    {
        static void Main(string[] args)
        {
            float avg;
            Console.Write("Input a :" );
            float a = Convert.ToSingle(Console.ReadLine());
            Console.Write("Input b :" );
            float b = Convert.ToSingle(Console.ReadLine());
            Console.Write("Input c :" );
            float c = Convert.ToSingle(Console.ReadLine());
            avg = (a + b + c) / 3;
            Console.WriteLine(avg);


        }
    }
}
