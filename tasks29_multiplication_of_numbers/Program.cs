// Написать программу вычисления произведения чисел от 1 до N

using static System.Console;
Clear();

int GetNumber()
{
    int randNumber = new Random().Next(1, 10);
    return randNumber;
}

int number = GetNumber();
WriteLine(number);

async void MultiplicationNumber(int randNumber)
{
    int i = 1;
    int result = 1;
    for (i = 1; i <= randNumber; i++)
    {
        result = result * i;
    }
    WriteLine($"Произведение чисел от 1 до {randNumber} равно {result}");
}


MultiplicationNumber(number);
