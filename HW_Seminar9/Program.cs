// Задача 41.Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
Console.WriteLine($"Введите любое количество чисел n: ");
int n = Convert.ToInt32(Console.ReadLine());

int positiv = 0;
for (int count = 0; count < n; count++)
{ 
    Console.WriteLine($"Число: ");
    int а = Convert.ToInt32(Console.ReadLine());
    
    if (а > 0) positiv++; 
        Console.WriteLine(positiv);  
}
Console.WriteLine("Количество положительных чисел" + positiv);
*/

//Задача 56.Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*
int[,] CreatRandom2Array()
{
    Console.WriteLine("Input a number of rows:  ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a number of columns:  ");
    int columns = Convert.ToInt32(Console.ReadLine());
    
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

int[] SumArray(int[,] array)
{
    int[] averArray = new int[array.GetLength(1)];
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {    
            sum = sum + array[i,j];  
        }
        averArray[i] = sum;
    }
    return averArray;
}
void ShowArray(int[] array)
{
    int minSum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
        Console.WriteLine();
        minSum = array[i];
        if (minSum < array[i]) minSum = array[i];         
    }
    Console.WriteLine("Минимальная сумма" + minSum); // а если я ввожу такое условие, то работает только с квадратной матрицей
   
}

int[,] myArray = CreatRandom2Array();
Show2Array(myArray);

int[] sumArray = SumArray(myArray);
ShowArray(sumArray);
*/
//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа 
//в промежутке от N до 1. Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

/*
void Digit(int n)
{
    Console.Write(n + " ");
    if (n > 1) Digit(n - 1);
}

Console.WriteLine($"Введите любое количество чисел n: ");
int n = Convert.ToInt32(Console.ReadLine());
Digit(n);
*/
//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30
/*
int Order(int m, int n)
{
    if (m > n) return Order(m - 1, n) + m;
    if (n > m ) return Order(m, n - 1) + n;
    else return n;
}
Console.WriteLine($"Введите любое количество чисел m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите любое количество чисел n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Order(m, n));
*/ 

