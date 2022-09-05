// Задача 50. Напишите программу, которая на вход 
// принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4


Console.WriteLine("Введите n");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите m");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите кординат по горизонтали ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координат по вертикали");
int y = Convert.ToInt32(Console.ReadLine());

if (x > n)
{
    Console.WriteLine("Таких коодинат в массиве нет");
}
else if (y > m)
{
    Console.WriteLine("Таких координат в массиве нет");
}
else
{
    int[,] ourMatrix = GetMatrix(m, n, -10, 10);
    PrintMatrix(ourMatrix);
    PrintCoordinates(ourMatrix, x, y);
}


int[,] GetMatrix(int RowsCount, int columsCount, int LeftRenge, int rightRange)
{
    int[,] matrix = new int[RowsCount, columsCount];

    Random rand = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(LeftRenge, rightRange);
        }
    }
    return matrix;
}

void PrintCoordinates(int[,] matrix, int festCoordinatts, int secondCcoordinates)

{
    Console.WriteLine(matrix[festCoordinatts, secondCcoordinates]);
}

void PrintMatrix(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();

    }

}
