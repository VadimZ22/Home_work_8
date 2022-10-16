/*Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку 
с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/


Console.Clear();
int[,] array = new int[5, 5];
FillArray(array);
PrintArray(array);
Console.WriteLine("номер строки с наименьшей суммой элементов: " + GetMinSum(array));




void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
            
        }
        Console.WriteLine();
    }
}


void FillArray(int[,] array)
{
    
    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = rand.Next(0, 10);
        }
    }
}


int GetMinSum(int[,] array)
{
    int stringNumber = 0;
    int stringSum = int.MaxValue;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        if (sum < stringSum)
        {
            stringSum = sum;
            stringNumber = i + 1;
        }
    }
    return stringNumber;
}