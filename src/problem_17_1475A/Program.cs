namespace problem_17_1475A
{
    public class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                string input = Console.ReadLine();
                long n = long.Parse(input);
                

                if ((n & (n-1)) == 0) Console.WriteLine("NO");
                else Console.WriteLine("YES");
            }
        }
    }
}
