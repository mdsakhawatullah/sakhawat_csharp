namespace problem_65_732A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int k = int.Parse(input[0]);
            int n = int.Parse(input[1]);
            int count = 0;

            for (int i = 1; ; i++)
            {
                count += k;
                if (count % 10 == 0 || count % 10 == n)
                {
                    Console.WriteLine(i);
                    break;
                }
                else continue;
            }
                
        }
    }
}
