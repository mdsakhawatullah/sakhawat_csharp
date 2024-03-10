namespace problem_14_230A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int str, n, count = 0;
            string[] input = Console.ReadLine().Split();
            str = int.Parse(input[0]);
            n = int.Parse(input[1]);

            var a = new (int, int)[n];

            for(int i=0; i<n; i++)
            {
                input = Console.ReadLine().Split();
                a[i] = (int.Parse(input[0]), int.Parse(input[1]));
            }

            Array.Sort(a);

            for(int i=0; i<n; i++)
            {
                if(str <= a[i].Item1)
                {
                    count++;
                    break;

                }
                else
                {
                    str += a[i].Item2;
                }
            }

            if(count>0)
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");
            }
        }
    }
}
