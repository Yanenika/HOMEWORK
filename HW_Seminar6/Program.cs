// See Task 1 Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.

int FindCount(int a, int b, int c, int d)
{ 
    int count = 0; 
    if (a > 0) count++;
    if (b > 0) count++;
    if (c > 0) count++;
    if (d > 0) count++;

return count;
}

Console.WriteLine("Введите число и нажмите клавишу Enter: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число и нажмите клавишу Enter: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число и нажмите клавишу Enter: ");
int c = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число и нажмите клавишу Enter: ");
int d = Convert.ToInt32(Console.ReadLine());

int findCount = FindCount(a, b, c, d);

Console.WriteLine("Количество положительных чисел:" + findCount);
// Павел, то что я написала это не метод и не решение задачи. Повторно прочитала лекции и семинары. 
// Вывод: я абсолютно не понимаю каким методом/ способом создать строку для считывания чисел.

//Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
/*
bool FindPoin(double k1, double b1, double k2, double b2 )
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k2 * x + b2;
    return  k1 * x + b1 == k2 * x + b2;
}

void Poin(double k1, double b1, double k2, double b2)
{
double x = (b2 - b1) / (k1 - k2);
double y = k2 * x + b2;
Console.WriteLine($" координаты {x}, {y}");
}

Console.WriteLine("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

bool findPoin = FindPoin(k1, b1, k2, b2 );
if (findPoin == true) Console.WriteLine($"точка пересечения двух прямых" + findPoin);
else 
Console.WriteLine($"точки пересечения нет" + findPoin);

Poin(k1, b1, k2, b2);
*/
