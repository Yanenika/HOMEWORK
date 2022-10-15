// See task 1. Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа
/*
int FindSecondDigit(int x)
{
    int result = x / 10 % 10;
    return result;
}
int number1 = new Random().Next(100, 1000);
int number2 = 99;
int number3 = new Random().Next(100, 1000);

int secondDigit1 = FindSecondDigit(155);
int secondDigit2 = FindSecondDigit(number2);
int secondDigit3 = FindSecondDigit(3);


Console.WriteLine($"ThreeGigit {secondDigit1}, secondDigit {secondDigit2}");

//See task 3. Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.
/*
bool FindWeekday(int num)
{
    bool result;
    if (num  == 6 || num == 7)
    {
        result = true;
    }
    else 
    {
        result = false;
    }
    return result;
}
Console.WriteLine("Input a digit day:");
int number = Convert.ToInt32(Console.ReadLine());
bool weekday = FindWeekday(number);
Console.WriteLine($"Weekday: {number} weekend {weekday}");
*/
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом
/*
bool DigitMer(int num)
{
    int num5 = num % 10;
    int num1 = num /10000;
    if (num5 == num1)
    {
        int num4 = num % 100 / 10;
        int num2 = num /1000 % 10;
        if (num4 == num2)
        return true;
        else
        {
            return false;

        }
    }
    else
    {
        return false;
    }
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if ( number >= 10000 & number < 100000)
{
bool result = DigitMer(number);
if ( result == true)
{
    Console.WriteLine("Число яв. палиндромом");
}
else
{
    Console.WriteLine("Число не яв. палиндромом");
}
}
else
{
    Console.WriteLine("Число не яв. пятизначным");
}

*/
// See task 2. Напишите программу, которая выводит третью цифру заданного числа (двузначного, трехзначного, пятизначного) или сообщает, 
//что третьей цифры нет.

void FindThirdDigit(int x)
{
    if (x  < 100)
    {
        Console.WriteLine("двузначное число");
    }
    else
    {
        if (x > 100 && x < 1000)
        {
            Console.WriteLine($"Digit {x % 10}");
        }
        else
        {
            if (x > 10000 && x < 100000)
            {
                Console.WriteLine($"Digit {x / 100 % 10}");
            }
            else
            {
                Console.WriteLine("Не яв. трехзначным или пятизначным числом"); 
            }
        }
    }
}
    
Console.WriteLine("Input Digit: ");
int number = Convert.ToInt32(Console.ReadLine());

FindThirdDigit(number);


