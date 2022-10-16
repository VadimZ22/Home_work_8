/*Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/

Console.Clear();
int[,,] array = new int[2, 2, 2];
FillArray(array);
PrintArrayIndex(array);



void PrintArrayIndex(int[,,] array)
{
    for (int k = 0; k < array.GetLength(0); k++)
    {
        for (int i = 0; i < array.GetLength(1); i++)
        {
            for (int j = 0; j < array.GetLength(2); j++)
            {
                Console.Write($"{array[i, j, k]}({i}, {j}, {k})");
            }
            Console.WriteLine();
        }
        //Console.WriteLine();
    }
}

void FillArray(int[,,] array)
{
    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                int value = rand.Next(10, 100);
                if (IsUniqueVal(value, array))
                    array[i, j, k] = value;
                else
                {
                    k--;
                    continue;
                }
            }
        }
    }
}

bool IsUniqueVal(int val, int[,,] arr)
{
    int count = 0;
    foreach (int item in arr)
    {
        if (val != item)
            count++;
    }
    if (count < arr.Length)
        return false;
    else 
        return true;
}

  
    