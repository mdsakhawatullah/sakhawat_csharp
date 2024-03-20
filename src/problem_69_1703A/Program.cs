namespace problem_69_1703A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t  = int.Parse(Console.ReadLine());

            while(t-- >0)
            {
                string s = Console.ReadLine();

                if (s[0] != 'y' && s[0] != 'Y') { Console.WriteLine("NO"); }
                else if (s[1] != 'e' && s[1] != 'E') { Console.WriteLine("NO"); }
                else if (s[2] != 's' && s[2] != 'S') { Console.WriteLine("NO"); }
                else { Console.WriteLine("YES"); }
            }
        }
    }
}
