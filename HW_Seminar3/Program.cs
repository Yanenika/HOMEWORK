// See Task 1 Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом
/*
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
*/
// See Task 2. Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве.
/*
double FindSegment(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double Sx = x1-x2;
    double Sy = y1-y2;
    double Sz = z1-z2;
    double segm = Math.Sqrt(Math.Pow(Sx,2) + Math.Pow(Sy,2) + Math.Pow(Sz,2));
    return segm;
}

Console.WriteLine("Input coordinat x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input coordinat y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input coordinat z1: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input coordinat x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input coordinat y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input coordinat z2: ");
double z2 = Convert.ToDouble(Console.ReadLine());

double segment = FindSegment(x1, y1, z1, x2, y2, z2);
Console.WriteLine($"Отрезок равен {segment}");
*/
//See Task 3 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
void FindCub(int num)
{
    int count = 1;
        while (count <= num)
    {
        Console.WriteLine(Math.Pow(count,3));
        count++;
    }
    
}

Console.WriteLine("Input digit: ");
int num = Convert.ToInt32(Console.ReadLine());

FindCub(num);
