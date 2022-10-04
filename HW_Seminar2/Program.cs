// See task 1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа
/*
int FindSecondDigit(int num)
{
    int result = num / 10 % 10;
    return result;
}
int number = new Random().Next(100, 1000);
int secondDigit = FindSecondDigit(number);
Console.WriteLine($"ThreeGigit {number}, secondDigit {secondDigit}");
*/
// See task 2. Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
//что третьей цифры нет.
int FindThirdDigit(int num1, int num2, int num3)
{
    int result = num1;
    if (num2 > result) result = num2;
    if (num3 < result) result = num3;
    return result;
}
//Console.WriteLine("Input Digit number:");
//int number = Convert.ToInt32(Console.ReadLine());
int number = new Random().Next(100, 100000);
    if (number >= 100 && number < 1000)
    {
       int a = number / 10 % 10;
    }
    if (number >= 10000 && number < 100000)
    {
        int b = number / 100 % 10;
    }
    if (number < 100)
   {
       int c = 0;
        Console.WriteLine("there is no third digit");
    }
int thirdDigit = FindThirdDigit(a, b, c);
Console.WriteLine($"Digit {number}, thirdDigit {thirdDigit}");
/
