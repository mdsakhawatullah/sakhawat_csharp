namespace problem_29_677A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);
            int h = int.Parse(input[1]);
            int count = 0;

            string[] numbers = Console.ReadLine().Split(' ');
            int[] array = new int[numbers.Length];

            for(int i=0; i<numbers.Length; i++)
            {
                array[i] = int.Parse(numbers[i]);
                if (array[i] <= h) count++;
                if (array[i] > h) count += 2;
            }
            Console.Write(count);
        }
    }
}
