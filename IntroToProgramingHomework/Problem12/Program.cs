using System;

namespace Problem12
{
    class Program
    {
        static void Main(string[] args)
        {
            bool b;
            Console.Write("Input a :");
            float a = Convert.ToSingle(Console.ReadLine());
            if (a > 20)
            {
                if (a % 2 == 1)
                {
                    b = true;
                }
                else
                { 
                    b = false;
                }
            }
            else
            {
                b = false;
            }
            Console.WriteLine(b);

        }

    }
}
