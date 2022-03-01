// Удалить втору цифра 

Console.Clear();

int GetMumber()
{
    int randomNumber = new Random().Next(10, 1300);
    return randomNumber;
}

int number = GetMumber();
Console.WriteLine($"Полученное число: {number}");

void DeleteSecondDigit(int randNumber)
{
    if ((randNumber > 100) && (randNumber < 1000))
    {
        int secondDigit = randNumber % 10;
        string secondResult = Convert.ToString(secondDigit);

        int firstDigit = randNumber / 100;
        string firstResult = Convert.ToString(firstDigit);

        Console.WriteLine($"Удалив второе число, получили: {firstResult + secondResult}");

    }
    else
    {
        Console.WriteLine($"Число содержит либо меньше либо больше трех цифр");
    }
}

DeleteSecondDigit(number);