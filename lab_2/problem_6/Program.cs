using System;

class problem_6
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
       

        int m= 0, index = 0,max = 0;
        for (int i = 0; i < array.Length - 1; i++)
        {
           m = 0;
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] == array[j])
                {
                    m++;
                }
                else break;
            }

            if (m > max)
            {
                max = m;
                index = i;
            }
        }
        for (int i = index; i <= index + max; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine("\n");
    }
}