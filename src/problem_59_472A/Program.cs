namespace problem_59_472A
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int x = 0, c = 0;
            int[] a = new int[n];

            string[] input = Console.ReadLine().Split();
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(input[i]);
            }

            for (int j = 0; j < n; j++)
            {
                if (a[j] > 0)
                {
                    x += a[j];
                }
                if (a[j] == -1)
                {
                    int y = x - 1;
                    if (y < 0)
                    {
                        c++;
                    }
                    else
                    {
                        x--;
                    }
                }
            }
            Console.WriteLine(c);
        }
    }
}
