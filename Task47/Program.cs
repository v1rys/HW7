﻿// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("Введите n");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите m");
int m = Convert.ToInt32(Console.ReadLine());

double[,] ourMatrix = GetMatrix(m, n, -10, 10);
PrintMatrix(ourMatrix);





double[,] GetMatrix(int RowsCount, int columsCount, int LeftRenge, int rightRange)
{
    double[,] matrix = new double[RowsCount, columsCount];

    Random rand = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] =  rand.Next(LeftRenge, rightRange);
        }
    }
    return matrix;
}

void PrintMatrix ( double [,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j] + " ");
        }
        Console.WriteLine();
    }
    
}
