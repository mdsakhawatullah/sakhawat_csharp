namespace problem_11_268A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count  = 0;
            int testCase = int.Parse(Console.ReadLine());
            int[] x = new int[testCase];
            int[] y = new int[testCase];

            for(int i=0; i<testCase; i++) 
            {
                string[] input = Console.ReadLine().Split();
                x[i] = int.Parse(input[0]);
                y[i] = int.Parse(input[1]);
            }

            for(int i=0; i<testCase; i++)
            {
                for(int j=0; j<testCase; j++)
                {
                    if (x[i] == y[j]) count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
