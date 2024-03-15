
namespace problem_31_58A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string a = "hello";

            int x = 0, y = 0;

            for (int i = 0; i < s.Length && x < a.Length; i++)
            {
                if (s[i] == a[x])
                {
                    x++;
                    y++;
                }
            }

            if (y == a.Length) 
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
