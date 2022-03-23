// Возведите число А в натуральную степень B используя цикл

using static System.Console;
Clear();

int GetNumber(int max)
{
    int randNumber = new Random().Next(1, max);
    return randNumber;
}

int startNumber = GetNumber(10);
WriteLine($"Число А {startNumber}");

int B = GetNumber(5);
WriteLine($"Число B {B}");

async void DegreeOfNumber(int startNumber, int degree)
{
    
    int start = startNumber;

    int i = 0;
    for (i = 0; i < degree; i++)
    {
        
        if (i == 0)
        {
            startNumber = startNumber;
        }
        else
        {
            startNumber = startNumber * start;
        }
        
    }
    WriteLine($"Число {start} в степени {degree} равно {startNumber}");
}
DegreeOfNumber(startNumber, B);