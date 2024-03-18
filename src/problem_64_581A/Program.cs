namespace problem_64_581A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int a = int.Parse(input[0]);
            int  b = int.Parse(input[1]);

            if (a > b)
            {
                Console.Write(b);
                Console.Write(' ');

            }
            else
            {
                Console.Write(a);
                Console.Write(" ");
            }

            int ans = Math.Abs(a - b);
            Console.Write(ans/2);

        }
    }
}
