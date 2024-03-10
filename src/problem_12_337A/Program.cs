namespace problem_12_337A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int studentNum, noOfPuzzle, subValue = 0, ans;
            string[] inputs = Console.ReadLine().Split();
            studentNum = int.Parse(inputs[0]);
            noOfPuzzle = int.Parse(inputs[1]);
            int[] arr = new int[noOfPuzzle];

            inputs = Console.ReadLine().Split();
            for(int i=0; i<noOfPuzzle; i++)
            {
                arr[i] = int.Parse(inputs[i]);
            }

            Array.Sort(arr);
            subValue = arr[noOfPuzzle-1] - arr[0];

            for(int i=studentNum; i<=noOfPuzzle; i++)
            {
                ans = arr[i - 1] - arr[i - studentNum];
                ans = Math.Abs(ans);
                subValue = Math.Min(subValue, ans);
            }

            Console.WriteLine(subValue);

        }
    }
}
