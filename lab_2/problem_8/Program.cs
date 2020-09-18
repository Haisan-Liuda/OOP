using System;

class problem_8
{

    static void Main()
    {
        Console.WriteLine("input numbers:");
        string[] array = Console.ReadLine().Split(' ');
        int size = array.Length;

        int[] A = new int[size];
        for (int i = 0; i < size; i++)
        {
            A[i] = int.Parse(array[i]);
        }
        
        int max =A[0], count = 1;
        for (int i = 0; i < size; i++)
        {
            int n = A[i], m = 1;
            for (int j = i + 1; j < size; j++)
            {
                if (A[j] == n)
                {
                   m++;
                }
            }

            if (m > count)
            {
                max= n;
                count = m;
            }
        }
        Console.WriteLine("{0}", max);
        Console.ReadKey();
    }
}
