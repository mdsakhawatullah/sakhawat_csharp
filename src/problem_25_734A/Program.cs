namespace problem_25_734A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int count_a = 0, count_d = 0;
            for (int i = 0; i < t; i++)
            {
                if (input[i] == 'A') count_a++;
                if (input[i] == 'D') count_d++;
            }
            if (count_a > count_d) Console.WriteLine("Anton");
            if (count_d > count_a) Console.WriteLine("Danik");
            if (count_a == count_d) Console.WriteLine("Friendship");
        }
    }
}
