// Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива

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
            matrix[i, j] = new Random().Next(0, 10);
        }
    }
}

void SumArray(int[,] matrix)
{
    int sumPlus = 0;
    int sumMinus = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {          
            if (matrix[i, j] >= 0)
            {
                sumPlus = sumPlus + matrix[i, j];
            }
            else 
            {
                sumMinus = sumMinus + matrix[i,j];
            }
        }
        
    }
    WriteLine($"Сумма положительных чисел: {sumPlus}");
    WriteLine($"Сумма отрицательных чисел: {sumMinus}");
    
}



int[,] matrix = new int[3, 4];

WriteLine($"Пустая матрица: ");
PrintArray(matrix);
FillArray(matrix);
WriteLine();
WriteLine($"Заполненная матрица: ");
PrintArray(matrix);
WriteLine();
SumArray(matrix);