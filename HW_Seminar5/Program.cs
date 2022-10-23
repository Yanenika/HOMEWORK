// See Задача №1 из прошлого ДЗ,Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите cтепень числа: ");
double b = Convert.ToDouble(Console.ReadLine());

double broun = Math.Round(b, 0);
//Console.WriteLine($"округленное число {Math.Round(b, 0)}");

if (broun > 0) Math.Pow(a, broun);
else
{
broun = broun * -1;
}
Console.WriteLine($"Произведение {Math.Pow(a, broun)}");
*/
// See Task 1 Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

int FindEven(int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)

       if (array[i] % 2 == 0) count++;
    
    return count;
}

Console.Write($"Ввведите размер массива" + " ");
int size = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateArray(size);
ShowArray(myArray);

int findEven = FindEven(myArray);
Console.WriteLine($" Результат вычислений {findEven}");
*/
// See Task 2. Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
/*
int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-10, 10);
    }
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

int FindEven(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i = i+2)
    {
        sum = sum + array[i]; 
    }
    return sum;
}

Console.Write($"Ввведите размер массива" + " ");
int size = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateArray(size);
ShowArray(myArray);

int findEven = FindEven(myArray);
Console.WriteLine($" Результат вычислений {findEven}");

*/
//See task 3. Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
/*
double[] CreateArray(int size)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().NextDouble();
    }
    return array;
}

void ShowArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

double FindDiff(double[] array)
{
    double min = 0;
    double max = 0;
    double diff = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > min) max = array[i];
        else min = array[i];

            if ( min <= 0 && max < 0 || min >= 0 && max > 0)
                {
                    diff = max - min;
                }
                    if (min <= 0 && max > 0) diff = max + min;
            
    }
    return diff;
}

Console.Write($"Ввведите размер массива" + " ");
int size = Convert.ToInt32(Console.ReadLine());

double[] myArray = CreateArray(size);
ShowArray(myArray);

double findDiff = FindDiff(myArray);
Console.WriteLine($" Результат вычислений {findDiff}");

*/
//See Task 4. Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
//Результат запишите в новом массиве.

int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-10, 10);
    }
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

void FindArray(int[] array)
{
    int[] newArray = new int[array.Length / 2];
    for (int i = 0, last = array.Length-1; i < last; i++, last--)
    {
       array[i] = array[i] * array[last];
    }
}

Console.Write($"Ввведите размер массива" + " ");
int size = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateArray(size);
ShowArray(myArray);
FindArray(myArray);
//int[] findArray = FindArray(myArray);
ShowArray(myArray);
//Console.WriteLine($" Результат вычислений {FindArray(myArray)}");

/*
int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-10, 11);
    }
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

int FindDiff(int[] array)
{
    int min = 0;
    int max = 0;
    int diff = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > min) max = array[i];
        else min = array[i];

            if ( min <= 0 && max < 0 || min >= 0 && max > 0)
                {
                    diff = max - min;
                }
                    if (min <= 0 && max > 0) diff = max + min;
            
    }
    return diff;
}

Console.Write($"Ввведите размер массива" + " ");
int size = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateArray(size);
ShowArray(myArray);

int findDiff = FindDiff(myArray);
Console.WriteLine($" Результат вычислений {findDiff}");
*/