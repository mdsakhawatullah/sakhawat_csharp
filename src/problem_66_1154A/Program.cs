namespace problem_66_1154A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int[] num = new int[input.Length];
            for(int i=0;  i<input.Length; i++)
            {
                num[i] = int.Parse(input[i]);
            }
            Array.Sort(num);

            int x1 = num[0];
            int x2 = num[1];
            int x3 = num[2];
            int x4 = num[3];

            int a = x4 - x3;
            Console.Write(a);
            Console.Write(' ');
            int b = x4 - x2;
            Console.Write(b);
            Console.Write(" ");
            int c = x4 - x1;
            Console.Write(c);
           

        }
    }
}
