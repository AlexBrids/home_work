// Определить количество цифр в числе

using static System.Console;
Clear();
/*
int GetNumber()
{
    int randNumber = new Random().Next(1, 100000);
    return randNumber;
}

int number = GetNumber();
WriteLine($"Случайное число: {number}");

string text = Convert.ToString(number);
int number_of_digit = text.Length;
WriteLine($"Количество цифр в числе равно: {number_of_digit}");
*/


// Вариант 2 Количество цифр в строке


string text = "kjlkj5";


async void NumberOfDigitInWord(string str)
{
    int numberOfDigit = 0;
    int length = str.Length;
    int i = 0;
    for (i = 0; i < length; i++)
    {
        char[] arr = str.ToCharArray();
        char[] MyArray = {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9'};
        for(int j = 0; j < MyArray.Length; j++)
        {
            if(arr[i] == MyArray[j])
            {
                numberOfDigit++;
            }
        }

        /*if((arr[i] == '0') || (arr[i] == '1') || (arr[i] == '2') || (arr[i] == '3') || (arr[i] == '4') || (arr[i] == '5') || (arr[i] == '6') || (arr[i] == '7') || (arr[i] == '8') || (arr[i] == '9'))
        {
            numberOfDigit++;
            //Write("2");
        }
        else
        {
           
        }
        */
        
    }
    int result = numberOfDigit;
    Write(result);
}

NumberOfDigitInWord(text);

/*
string str = "kjlkj54k55hjkh5879";
char[] arr = str.ToCharArray();

if (arr[1] == 'j')
{
    Write("1");
}
else
{
    Write("2");
}
*/

