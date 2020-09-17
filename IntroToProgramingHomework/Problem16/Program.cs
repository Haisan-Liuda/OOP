using System;

namespace Problem16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a :");
            int a = Convert.ToInt32(Console.ReadLine());
            
            switch(a)
            {
                case 1:
                    Console.WriteLine("Mondey");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
               case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");

                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }
        }
    }
}
