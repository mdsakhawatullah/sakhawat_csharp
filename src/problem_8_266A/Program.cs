
int n = int.Parse(Console.ReadLine());
string input = Console.ReadLine();
int count = 0;

for (int i = 0; i<n - 1; i++)
{
    if (input[i] == input[i + 1]) count++;
    else continue;

}

Console.WriteLine(count);