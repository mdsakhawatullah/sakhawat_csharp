namespace problem_33_467A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            int count = 0;
            while(t-- > 0)
            {
                string[] input = Console.ReadLine().Split();

                int p = int.Parse(input[0]);
                int q = int.Parse(input[1]);
                if (p < q && (q-p) >= 2)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
