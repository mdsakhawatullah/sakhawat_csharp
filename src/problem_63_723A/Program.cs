namespace problem_63_723A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int[] num = new int[input.Length];

            for(int i=0; i<3;  i++)
            {
                num[i] = int.Parse(input[i]);
            }

            Array.Sort(num);

            int count = 0;

            count += (num[1] - num[0]) + (num[2] - num[1]);
            Console.WriteLine(count);
        }
    }
}
