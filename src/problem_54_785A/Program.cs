namespace problem_54_785A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;

            for(int i=1; i<=n; i++) 
            { 
                string a = Console.ReadLine();
                if (a == "Tetrahedron") count += 4;
                if (a == "Cube") count += 6;
                if (a == "Octahedron") count += 8;
                if (a == "Icosahedron") count += 20;
                if(a == "Dodecahedron") count += 12;
            }
            Console.WriteLine(count);

            

        }
    }
}
