// Подсчитать сумму цифр в числе

using static System.Console;
Clear();


int GetNumber()
{
    int randNumber = new Random().Next(100, 1000);
    return randNumber;
}

int randomNumber = GetNumber();
WriteLine(randomNumber);


async void SumDigitNumber(int number)
{
    int division = 0;
    int sum = 0;
    int i = 0;
    int summer = 0;
    int property = number;
    string str = Convert.ToString(number);
    int length = str.Length;
    for (i = 0; i <= length; i++)
    {
        if (i == 0)
        {
            division = number % 10;
            sum = division;
            property = number / 10;
        }
        else
        {
            division = property % 10;
            sum = sum + division;
            property = property / 10;
        }
        
    }
    WriteLine();
    WriteLine(sum);
}
SumDigitNumber(randomNumber);
