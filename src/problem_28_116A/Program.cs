namespace problem_28_116A
{
    public class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            int sum_a = 0, sum_b = 0;
            List<int> list = new List<int>();

            while(t-- > 0)
            {
                string[] input = Console.ReadLine().Split();
                int exit_a = int.Parse(input[0]);
                int enter_b = int.Parse(input[1]);
                sum_a += exit_a;
                sum_b += enter_b;
                int capacity = sum_b - sum_a;
                list.Add(capacity);

            }
            Console.WriteLine(list.Max());
        }
    }
}
