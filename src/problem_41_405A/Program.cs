namespace problem_41_405A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            string[] input = Console.ReadLine().Split(' ');

            int[] array = new int[t];

            for(int i=0; i<t; i++)
            {
                array[i] = int.Parse(input[i]); 
            }
            Array.Sort(array);

            string ans = string.Join(" ", array);
            Console.WriteLine(ans);
        }
    }
}
