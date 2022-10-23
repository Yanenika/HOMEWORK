// Task 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами
/*
double[,] CreatRandom2Array()
{
    Console.WriteLine("Input a number of rows:  ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a number of columns:  ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a min possible value:  ");
    double minValue = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Input a max possible value:  ");
    double maxValue = Convert.ToDouble(Console.ReadLine());

    double[,] array = new double[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next() + new Random().NextDouble();
        }
    }
    return array;
}

void Show2Array(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
}
double[,] myArray = CreatRandom2Array();
Show2Array(myArray);
*/

/*
//Task 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] CreatRandom2Array()
{
    Console.WriteLine("Input a number of rows:  ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a number of columns:  ");
    int columns = Convert.ToInt32(Console.ReadLine());
    //Console.WriteLine("Input a min possible value:  ");
    //int minValue = Convert.ToInt32(Console.ReadLine());
    //Console.WriteLine("Input a max possible value:  ");
    //int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}

void Show2Array(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
}

void FindElementArray(int[,] array, int n, int m)
{
    int i = 0, j = 0;
    i++; j++;
    if (i == n && j == m) 
        Console.WriteLine("Число с заданной позицией  " + array[i,j]);
    else
        Console.WriteLine("Числа с заданной позицией нет");  
}

int[,] myArray = CreatRandom2Array();
Show2Array(myArray);

Console.WriteLine("Введите позицию i:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите позицию j:");
int m = Convert.ToInt32(Console.ReadLine());
FindElementArray(myArray, n, m);
*/

 // Task 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
 int[,] CreatRandom2Array()
{
    Console.WriteLine("Input a number of rows:  ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a number of columns:  ");
    int columns = Convert.ToInt32(Console.ReadLine());
    //Console.WriteLine("Input a min possible value:  ");
    //int minValue = Convert.ToInt32(Console.ReadLine());
    //Console.WriteLine("Input a max possible value:  ");
    //int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}

void Show2Array(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
}

int FindElementArray(int[,] array)
{
    int[] averArray = new int[array.GetLength(1)];

    for (int j = 0; j < array.GetLength(1); j++)
    {
        int sum = 0; 
        for (int i = 0; i < array.GetLength(0); i++)
        {    
            sum = sum + array[i,j];          
        }
    }
    averArray[i] = sum / GetLength(0);

    return averArray;
}

int[,] myArray = CreatRandom2Array();
Show2Array(myArray);

int findElementArray = FindElementArray (myArray);
Show2Array(myArray);
