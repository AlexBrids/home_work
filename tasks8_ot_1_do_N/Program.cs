// Показать четные числа от 1 до N
Console.Clear();

int count = 0;
int number = 1;

Console.WriteLine("Введите число: ");
string NStr = Console.ReadLine();
int N = int.Parse(NStr);

while (number <= N)
{
    if (N >= number)
    {
        if (number % 2 == 0)
        {
            Console.WriteLine(number);
        }
        if (number %2 == 1)
        {
            Console.WriteLine();
        }
        
    }
    number += 1;
}