// Câu lệnh for: thực thi phần thân của nó trong khi biểu thức Boolean được chỉ định ('điều kiện') đánh giá là đúng.
// Câu lệnh foreach: liệt kê các phần tử của một bộ sưu tập và thực thi phần thân của nó cho từng phần tử của bộ sưu tập.
// Câu lệnh do-while: thực thi phần thân của nó một cách có điều kiện một hoặc nhiều lần.
// Câu lệnh while: thực thi phần thân của nó một cách có điều kiện 0 lần hoặc nhiều lần.

// https://learn.microsoft.com/en-us/training/modules/csharp-do-while/5-exercise-challenge-differentiate-while-do-statements


for (int i = 1; i < 101; i++)
{
    if ((i % 3 == 0) && (i % 5 == 0))
        Console.WriteLine($"{i} - FizzBuzz");
    else if (i % 3 == 0)
        Console.WriteLine($"{i} - Fizz");
    else if (i % 5 == 0)
        Console.WriteLine($"{i} - Buzz");
    else
        Console.WriteLine($"{i}");
}

// do while
string? readResult;
bool validEntry = false;
Console.WriteLine("Enter a string containing at least three characters:");
do
{
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        if (readResult.Length >= 3)
        {
            validEntry = true;
        }
        else
        {
            Console.WriteLine("Your input is invalid, please try again.");
        }
    }
} while (validEntry == false);