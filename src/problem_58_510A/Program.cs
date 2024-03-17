namespace problem_58_510A
{
    class Program
    {
        static void Main(string[] args)
        {
            Query();
        }

        static void Query()
        {
            string[] nm = Console.ReadLine().Split();
            int n = int.Parse(nm[0]);
            int m = int.Parse(nm[1]);

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= m; j++)
                {
                    if (i % 2 == 1)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        if (i % 4 == 0 && j == 1)
                        {
                            Console.Write("#");
                            j++;
                            while (j <= m)
                            {
                                Console.Write(".");
                                j++;
                            }
                        }
                        else if (i % 2 == 0 && j == m)
                        {
                            Console.Write("#");
                        }
                        else
                        {
                            Console.Write(".");
                        }
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
