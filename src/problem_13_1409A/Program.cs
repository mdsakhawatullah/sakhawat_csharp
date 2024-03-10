namespace problem_13_1409A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int testcase = int.Parse(Console.ReadLine());
            while (testcase-- > 0) 
            {
                string[] inputs = Console.ReadLine().Split();
                int a = int.Parse(inputs[0]);
                int b = int.Parse(inputs[1]);
                int ans;
                ans = Math.Abs(a - b);
                if(ans%10 == 0) Console.WriteLine(ans/10);
                else Console.WriteLine(ans/10+1);
            }
        }
    }
}
