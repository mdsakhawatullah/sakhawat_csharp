namespace problem_44_144A
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int n = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split(' ');
            int[] array = new int[n];
            int ma = 0, mi = 101, maxi=0, mini=0;

            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(input[i]);
                if (array[i] > ma)
                {
                    ma = array[i];
                    maxi = i;
                }
                if (array[i] <= mi)
                {
                    mi = array[i];
                    mini = i;
                }
            }

            if (maxi > mini) mini++;
            Console.WriteLine((maxi + (n - 1) - mini));
        }
    }
}
