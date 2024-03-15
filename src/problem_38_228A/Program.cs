namespace problem_38_228A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            int c = int.Parse(input[2]);
            int d = int.Parse(input[3]);
            int[] array = { a, b, c, d };

            int count = 0;
            Array.Sort(array);

           for(int i =0; i<3; i++)
            {
                if (array[i] == array[i + 1]) count++;
            }

            Console.WriteLine(count);
        }
    }
}
