namespace problem_71_466A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);
            int a = int.Parse(input[2]);
            int b = int.Parse(input[3]);

            if(b> m* a)
            {
                Console.WriteLine(n * a);
            }
            else
            {
                int x = (n%m) * a;
                if(x>b)
                {
                    Console.WriteLine((n/m*b + b));
                }
                else
                {
                    Console.Write((n/m*b)+x);
                }
            }


        }
    }
}
