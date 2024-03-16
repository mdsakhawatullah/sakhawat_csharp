namespace problem_42_1328A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t= int.Parse(Console.ReadLine());
            

            while (t-- > 0)
            {
               

                string[] input = Console.ReadLine().Split();
                long a = int.Parse(input[0]);
                long b = int.Parse(input[1]);

               if(a%b==0) Console.WriteLine("0");
               else
                {
                    long ans = b - (a % b);
                    Console.WriteLine(ans);
                }
            }
            
        }
    }
}
