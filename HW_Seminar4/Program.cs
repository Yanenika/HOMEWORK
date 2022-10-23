// See Task 1 Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

/*
void FindDeg(int a, double b)
{
    Math.Round(b, 1);

    if (b < 0) b = b * -1;
    if ( b == 0 || a == 0) Console.WriteLine(" возведение в нулевую степень любого числа равно 1, ноль в любой натуральной степени равен нулю");
        
    Console.WriteLine($" Ответ: {Math.Pow(a, b)}");
}

Console.WriteLine($"Введите число а");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Введите cтепень числа в");
double b = Convert.ToDouble(Console.ReadLine());

FindDeg(a, b);
*/
// See Task 2 Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
void FindSum(int n)
{
    int sum = 0;

    if (n >= 10 && n < 1000)
    {
        int i = 0; 
        int size = n.ToString().Length;
        int temp = n;
        while ( i < size)
        {
            sum = sum + temp % 10;
            temp = temp / 10;
            i++;
        }
    }
    else
    {
        Console.WriteLine("Число не яв. ни дву-, ни трехзначным");
    }

    if ( n >= 1000 && n < 10000)
    {
        int ed = n % 10;
        int dec = n /10 % 10;
        sum = dec + ed;
    }
    else
    {
        Console.WriteLine("Число не яв. четырехзначным");
    }

    Console.WriteLine($"Сумма цифр числа {n} яв. {sum}");
}

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

FindSum(num);
*/

// task 3  Напишите программу, которая задаёт массив из m элементов и выводит их на экран
/*
int[] RandomArray(int size)
{
    int[] newArray = new int[size];

    for (int i = 0; i < size; i++)
        newArray[i] = new Random().Next(1, 100);
    
    return newArray;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
       
     Console.WriteLine();
}

Console.WriteLine(" Input a namber of elements: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] myArray = RandomArray(size);
ShowArray(myArray);
*/
int[] CreatArray(int size)
{
    int[] array = new int[size];
    Console.WriteLine("Creating array");
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.WriteLine(array[i] + " ");
    Console.WriteLine();
}

int FindEven(int[] array)
{
    int count = 0;
   
    for (int i = 0; i < array.Length; i++)
    {
       if (array[i] / 2 % 10 == 0) count++;
    }
    return count;
}

Console.Write($"Ввведите размер массива" + " ");
int size = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreatArray(size);
ShowArray(myArray);

int findEven = FindEven(myArray);
Console.Write($" Результат вычислений {findEven}");
