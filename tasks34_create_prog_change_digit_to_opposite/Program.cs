// Написать программу замену элементов массива на противоположные

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
            matrix[i, j] = new Random().Next(-9, 10);
        }
    }
}


void ChangeDigit(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = matrix[i, j] * -1;
        }
    }
}



int[,] matrix = new int[3, 4];

WriteLine($"Пустая матрица: ");
PrintArray(matrix);
FillArray(matrix);
WriteLine();
WriteLine($"Заполненная матрица: ");
PrintArray(matrix);
WriteLine();
ChangeDigit(matrix);
WriteLine($"Измененная матрица: ");
PrintArray(matrix);