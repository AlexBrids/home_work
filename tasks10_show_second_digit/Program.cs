// Показать вторую цифру трехзначного числа

Console.Clear();

int GetNumber()
{
    int randomNumber = new Random().Next(100, 1000);
    return randomNumber;
}

int number = GetNumber();
Console.WriteLine($"Трехзначное число: {number}");

void GetSecondDigit(int randomResult)
{
    int middleResult = randomResult / 10;
    int result = middleResult % 10;
    Console.WriteLine($"Второе число исходного трехзначного числа: {result}");
}

GetSecondDigit(number);