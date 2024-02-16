string input = Console.ReadLine();

string[] numbers = input.Split("+");

int[] newNumbers = new int[numbers.Length];

for(int i=0; i< numbers.Length; i++)
{
    newNumbers[i] = int.Parse(numbers[i]);
}

Array.Sort(newNumbers);

string result = string.Join("+", newNumbers);

Console.WriteLine(result);


