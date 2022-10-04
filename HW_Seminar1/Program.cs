/*
// See Task 1.Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее
Console.WriteLine("Input first number:");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number:");
int n2 = Convert.ToInt32(Console.ReadLine());
if (n1 > n2)
{
    Console.WriteLine($"max {n1}, min {n2}");
}
else
{
    Console.WriteLine($"max {n2}, min {n1}");
}
*/
/*
// See Task 2. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел
Console.WriteLine("Input first number:");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number:");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input fird number:");
int n3 = Convert.ToInt32(Console.ReadLine());
if (n1 > n2 && n1 > n3)
{
    Console.WriteLine($"max {n1}");
}
if (n2 > n1 && n2 > n3)
{
    Console.WriteLine($"max {n2}");
}
if (n3 > n1 && n3 > n2)
{
    Console.WriteLine($"max {n3}");
}
*/
/*
// See Task 3. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)
Console.WriteLine("Input number:");
int n = Convert.ToInt32(Console.ReadLine());
if (n % 2 == 0)
{
    Console.WriteLine($"Number {n} even");
}
if (n % 2 != 0)
{
    Console.WriteLine($"Number {n} odd");
}
*/
// See Task 4.Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Write("Input a namber:");
int n = Convert.ToInt32(Console.ReadLine());
int current = 0;
    while (current <= n)
    {
     if (current % 2 == 0)
     Console.Write($" {current} ");
     current++;
    }
// Павел, не знаю как вывести значение в пределах от 1 до N, если я отсекаю все нечетные числа. :(