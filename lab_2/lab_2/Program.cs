using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("input lines:");

        string[] array = Console.ReadLine().Split(' '),
                array_2 = Console.ReadLine().Split(' ');

        int lenth = array.Length,
            lenth_2 = array_2.Length,
            minLen = Math.Min(lenth, lenth_2),
            leftEndLen = 0,
            rightEndLen = 0;

        for (int i = 0; i < minLen; ++i)
            if (array[i] == array_2[i])
                ++leftEndLen;
            else if (array[lenth - 1 - i] == array_2[lenth_2 - 1 - i])
                ++rightEndLen;
            else
                break;

        Console.WriteLine((leftEndLen >= rightEndLen) ? leftEndLen : rightEndLen);

        Console.ReadKey();
    }
}