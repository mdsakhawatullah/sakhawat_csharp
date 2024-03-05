
string input = Console.ReadLine();
string result = "";

for(int i=0; i<input.Length; i++)
{
    char letter = char.ToLower(input[i]);
    if (letter == 'a' || letter == 'o' || letter == 'y' || letter == 'e' || letter == 'u' || letter == 'i'||
        letter == 'A' || letter == 'O' || letter == 'Y' || letter == 'E' || letter == 'U' || letter == 'I')
    {
        continue;
    }
    else
    {
        result += "." + letter;
    }
}
Console.WriteLine(result);