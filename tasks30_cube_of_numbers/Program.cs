// Показать кубы чисел, заканчивающихся на четную цифру
// Пояснение если куб нечетный, то и число кубом которого оно является тоже нечетное, проще работать с исходными числами чем с кубами 

using static System.Console;
Clear();


int GetNumber()
{
    int randNumber = new Random().Next(1, 10);
    return randNumber;
}

int randomNumber = GetNumber();
WriteLine(randomNumber);

async void CubeEvenNumber(int randNumber)
{
    int i = 0;
    double number = 0;
    for (i = 1; i <= randNumber; i++)
    {
        if (i % 2 == 0)
        {
            number = Math.Pow(i, 3);
            Write($"{number}  ");
        }
        else
        {

        }
    }
}
CubeEvenNumber(randomNumber);