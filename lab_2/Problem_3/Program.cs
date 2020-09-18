using System;
using System.Collections.Generic;
using System.Linq;


    namespace Problem_4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Input number");
            string n_1 = Console.ReadLine();
            int n = Convert.ToInt32(n_1);
            List<int> result = new List<int>();

            for (int i = 0; i <= n; i++)
            {
                if (IsPrime(i))
                    result.Add(i);
            }
            if (result.Count() == 0)
                Console.WriteLine("Absent");
            else
            {
                foreach (int i in result)
                    Console.Write(i + " ");
            }
            Console.ReadKey();

        }

        static bool IsPrime(int number)
        {
            if (number < 2) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
    }
}
    
