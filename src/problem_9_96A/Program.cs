
class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        int count = 0;

        for (int i = 0; i < input.Length - 1; i++)
        {
            if (input[i] == input[i + 1])
            {
                count++;
            }
            else count = 0;
            if (count >= 6) break;
        }

        if (count >= 6)
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }
    }
}
