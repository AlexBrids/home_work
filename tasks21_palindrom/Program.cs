// Программа проверяет пятизначное число на палиндромом.

Console.Clear();

Console.Write($"Введите пятизначное число: ");
string getNumber = Console.ReadLine();


void Palindrom(string number)
{
    if(number.Length == 5)
    {
        if((number[0] == number[4]) && (number[1] == number[3]))
        {
        Console.WriteLine($"Число {number} является палиндромом");
        }
        else
        {
        Console.WriteLine($"Число {number}  не является палиндромом");
        }
    }
    else
    {
        Console.WriteLine($"Перезапустите программу и введите число повторно!!!");
    }

    
}


Palindrom(getNumber);
