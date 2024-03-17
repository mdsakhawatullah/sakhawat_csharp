namespace problem_48_148A
{
    public class Program
    {
        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            List<int> list = new List<int>();

            for(int i = 1; i<= d; i++)
            {
                if(i%k == 0) list.Add(i);
                if(i%l == 0) list.Add(i);
                if (i % m == 0) list.Add(i);
                if(i% n == 0) list.Add(i);
               
            }

            int count = list.Distinct().Count();
            Console.WriteLine(count);

        }
    }
}
