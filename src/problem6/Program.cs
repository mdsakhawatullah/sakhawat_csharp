string s = Console.ReadLine();
int count = 1;

char[] charArray = s.ToCharArray();
Array.Sort(charArray);
string sortedString = new string(charArray);

for (int i = 0; i < sortedString.Length -1; i++)
{
    if (sortedString[i] != sortedString[i + 1])
    {
        count++;
    }
}

if (count % 2 == 0)
{
    Console.WriteLine("CHAT WITH HER!");
}
else
{
    Console.WriteLine("IGNORE HIM!");
}
