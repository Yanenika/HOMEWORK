// See Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
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
    {
       if (array[i] / 2 % 10 == 0) count++;
    }
    return count;
}

Console.Write($"Ввведите размер массива" + " ");
int size = Convert.ToInt32(Console.ReadLine());

int myArray = CreateArray(size);
ShowArray(myArray);

int findEven = FindEven(myArray);
Console.Write($" Результат вычислений {findEven}");
