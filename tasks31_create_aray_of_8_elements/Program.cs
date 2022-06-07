// Задать массив из 8 элементов и вывести их на экран

using static System.Console;
Clear();

void PrintArray(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Write($"{matrix[i, j]} ");
        }
    }
}


void FillArray(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
        }
    }
}

int[,] matrix = new int[1, 8];

PrintArray(matrix);
FillArray(matrix);
WriteLine();
PrintArray(matrix);

