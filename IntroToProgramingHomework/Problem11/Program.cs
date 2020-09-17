using System;

namespace Problem11
{
    class Program
    {
        static void Main(string[] args)
        {
       
            Console.Write("Input number :");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input n :");
            int n = Convert.ToInt32(Console.ReadLine());
            int i = Convert.ToInt32(number /(Math.Pow(10,n-1))% 10);
            Console.WriteLine(i);
        }
    }
}
