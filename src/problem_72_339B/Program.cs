namespace problem_72_339B
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] num = Console.ReadLine().Split(' ');
            int n = int.Parse(num[0]);
            int m = int.Parse(num[1]);

            int[] arr = new int[m];

            string[] input = Console.ReadLine().Split(' ');

            for(int i=0; i<m; i++)
            {
                arr[i] = int.Parse(input[i]);
            }

            long count = arr[0] - 1;

            for(int i=0; i<m-1; i++)
            {
                if (arr[i] > arr[i+1])
                {
                    count += n - (arr[i] - arr[i + 1]);
                }
                else if (arr[i+1] > arr[i])
                {
                    count += arr[i + 1] - arr[i];
                }
            }
            Console.WriteLine(count);
        }
    }
}
