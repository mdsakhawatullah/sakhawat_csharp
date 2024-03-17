namespace problem_46_479A
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int a = int.Parse(Console.ReadLine());
           int b = int.Parse(Console.ReadLine());
           int c = int.Parse(Console.ReadLine());

    

            int op1 = a + b * c;
            int op2 = a* (b + c);
            int op3 = a * b * c;
            int op4 = (a+b) * c;
            int op5 = a + b + c;

            int[] numbers = { op1, op2, op3, op4, op5 };
            Console.WriteLine(numbers.Max());
        }
    }
}
