namespace problem_40_705A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string ans1="", ans2="", ans3="", ans4 = "";
            for(int i=1; i<n; i++)
            {
                if(i%2 != 0)
                {
                    ans1 = "I hate that";
                    
                }
                if(i%2 == 0)
                {
                    ans2 = "I love that";
                }
            }

            if(n%2 != 0)
            {
                ans3 = "I hate it";
                Console.WriteLine(ans2 + ans3);
            }
            if(n%2 == 0)
            {
                ans4 = "I love it";
                Console.WriteLine(ans1 +" "+ ans4);
            }
        }
    }
}
