namespace problem_50_996A
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int a = int.Parse(Console.ReadLine());
            int ans = a / 100;
            int left = a % 100;

            ans += left / 20;
            left = left % 20;

            ans += left / 10;
            left = left % 10;

            ans += left / 5;
            left = left % 5;

            ans += left / 1;
            Console.WriteLine(ans);

            

            
        }
    }
}
