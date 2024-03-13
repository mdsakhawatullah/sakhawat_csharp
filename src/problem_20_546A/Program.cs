namespace problem_20_546A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int k = int.Parse(input[0]);
            int n = int.Parse(input[1]);
            int w = int.Parse(input[2]);
            int ans=0;
            int sumW = 0;

            for(int i=1; i<=w; i++)
            {
                sumW += k*i;
            }

            if(n<sumW)
            {
                ans = sumW - n;
                
            }
            else
            {
                ans = 0;
            }
            Console.WriteLine(ans);

        }
    }
}
