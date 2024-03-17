namespace problem_49_443A
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string input = Console.ReadLine();
           char[] charArray = input.ToCharArray();
            int count = 0;

          Array.Sort(charArray);
          
            for (int i = 0; i < charArray.Length -1; i++)
            {
                if (charArray[i] == '{' || charArray[i] == '}' || charArray[i] == ',' || charArray[i] == ' ') continue;
                else
                {
                    if (charArray[i] != charArray[i+1]) count++;
                }

            }
            Console.WriteLine(count);
          
        }
    }
}
