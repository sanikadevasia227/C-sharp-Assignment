using System;

namespace Assignment_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] st = new int[5];
            int res = 0;
            int temp1 = 0;
            int temp2 = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter the Marks of Student {0}", i + 1);
                st[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int j = 0; j < 4; j++)
            {
                if (st[j] > st[j + 1])
                {
                    temp1 = st[j];
                }
                if (st[j + 1] > st[j])
                {
                    temp2 = st[j + 1];
                }
                if (temp1 == temp2)
                {
                    res = temp1;
                }
                else if (temp1 > temp2)
                {
                    res = temp1;
                }
                else
                {
                    res = temp2;
                }
            }
            Console.WriteLine("Highest Score = {0}", res);
        }
    }
}
