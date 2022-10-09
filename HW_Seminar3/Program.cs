// See Task 1 Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом
bool FindMirror (int num)
{
    int num5 = num % 10;
    int num1 = num / 10000;

    if (num5 == num1)
    {
        int num4 = num % 100 / 10;
        int num2 = num / 1000 % 10;

        if ( num4 == num2)
        {
            return true;
        }
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

Console.WriteLine("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

if ( number >= 10000 && number < 100000)
{ 
  bool result = FindMirror(number);
  if ( result == true) 
  Console.WriteLine("Число яв. палиндромом");
  else
  Console.WriteLine("Число не яв. палиндромом");
}
else 
Console.WriteLine("Число не яв. пятизначным, введите другое число");
//int mirror = FindMirror(number);
//Console.WriteLine($"Вывод числа {FindMirror(number)}");