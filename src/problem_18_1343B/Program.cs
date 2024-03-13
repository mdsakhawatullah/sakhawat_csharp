using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int t = int.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            int a = int.Parse(Console.ReadLine());
            List<int> num = new List<int>();

            if (a % 2 == 0)
            {
                if (a % 4 == 0)
                {
                    Console.WriteLine("YES");
                    /*num.Add(2)*/;
                    int sum1 = 0, sum2 =0;
                    for (int i = 1; i <= a; i++)
                    {
                        if (i % 2 == 0)
                        {
                            num.Add(i);
                            sum1 += i;
                        }
                            
                            
                    }
                    for (int i = 1; i <= a; i++)
                    {
                        if (i % 2 != 0)
                        {
                            num.Add(i);
                            sum2 += i;
                        }
                    }

                    int c = sum1 - sum2;
                    int x = num[num.Count - 1];
                    num[num.Count - 1] = x + c;
                    foreach (int val in num)
                    {
                        Console.Write(val + " ");
                    }
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
