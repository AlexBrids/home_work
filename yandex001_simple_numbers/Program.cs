// Ввод: натуральное число n
// Вывод: количество простых чисел строго меньше n

using static System.Console;
Clear();

int GetNumber()
{
    int randNumber = new Random().Next(100, 501);
    return randNumber;
}

int randomNumber = GetNumber();
WriteLine(randomNumber);


async void SimpleNumber(int randNumber)
{
    int i = 2;
    for(i = 2; i < randNumber; i++)
    {
        if (i == 2)
        {
            Write($"{i} ");
        }
        else if ((i % 2 == 0) && (i > 2))
        {

        }
        else if (i == 5)
        {
            Write($"{i} ");
        }
        else if (i % 10 == 5) 
        {
           
        }
        else if (i == 3)
        {
            Write($"{i} ");
        }
        else if (i % 3 == 0)
        {
            
        }
        else if (i == 7)
        {
            Write($"{i} ");
        }
        else if (i % 7 == 0)
        {
            
        }
        else if (i % 9 == 0)
        {
            
        }
        else
        {
            Write($"{i} ");
        }

    }
    
}

SimpleNumber(randomNumber);