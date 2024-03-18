namespace problem_61_750A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int n = int.Parse(input[0]);
            int k = int.Parse(input[1]);

            int checkSum = k;
            int count = 0;
            int[] arr = new int[n+1];
            arr[0] = 0;

            for(int i=1; i<=n; i++)
            {
                arr[i] = i * 5;
            }
            
            for (int i = 1; i <= n; i++)
            {
     
                
                    if (checkSum <= 240)
                    {
                        checkSum += arr[i];

                        if (checkSum > 240)
                            break;

                        count++;
                    }
                
            }
            Console.WriteLine(count);

        }
    }
}
