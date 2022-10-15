// See Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите cтепень числа: ");
int b = Convert.ToInt32(Console.ReadLine());

Math.Round(b, 1);
int b = natb;
if (natb > 0) Math.Pow(a, b);
else
{
natb = natb * -1;
}

Console.Write($" Число {a}, возведенное в степень {b} равно {Math.Pow(a, b)}");
 
