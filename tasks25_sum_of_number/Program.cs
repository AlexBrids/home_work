// Найти сумму чисел от 1 до А

using static System.Console;
Clear();

int GetNumber()
{
    int randNumber = new Random().Next(1, 50);
    return randNumber;
}

async void SumNumber(int randomNumber)
{
    int sum = 0;
    int i = 0;
    for(i = 0; i <= randomNumber; i++)
    {
        sum = sum + i;
    }
    WriteLine(sum);
}
int random = GetNumber();
WriteLine(random);

SumNumber(random);