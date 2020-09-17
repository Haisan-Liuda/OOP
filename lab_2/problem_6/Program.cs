using System;
    class Problem_6
    {
        static void printArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine("\n");
        }
        static void Main()
        {
            int n;
            int[] array;
            Console.Write("Input size: ");
            n = int.Parse(Console.ReadLine());
            array = new int[n];

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("array[" + i + "]= ");
                array[i] = int.Parse(Console.ReadLine());
            }

            printArray(array);

            int count = 0, index = 0, max= 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                count = 0;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        count++;
                    }
                    else break;
                }

                if (count > max)
                {
                    max = count;
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

