namespace problem_73_451A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);

            int count = 0;

            for(int i=1; ; i++)
            {
                if (n - i == 0) break;
                else if (m - i == 0) break;
                count++;
            }

            if(count%2 == 0) { Console.WriteLine("Akshat"); }
            else { Console.WriteLine("Malvika"); }
        }
    }
}
