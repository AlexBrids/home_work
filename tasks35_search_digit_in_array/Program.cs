// Определить, присутствует ли в заданном массиве, некоторое число 

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
            matrix[i, j] = new Random().Next(150, 200);
        }
    }
}

void SearchDigit(int[,] matrix, int digit)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] == digit)
            {
                Write($"Число {digit} находится по следующим координатам {i}; {j}.");
                WriteLine();
            }
            else
            {
                
            }
        }
    }
    
}

int digit = new Random().Next(150, 200);
WriteLine(digit);
WriteLine();

int [,] matrix = new int[8, 10];

//PrintArray(matrix);
WriteLine();
FillArray(matrix);
PrintArray(matrix);
WriteLine();
SearchDigit(matrix, digit);


