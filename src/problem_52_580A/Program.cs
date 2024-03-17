namespace problem_52_580A
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] profits = new int[n];


            string[] profits2 = Console.ReadLine().Split(' ');
           
            for (int i = 0; i < n; i++)
            {
                profits[i] = int.Parse(profits2[i]);
            }

            int maxLength = CalculateMaxLength(profits);
            Console.WriteLine(maxLength);
        }

        static int CalculateMaxLength(int[] profits)
        {
            int maxLength = 1;
            int currentLength = 1;

            for (int i = 1; i < profits.Length; i++)
            {
                if (profits[i] >= profits[i - 1])
                {
                    currentLength++;
                    maxLength = Math.Max(maxLength, currentLength);
                }
                else
                {
                    currentLength = 1;
                }
            }

            return maxLength;
        }
    }
}
