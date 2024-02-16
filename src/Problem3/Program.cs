string str1 = Console.ReadLine();
string str2 = Console.ReadLine();

str1 = str1.ToLower();
str2 = str2.ToLower();

int result = string.Compare(str1, str2);

if (result < 0) Console.WriteLine("-1");
else if (result > 0) Console.WriteLine("1");
else Console.WriteLine("0");
