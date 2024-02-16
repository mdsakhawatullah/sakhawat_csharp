string input = Console.ReadLine();

char firstChar = char.ToUpper(input[0]);

string result = firstChar + input.Substring(1);

Console.WriteLine(result);
