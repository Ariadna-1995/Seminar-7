﻿//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} \t");
        }
        Console.WriteLine();
    }
}
void ArithmeticAverage(int[,] inArray)
{
     for (int j = 0; j < inArray.GetLength(1); j++)
     {
        double sum = 0; 
        for (int i = 0; i < inArray.GetLength(0); i++)
        {
            sum += inArray[i,j];
        }
        sum = Math.Round(sum/inArray.GetLength(0), 1);
        Console.Write($"{sum} ");
     }
}
Console.Clear();
Console.WriteLine("Введите кол-во строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов: ");
int cols = int.Parse(Console.ReadLine()!);
int[,] array = GetArray(rows, cols, -10, 10);
PrintArray(array);
ArithmeticAverage(array);
