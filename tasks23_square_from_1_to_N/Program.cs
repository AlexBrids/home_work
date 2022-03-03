// Показать таблицу квадратов чисел от 1 до N 

using static System.Console;
Clear();

int GetNumber()
{
    int randNumber = new Random().Next(5, 10);
    return randNumber;
}

int N = GetNumber();
WriteLine($"Пограничное значение равно {N}");

/*
for(int i = 1; i <= N; i++)
{
    Write($"{i} * {i} = {i * i}");
    WriteLine();
}
*/
for (int i = 1; i <= N; i++)
{
    Write($"Квадрат числа {i} равен {Math.Pow(i, 2)}");
    WriteLine();
}