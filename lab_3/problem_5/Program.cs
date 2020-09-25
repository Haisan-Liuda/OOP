using System;

namespace problem_5
{
    class Program
    {
        class DateModifier
        {
            private int difference;

            public int Difference { get => difference; }

           
            
            public void Calculate(string f, string s)
            {
                DateTime first = DateTime.Parse(f);
                DateTime second = DateTime.Parse(s);
                difference = Math.Abs((first - second).Days);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("input first date:");
            string f = Console.ReadLine();
            Console.WriteLine("input second date:");
            string s = Console.ReadLine();

            DateModifier n = new DateModifier();
            n.Calculate(f, s);
            Console.WriteLine("diserents in days:");
            Console.WriteLine(n.Difference);

            Console.ReadKey();
        }
    }
}