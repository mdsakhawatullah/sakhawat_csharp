using System;

namespace problem_30_266B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);

            string s = Console.ReadLine();

            for (int i = 0; i < b; i++)
            {
                for (int j = 0; j < s.Length - 1; j++)
                {
                    if (s[j] == 'B' && s[j + 1] == 'G')
                    {
                        s = SwapCharacters(s, j, j + 1);
                        j++;
                    }
                }
            }

            Console.WriteLine(s);
        }

        static string SwapCharacters(string str, int index1, int index2)
        {
            char[] chars = str.ToCharArray();
            char temp = chars[index1];
            chars[index1] = chars[index2];
            chars[index2] = temp;
            return new string(chars);
        }
    }
}
