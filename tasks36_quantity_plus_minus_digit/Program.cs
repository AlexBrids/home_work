// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

using static System.Console;
Clear();


void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Write($"{matrix[i, j]} ");
        }
        WriteLine();
    }
}

void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 100);
        }
    }
}


void QuantityDigit(int[,] matrix)
{
    int honest = 0;
    int odd = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] % 2 == 0)
            {
                honest = honest + 1;
            }
            else
            {
                odd = odd + 1;
            }
        }
    }
    WriteLine($"Число четных чисел: {honest}");
    WriteLine($"Число нечетных чисел: {odd}");
}


int [,] matrix = new int[8, 10];

FillArray(matrix);
PrintArray(matrix);
WriteLine();
QuantityDigit(matrix);