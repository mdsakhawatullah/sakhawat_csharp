namespace problem_27_41A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();

            bool ok = true;

            if (a.Length != b.Length)
                ok = false;

            for (int i = 0; ok && i < a.Length; i++)
            {
                if (a[i] != b[a.Length - i - 1])
                {
                    ok = false;
                    break;
                }
            }

            if (ok) Console.WriteLine("YES");
            else Console.WriteLine("NO");
        }
    }
}
