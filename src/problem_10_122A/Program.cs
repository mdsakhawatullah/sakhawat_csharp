namespace problem_10_122A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int inputNumber = int.Parse(Console.ReadLine());
            if(inputNumber%4==0 || inputNumber%7==0 || inputNumber%47==0 || inputNumber % 77 == 0 || inputNumber % 444 == 0
                || inputNumber % 447 == 0 || inputNumber % 474 == 0 || inputNumber % 477 == 0 || inputNumber % 777 == 0
                || inputNumber % 774 == 0 || inputNumber % 747 == 0 ) 
            {   
                count++;
            }
            if (count > 0) Console.WriteLine("YES");
            else Console.WriteLine("NO");

        }
    }
}
