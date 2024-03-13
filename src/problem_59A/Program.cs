namespace problem_21_59A
{
    internal class Program
    {
        public void Main(string[] args)
        {
            string input = Console.ReadLine();
            int sumLower = 0, sumUpper = 0;

            for(int i=0; i<input.Length; i++)
            {
                if(i>='A' && i<='Z') sumUpper++;
                if(i>='a' && i<='z') sumLower++;
            }
            if (sumLower >= sumUpper) Console.WriteLine(input.ToLower());
            if(sumUpper > sumLower) Console.WriteLine(input.ToUpper());

        }
    }
}
