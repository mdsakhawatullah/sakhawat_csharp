namespace problem_43_469A
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int t = int.Parse(Console.ReadLine());
           
            int count = 0;

            string[] input = Console.ReadLine().Split(' ');
            string[] input2 = Console.ReadLine().Split(' ');
            int[] array = new int[input.Length + input2.Length];
            List<int> list = new List<int>();

            for(int i=0; i<input.Length; i++)
            {
                array[i] = int.Parse(input[i]);
            }
            for (int i = 0; i < input2.Length; i++)
            {
                array[input.Length + i] = int.Parse(input2[i]);
            }

            /*string ans = string.Join(" ", array);
            Console.WriteLine(ans);*/

            for (int i = 1; i <= t; i++)
            {
                int position = Array.IndexOf(array, i);
                if (position == -1)
                {
                    count++;
                }
            }

            if (count > 0) Console.WriteLine("Oh, my keyboard!");
            else Console.WriteLine("I become the guy.");


        }
    }
}
