using System;

namespace Problem13
{
    class Program
    {
        static void Main(string[] args)
        {
            bool b;
            Console.Write("Input a :");
            float a = Convert.ToSingle(Console.ReadLine());
            if ((a % 9  == 0)|| (a % 11 == 0)|| (a % 13 == 0))
            {
               
                b = true;
                
            }
            else
            {
                b = false;
            }
            Console.WriteLine(b);

        }
    }
}
