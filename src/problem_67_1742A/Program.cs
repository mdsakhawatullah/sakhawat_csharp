namespace problem_67_1742A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            while (t-- > 0)
            {


                string[] input = Console.ReadLine().Split(' ');
                int[] num = new int[3];
                for (int i = 0; i < 3; i++)
                {
                    num[i] = int.Parse(input[i]);
                }
                
                Array.Sort(num);
                /*for(int i=0; i<3; i++)
                {
                    Console.Write(num[i]);
                }*/

                for (int i = 0; i < 2; i++)
                {
                    if (num[i] + num[i + 1] == num[i + 2])
                    {
                        Console.WriteLine("YES");
                        break;

                    }
                    else
                    {
                        Console.WriteLine("NO");
                        break;
                    }
                }
            }
        }
    }
}
