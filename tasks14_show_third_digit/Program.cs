// Показать третью цифра числа

Console.Clear();

int GetNumber()
{
    int randomNumber = new Random().Next(50, 150);
    return randomNumber;
}

int number = GetNumber();
Console.WriteLine($"Исходное число: {number}");


void ShowThirdDigit(int count)
{
    string str = Convert.ToString(number);
    int length = str.Length;

    if (length < 3)
    {
        Console.WriteLine($"У числа всего 2 цифры");

    }
    else
    {
        int result = count % 10;
        Console.WriteLine($"Третья цифра числа: {result}");
    }

}

ShowThirdDigit(number);