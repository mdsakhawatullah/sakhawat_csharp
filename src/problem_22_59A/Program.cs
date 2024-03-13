namespace problem_22_59A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int sumLower = 0, sumUpper = 0;

            for (int i = 0; i < input.Length; i++)
            {
                char ch = input[i];
                if (char.IsUpper(ch))
                    sumUpper++;
                if (char.IsLower(ch))
                    sumLower++;
                
            }

            if (sumLower >= sumUpper)
            {
                Console.WriteLine(input.ToLower());
            }
            if (sumUpper > sumLower)
            {
                Console.WriteLine(input.ToUpper());
            }

        }
    }
}
