namespace problem_26_271A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int year = int.Parse(Console.ReadLine());
           

            for(; ; )
            {
                year++;
                int b = year / 1000;
                int c = (year / 100) % 10;
                int d = (year / 10) % 10;
                int e = (year % 10);

                if (b != c && b != d && b!=e && c!=d && d!=e && c!=e)
                { 
                    break; 
                }

            }
            Console.WriteLine(year);
        }
    }
}
