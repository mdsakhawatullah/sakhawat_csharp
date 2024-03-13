namespace problem_23_69A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            int sum_a = 0, sum_b=0, sum_c=0, ans_a=0,ans_b=0, ans_c=0;
            while (t-- > 0)
            {
                string[] input = Console.ReadLine().Split();
                int a = int.Parse(input[0]);
                int b = int.Parse(input[1]);
                int c = int.Parse(input[2]);


                sum_a = a;
                ans_a += sum_a;

                sum_b = b;
                ans_b += sum_b;

                sum_c = c;
                ans_c += sum_c;
                
            }
            


            if (ans_a == 0 && ans_b==0 && ans_c ==0) Console.WriteLine("YES");
            else Console.WriteLine("NO");
        }
    }
}
