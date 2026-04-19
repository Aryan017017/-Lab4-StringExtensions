using StringExtensions;

string test1 = "Hello World";
string test2 = "hello world";

Console.WriteLine($"{test1} starts with uppercase: {test1.StartsWithUpperCase()}");
Console.WriteLine($"{test2} starts with uppercase: {test2.StartsWithUpperCase()}");