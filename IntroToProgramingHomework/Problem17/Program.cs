using System;

namespace Problem17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input n:");
            int factorial = 1;
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= n; i++) 
            {
                factorial = factorial * i;
            }
            Console.WriteLine(factorial);
        }
    }
}
