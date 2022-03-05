// Задать номер четверти, показать диапазоны для возможных координат

using static System.Console;
Clear();

int GetNumber()
{
    int randNumber = new Random().Next(1, 5);
    return randNumber;
}

int numbQuator = GetNumber();
WriteLine($"Номер четверти: {numbQuator}");

void QuarterCoordinate(int number)
{
    if(number == 1)
    {
        WriteLine("Координаты для первой четверти по Х от 0 до +бесконечности, по У от 0 до +бесконечности");
    }
    else if(number == 2)
    {
        WriteLine("Координаты для первой четверти по Х от 0 до +бесконечности, по У от 0 до -бесконечности");
    }
    else if(number == 3)
    {
        WriteLine("Координаты для первой четверти по Х от 0 до -бесконечности, по У от 0 до -бесконечности");
    }
    else
    {
        WriteLine("Координаты для первой четверти по Х от 0 до -бесконечности, по У от 0 до +бесконечности");
    }
}

QuarterCoordinate(numbQuator);