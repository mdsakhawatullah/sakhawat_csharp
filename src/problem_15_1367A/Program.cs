namespace problem_15_1367A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            while(t-- > 0) 
            {
               string input = Console.ReadLine();
                string ans = "";
                ans += input[0];
                for(int i=1; i<input.Length; i+=2)
                {
                    ans += input[i];
                }

                Console.WriteLine(ans);
            }
        }
    }
}
