namespace problem_57_141A
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string a = Console.ReadLine();
            string b = Console.ReadLine();
            string c = Console.ReadLine();
            string d = a + b;

            char[] c_array = c.ToCharArray();
            char[] d_array = d.ToCharArray();

            Array.Sort(c_array);
            Array.Sort(d_array);
            string c_sorted = new string(c_array);
            string d_sorted = new string(d_array);

            if (c_sorted == d_sorted)
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
