Console.Write("Enter three digit number: ");
int num=int.Parse(Console.ReadLine()!);

int firstDigit=num%10;
int secondDigit=(num/10)%10;
int thirdDigit=num/100;

Console.WriteLine($"First digit: {firstDigit}");
Console.WriteLine($"Second digit: {secondDigit}");
Console.WriteLine($"Third digit: {thirdDigit}");