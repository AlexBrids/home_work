// Найти кубы чисел от 1 до N

using static System.Console;
Clear();

int GetNumber()
{
    int randNumber = new Random().Next(1, 8);
    return randNumber;
}

int N = GetNumber();
WriteLine(N);

async void CubeOfNumber(int number)
{
    for (int i = 0; i <= number; i++)
    {
        double cubeNumber = Math.Pow(i, 3);
        Write($"{cubeNumber} ");
        
    }
    
}
CubeOfNumber(N);