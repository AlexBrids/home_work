// Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

using static System.Console;
Clear();

int GetNumber()
{
    int randNumber = new Random().Next(-100, 100);
    return randNumber;
}

int numberX = GetNumber();
int numberY = GetNumber();

WriteLine($"Координаты точки: {numberX}, {numberY}");
// int number = GetNumber();
// WriteLine(number);

void NumberQuatro(int x, int y)
{
    if ((x == 0) || (y == 0))
    {
        WriteLine("Точка лежит на оси, повторите эксперимент!!!");
    }
    else
    {
        if ((x > 0) && (y > 0))
        {
            WriteLine("Точка лежит в координатной плоскости 1");
        }
        else if ((x > 0) && (y < 0))
        {
            WriteLine("Точка лежит в координатной плоскости 2");
        }
        else if ((x < 0) && (y < 0))
        {
            WriteLine("Точка лежит в координатной плоскости 3");
        }
        else
        {
            WriteLine("Точка лежит в координатной плоскости 4");
        }
    }
}

NumberQuatro(numberX, numberY);