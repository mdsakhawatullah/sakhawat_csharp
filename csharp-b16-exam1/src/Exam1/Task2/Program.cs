Console.WriteLine("Task 2");


int number = int.Parse(Console.ReadLine());

int leftShift = number << 3;

Console.WriteLine($"before: {Convert.ToString(number,2)}");
Console.WriteLine($"After: {Convert.ToString(leftShift,2)}");