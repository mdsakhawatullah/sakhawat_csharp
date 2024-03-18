namespace problem_62_155A
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, k = 0, i, j, min, max;
            n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            min = arr[0];
            max = arr[0];

            for (i = 0; i < n; i++)
            {
                for (j = 0; j < i; j++)
                {
                    if (arr[j] < min)
                    {
                        min = arr[j];
                    }
                    if (arr[j] > max)
                    {
                        max = arr[j];
                    }
                }
                if (arr[i] > max || arr[i] < min)
                {
                    k++;
                }
            }

            Console.WriteLine(k);
        }
    }
}
