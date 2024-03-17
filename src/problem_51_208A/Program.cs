namespace problem_51_208A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            for(int i=0; i<input.Length-2; i++)
            {
                if (input[i]=='W' && input[i+1] == 'U' && input[i+2] == 'B')
                {
                    i += 2;
                    Console.Write(" ");
                }
                else
                {
                    Console.Write(input[i]);
                }
            }

            for(int i= Math.Max(0, input.Length-4); i<input.Length; i++)
            {
                if (input[i] == 'W' && input[i + 1] == 'U' && input[i + 2] == 'B')
                {
                    i += 2;
                    continue;
                }
                else Console.Write(input[i]);
            }
        }
    }
}
