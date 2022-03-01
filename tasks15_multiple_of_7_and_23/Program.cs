// Дано число, проверить кратно ли оно 7 и 23

Console.Clear();

int GetNumber()
{
    int randomNumber = new Random().Next(0, 5000);
    return randomNumber;
}

int number = GetNumber();
Console.WriteLine($"Случаное число: {number}");
int firstMultiple = 7;
int secondMultiple = 23;


void MultipleTwoNumber(int number, int firstMultiple, int secondMultiple)
{
    if (number % firstMultiple == 0)
    {
        if (number % secondMultiple == 0)
        {
            Console.WriteLine($"Число: {number}, кратно числу {firstMultiple}, и числу {secondMultiple}");
        }
        else
        {
            Console.WriteLine($"Число: {number}, кратно числу {firstMultiple}, но не кратно числу {secondMultiple}");
        }
    }
    else
    {
        if (number % secondMultiple == 0)
        {
            Console.WriteLine($"Число: {number}, не кратно числу {firstMultiple}, и кратно числу {secondMultiple}");
        }
        else
        {
            Console.WriteLine($"Число: {number}, не кратно числу {firstMultiple}, и не кратно числу {secondMultiple}");
        }        
    }
}

MultipleTwoNumber(number, firstMultiple, secondMultiple);
