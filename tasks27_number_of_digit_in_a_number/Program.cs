// Определить количество цифр в числе

using static System.Console;
Clear();

int GetNumber()
{
    int randNumber = new Random().Next(1, 100000);
    return randNumber;
}

int number = GetNumber();
WriteLine($"Случайное число: {number}");

string text = Convert.ToString(number);
int number_of_digit = text.Length;
WriteLine($"Количество цифр в числе равно: {number_of_digit}");