// Дано число обозначающее день недели. Выяснить является номер дня недели выходным 

Console.Clear();

int GetDayNumber()
{
    int getDayNumber = new Random().Next(1, 8);
    return getDayNumber;
}

int dayNumber = GetDayNumber();
Console.WriteLine($"Номер дня недели: {dayNumber}");

void WeekdayOrWeekend(int numberOfDay, int dayNumber1, int dayNumber2)
{
    if((numberOfDay == dayNumber1) || (numberOfDay == dayNumber2))
    {
        Console.WriteLine($"Номер дня недели соответствует выходному дню!");
    }
    else
    {
        Console.WriteLine("Номер дня неделе соответствует рабочему дню!");
    }
}

WeekdayOrWeekend(dayNumber, 6, 7);