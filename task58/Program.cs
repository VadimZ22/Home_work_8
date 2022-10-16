/*Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
и
1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7
Их произведение будет равно следующему массиву:
1 20 56 10
20 81 8 6
56 8 4 24
10 6 24 49*/


Console.Clear();
int[,] matrix1 = new int[5, 3];
int[,] matrix2 = new int[3, 5];
if (matrix1.GetLength(1) != matrix2.GetLength(0) || matrix1.GetLength(0) != matrix2.GetLength(1))
    Console.WriteLine("Перемножить матрицы невозможно!");
else
{
    FillArray(matrix1);
    FillArray(matrix2);
    PrintArray(matrix1);
    PrintArray(matrix2);
    PrintArray(ProductMatrix(matrix1, matrix2));
}


int[,] ProductMatrix(int[,] matrix1, int [,] matrix2)
{
    int[,] product = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    
    for (int i = 0; i < product.GetLength(0); i++)
    {
        for (int j = 0; j < product.GetLength(1); j++)
        product[i, j] = GetValue(i, j, matrix1, matrix2);
    }
    return product;
}
    
int GetValue(int i, int j, int[,] matrix1, int [,] matrix2)
{
    int result = 0;
    for (int k = 0; k < matrix1.GetLength(1); k++)
    {
        result += matrix1[i, k] * matrix2[k, j];
    }
    return result;
}

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
    Console.WriteLine();
}

void FillArray(int[,] array)
{
    
    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = rand.Next(0, 5);
        }
    }
}