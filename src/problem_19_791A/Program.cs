namespace problem_19_791A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int lim = int.Parse(input[0]);
            int bob = int.Parse(input[1]);
            int count = 0;
            while(!(lim>bob))
            {
                lim = lim * 3;
                bob = bob * 2;
                count++;
            }
            Console.WriteLine(count);
        }
    }
}
