//Задача 50. Напишите программу, которая на вход принимает число и ищет его в двумерном массиве. 
//Программа должна возвращать значение позиции (номер строки и столбца) этого элемента или же указание, что такого элемента нет.
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
void NumberSearch(int[,] inArray)
{
    Console.Write("Введите элемент массива: ");
    int targetNumber = int.Parse(Console.ReadLine()!);
    int index1 = 0;
    int index2 = 0;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (inArray[i, j] == targetNumber)
            {
                targetNumber = inArray[i, j];
                index1 = i;
                index2 = j;   
                Console.Write($"Номер строки - {index1}; номер столбца - {index2}");    
                return;         
            }
            
        }
        
    }
    Console.Write($"Элемента нет");  
}
Console.Clear();
Console.WriteLine("Введите кол-во строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов: ");
int cols = int.Parse(Console.ReadLine()!);
int[,] array = GetArray(rows, cols, -10, 10);
PrintArray(array);
NumberSearch(array);


