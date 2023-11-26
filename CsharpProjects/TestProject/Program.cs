// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello C#!");

// Gọi các loại phương thức khác nhau trong Thư viện lớp .NET
// VD: xúc xắc random ra số ngẫu nhiên
Random dice = new Random();
int roll = dice.Next(1, 7);
Console.WriteLine(roll);

// Return values and input parameters of methods
int roll1 = dice.Next();
int roll2 = dice.Next(101);
int roll3 = dice.Next(50, 101);

Console.WriteLine($"First roll: {roll1}");
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}");

// Math class methods
int firstValue = 500;
int secondValue = 600;
int largerValue = Math.Max(firstValue,secondValue);

Console.WriteLine(largerValue);

// if else
Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

if (daysUntilExpiration == 0)
{
    Console.WriteLine("Your subscription has expired.");
}
else if (daysUntilExpiration == 1)
{
    Console.WriteLine("Your subscription expires within a day!");
    discountPercentage = 20;
}
else if (daysUntilExpiration <= 5)
{
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
    discountPercentage = 10;
}
else if (daysUntilExpiration <= 10)
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}

if (discountPercentage > 0)
{
    Console.WriteLine($"Renew now and save {discountPercentage}%.");
}
