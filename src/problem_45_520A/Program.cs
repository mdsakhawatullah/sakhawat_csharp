namespace problem_45_520A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine().ToLower();
            int count = 1;

            char[] num = input.ToCharArray();
           
            /*Console.WriteLine(input);*/
            Array.Sort(num);
            /*Console.WriteLine(num);*/


            for (int i = 0; i < num.Length - 1; i++)
            {
                if (num[i] != num[i + 1]) count++;

            }
            /*Console.WriteLine(count);*/

            if (count == 26) Console.WriteLine("YES");
            else Console.WriteLine("NO");


        }
    }
}
