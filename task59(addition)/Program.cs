/*Доп задача 1. Задача 59: Задайте двумерный массив из целых чисел. 
 * Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
наименьший элемент - 1, на выходе получим
следующий массив:
9 2 3
4 2 4
2 6 7*/


Console.Clear();
int[,] array = new int[5, 5];
FillArrayRandom(array);
PrintArray(array);
PrintArray(CreateNewArray(array));



void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");

        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void FillArrayRandom(int[,] array)
{
    
    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = rand.Next(1, 10);
        }
    }
}

int[] FindMinElement(int[,] array)
{
    int minElement = array[0, 0];
    int minRowIndex = 0;
    int minColIndex = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < minElement)
            {
                minElement = array[i, j];
                minRowIndex = i;
                minColIndex = j;
            }
                

        }
    }
    int[] arr = {minRowIndex, minColIndex};
    return arr;
}

int[,] CreateNewArray(int[,] array)
{
    int[] minIndexes = FindMinElement(array);
    int[,] newArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];

    for (int i = 0, k = 0; i < newArray.GetLength(0); i++, k++)
    {
        if (k == minIndexes[0]) k++;
        for (int j = 0, l = 0; j < newArray.GetLength(1); j++, l++)
        {
            if (l == minIndexes[1]) l++;
            newArray[i, j] = array[k, l];
        }
    }
    return newArray;
}