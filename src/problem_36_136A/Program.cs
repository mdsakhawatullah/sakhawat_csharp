using System.Collections.Generic;
namespace problem_36_136A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] input = Console.ReadLine().Split(' ');
            int[] numbers = new int[n];
            List<int> list = new List<int>();

            for(int i=0; i<n; i++)
            {
                numbers[i] = int.Parse(input[i]); 
            }

            for(int i=1; i<=n; i++)
            {
                int position = Array.IndexOf(numbers, i) + 1;
                list.Add(position);

            }
            string result = string.Join(" ", list);

            Console.WriteLine(result);
        }
    }
}
