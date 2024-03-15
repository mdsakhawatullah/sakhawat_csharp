namespace problem_344A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            List<string> m = new List<string>();
            int count = 1;


            while (t-- > 0)
            {
                string meg = Console.ReadLine();
                m.Add(meg);
                
            }

            for(int i=0; i<m.Count-1; i++)
            {
                if (m[i] != m[i + 1]) count++;
            }
            Console.WriteLine(count);
        }
    }
}
