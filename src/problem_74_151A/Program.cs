namespace problem_74_151A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int n = int.Parse(input[0]);
            int k = int.Parse(input[1]);
            int l = int.Parse(input[2]);
            int c = int.Parse(input[3]);
            int d = int.Parse(input[4]);
            int p = int.Parse(input[5]);
            int nl = int.Parse(input[6]);
            int np = int.Parse(input[7]);

            int totalDrinks = k * l;
            totalDrinks = totalDrinks / nl;
            int totalSlice = c * d;
            int totalSalt = p / np;

            int srt = Math.Min(totalDrinks, totalSlice);

            int count = (Math.Min(srt, totalSalt))/n;
            Console.WriteLine(count);
        }
    }
}
