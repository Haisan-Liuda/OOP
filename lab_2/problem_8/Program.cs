using System;

class problem_8
{

    static void Main()
    {
        Console.WriteLine("input numbers:");
        string[] array = Console.ReadLine().Split(' ');
        int size = array.Length;

        int[] numbers = new int[size];
        for (int i = 0; i < size; i++)
        {
            numbers[i] = int.Parse(array[i]);
        }
        int n = 0, m = 0;
        int max = -1,max_1=-1;
        for (int i = 0; i < size; i++)
        {
            for (int j = i + 1; j < size; j++)
            {
                if (array[i] == array[j]) 
                {
                    m++; 
                }
                if (max_1 < m)
                {
                    max_1 = m;
                    max = n;
                }
            }
            n = i;
            m = 1;
        }
        Console.Write($"s={max} l={max_1}\n");
        Console.Write($"number is {array[max_1]}");
        Console.ReadKey();
    }
}
