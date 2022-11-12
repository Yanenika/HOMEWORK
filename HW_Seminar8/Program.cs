//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
int count = 0;
  int positive = 0;
  do
  { 
    Console.WriteLine("Input numbers: " );
    int a = Convert.ToInt32(Console.ReadLine());
    if ( a > 0) positive++;
    Console.Write("Positiv" + positive);
    count++;
  }
  while (count < 5);
Console.Write("Positive" + positive);
*/
//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
/*
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

double[] FindElementArray(int[,] array)
{
    double[] averArray = new double[array.GetLength(1)];

    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        double current = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {    
            sum = sum + array[i,j];
            current = sum / array.GetLength(0) ;  
       
        }
        averArray[j] = current;
    }
    return averArray;
}
void ShowArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
        Console.WriteLine();
    }
}

int[,] myArray = CreatRandom2Array();
Show2Array(myArray);

double[] findElementArray = FindElementArray (myArray);
ShowArray(findElementArray);
*/
//Задача 54. Задайте двумерный массив. 
//Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива
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

void ChangeArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {  
            for (int k = j + 1; k < array.GetLength(1); k++) // что-то не получается ввести данное условие в стр.118
            {  
                int max = array[i,j];
                if ( max < array[i,k] ) 
                {
                    array[i,j] = array[i,k];
                    array[i,k] = max;
                }
            }  
        }
    }
}

int[,] myArray = CreatRandom2Array();
Show2Array(myArray);

ChangeArray(myArray);
Show2Array(myArray);
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
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
        Console.WriteLine();
    }
}

void MinSum(int[] array)
{
    int min = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        min = array[0];
        if ( array[i] == 0) break; // не могу придумать условие для прямоугольной матрицы 4х3, т.к. строк больше чем столбцов
        else
        {
            if (array[i] < min) min = array[i];
        }
    }
    Console.WriteLine("Минимальная сумма" + min);
    
}
int[,] myArray = CreatRandom2Array();
Show2Array(myArray);

int[] sumArray = SumArray(myArray);
ShowArray(sumArray);

MinSum(sumArray);
*/

//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу,
//которая будет построчно выводить массив, добавляя индексы каждого элемента.
/*
int[,,] CreatRandom2Array()
{
    Console.WriteLine("Input a number of rows:  ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a number of columns:  ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a number of newcolum:  ");
    int newcolum = Convert.ToInt32(Console.ReadLine());
    

    int[,,] array = new int[rows, columns, newcolum];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < newcolum; k++)
            {
                array[i, j, k] = new Random().Next(1, 10);
            }
        }
    }
    return array;
}

void Show2Array(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
                Console.Write($"{array[i, j, k]} ({i * array.GetLength(1) + j}) "); // не могу выполнить заданное условие, могу только адрес указать
            Console.WriteLine();
        }
    }
}

int[,,] NewArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {    
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (array[i,j,k] == array[i,j,k]) array[i,j,k] = array[i,j,k] * (i * array.GetLength(1) + j); //есть вероятность повторений
            }
        }
    }
    return array;
}


int[,,] myArray = CreatRandom2Array();
Show2Array(myArray);

int[,,] newArray = NewArray(myArray);
Show2Array(newArray);
*/
