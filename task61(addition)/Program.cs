/*Доп задача 2. Задача 61: Вывести первые N строк треугольника Паскаля. 
 * Сделать вывод в виде равнобедренного треугольника*/


Console.Clear();
Console.Write("Введите количество строк: ");
int size = int.Parse(Console.ReadLine()!);
int[,] array = CreateArray(size);
FillArray(array);
PrintArray(array);




void FillArray(int[,] array)
{
    
    int middleIndex = (array.GetLength(1) - array.GetLength(1)/2-1);
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        array[i, middleIndex + i] = 1;
        array[i, middleIndex - i] = 1;
    }
        
    for (int i = 2; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j > middleIndex - i && j < middleIndex + i)
            {
                if (array.GetLength(0)%2 == 0 && ((j%2 == 0 && i%2 != 0) || (j%2 != 0 && i%2 == 0)))
                {
                    array[i, j] = array[i - 1, j - 1] + array[i - 1, j + 1];
                }

                else if (array.GetLength(0)%2 != 0 && ((j%2 == 0 && i%2 == 0) || (j%2 != 0 && i%2 != 0)))
                {
                    array[i, j] = array[i - 1, j - 1] + array[i - 1, j + 1];
                }
            }
                
        }
    }
}

int[,] CreateArray(int s)
{
    int[,] array = new int[s, s*2 - 1];
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == 0) Console.Write(" ");
            else Console.Write($"{array[i, j]} ");

        }
        Console.WriteLine();
    }
}