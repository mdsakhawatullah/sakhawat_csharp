namespace problem_16_455A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long[] dp = new long[100005];
            long[] dp2 = new long[100005];
            
            long a = long.Parse(Console.ReadLine());

            long[] elements = new long[a];


           string[] inputs = Console.ReadLine().Split();
          
            for(long i=0; i<a; i++)
            {
                elements[i] = int.Parse(inputs[i]);
                
            }
                
            for(long i=0; i<a; i++)
            {
                long b = elements[i];
                dp[b]++;
            }
            

            dp2[0] = 0;
            dp2[1] = dp[1];

            for (long i = 2; i <= 100000; i++)
            {
                dp2[i] = Math.Max(dp2[i - 1], dp2[i - 2] + i * dp[i]);
            }

            Console.WriteLine(dp2[100000]);
        }
    }
}
