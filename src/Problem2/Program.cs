namespace Problem2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int X = 0;
            int t = int.Parse(Console.ReadLine());
            while(t-- > 0)
            {
                string value = Console.ReadLine();
                if (value == "++X" || value == "X++")
                    X += 1;
                else if (value == "--X" || value == "X--")
                    X -= 1;

            }

            Console.WriteLine(X);
        }
    }
}
