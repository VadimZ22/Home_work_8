/*9Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/

Console.Clear();
Console.Write("Введите размер стороны матрицы: ");
int size = int.Parse(Console.ReadLine()!);
int[,] array = new int[size, size];
FillArraySpiral(array, size);
PrintArray(array);



void FillArraySpiral(int[,] array, int size)
{
    int a=0, b=1, c=2;
    int number = 1;

    for (int i = 0; i < size; i++)
    {
        for (int j = a; j < size - a; j++)
        {
            array[a, j] = number;
            number++;
        }
        for (int j = b; j < size - a; j++)
        {
            array[j, size - b] = number;
            number++;
        }
        for (int j = size - c; j >= a; j--)
        {
            array[size - b, j] = number;
            number++;
        }
        for (int j = size - c; j > a; j--)
        {
            array[j, a] = number;
            number++;
        }
            a++;
            b++;
            c++;
    }
}
    

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
}

