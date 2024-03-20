namespace problem_68_1399A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            while(t-- > 0)
            {
                int n = int.Parse(Console.ReadLine());
                string[] input = Console.ReadLine().Split(' ');
                int[] num = new int[input.Length];

                for(int i=0; i<input.Length; i++)
                {
                    num[i] = int.Parse(input[i]);
                }

                Array.Sort(num);
                int f = 0;

                for(int i =1; i<n; i++)
                {
                    if (num[i] - num[i - 1] > 1)
                    {
                        f = 1;
                        break;
                    }
                    
                }
                if (f == 0) Console.WriteLine("YES");
                else Console.WriteLine("NO");
            }
        }
    }
}
