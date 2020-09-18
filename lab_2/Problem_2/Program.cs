
using System;


    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("input numbers:");
        string[] array = Console.ReadLine().Split(' ');
        Console.WriteLine("input n times:");
        int n = int.Parse(Console.ReadLine());
            int size = array.Length;

            int[] A = new int[size];
            for (int i = 0; i < size; i++)
            {
            A[i] = int.Parse(array[i]);
            }

            int[] sum = new int[size];
            for (int j = 1; j<= n; j++)
            {
                for (int i = 0; i <= size - 1; i++)
                { 
                    sum[(i + j) % size] += A[i];
                }
            }

            foreach (int item in sum)
            {
                Console.Write("{0} ", item);
            }

            Console.ReadKey();
    }
    }