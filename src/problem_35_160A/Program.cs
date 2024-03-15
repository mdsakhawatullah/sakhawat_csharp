namespace problem_35_160A
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] input = Console.ReadLine().Split(' ');
            int sum = 0, sum2 = 0, count =0;
            int[] numbers = new int[n];

            for(int i=0; i<input.Length; i++)
            {
                int d = int.Parse(input[i]);
                sum += d;
                numbers[i] = d;
            }
            sum = sum / 2;
            Array.Sort(numbers);

            for(int i=numbers.Length-1; i>=0; i--)
            {
                sum2 += numbers[i];
                count++;
                if (sum2 > sum) break;
            }
            Console.WriteLine(count);
            
        }
    }
}
