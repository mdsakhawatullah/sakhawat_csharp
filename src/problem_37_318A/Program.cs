namespace problem_37_318A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            long n = long.Parse(input[0]);
            long k = long.Parse(input[1]);
            long c;

            if(n%2 ==0)
            {
                c = n / 2;
            }
            else
            {
                c = (n + 1) / 2;
            }
            if (k <= c)
            {
                Console.WriteLine((k * 2) - 1);
            }
            else
            {
                Console.WriteLine((k-c) * 2);
            }

   
        }
    }
}
