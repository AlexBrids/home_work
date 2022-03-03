// По двум заданным числам проверять является ли одно квадратом другого

Console.Clear();

int GetNumber(int limit)
{
    int ranNumber = new Random().Next(1, limit);
    return ranNumber;
}

int firstNumber = GetNumber(10);
Console.WriteLine($"Первое число равно: {firstNumber}");

int secondNumber = GetNumber(4);
Console.WriteLine($"Второе число равно: {secondNumber}");

void FirstSquareSecond (int first, int second)
{
    if(first / second == second)
    {
        Console.WriteLine("Первое число является квадратом второго!");
    }
    else
    {
        Console.WriteLine("Первое число не является квадратом второго!");
    }
}

FirstSquareSecond(firstNumber, secondNumber);