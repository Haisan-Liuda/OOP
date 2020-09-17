using System;

namespace Problem10
{
    class Program
    {
        static void Main(string[] args)
        {
            float lastdigit;
            Console.Write("Input n :");
            float n = Convert.ToSingle(Console.ReadLine());
            lastdigit = n %10;
            Console.WriteLine(lastdigit);
        }
    }
}
