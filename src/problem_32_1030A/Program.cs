namespace problem_32_1030A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] input = Console.ReadLine().Split(' ');
            int[] array = new int[n];
            int count = 0;

            for(int i=0; i<input.Length; i++)
            {
                array[i] = int.Parse(input[i]);
                if (array[i] == 1) count++;

            }

            if (count >= 1) Console.WriteLine("HARD");
            else Console.WriteLine("EASY");
        }
    }
}
