namespace problem_60_1352A
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

            for (int i = 0; i < a; i++)
            {
                List<int> my = new List<int>();
                int n, count = 0;
                n = int.Parse(Console.ReadLine());

                if (n % 10 != 0) { my.Add(n % 10); }
                int ans = n % 10;
                n -= ans;
                if (n % 100 != 0) { my.Add(n % 100); }
                ans = n % 100;
                n -= ans;
                if (n % 1000 != 0) { my.Add(n % 1000); }
                ans = n % 1000;
                n -= ans;
                if (n % 10000 != 0) { my.Add(n % 10000); }
                if (n >= 10000 && n % 10000 == 0) { my.Add(n); }

                Console.WriteLine(my.Count);
                foreach (var item in my)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
