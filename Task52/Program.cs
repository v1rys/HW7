// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,7; 5,7; 3,7; 3.

Console.WriteLine("Введите n");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите m");
int m = Convert.ToInt32(Console.ReadLine());

double[,] ourMatrix = GetMatrix(m, n, 1, 10);
PrintMatrix(ourMatrix);
SummaNumbersVerticaliMassive(ourMatrix, n);





double[,] GetMatrix(int RowsCount, int columsCount, int LeftRenge, int rightRange)
{
    double[,] matrix = new double[RowsCount, columsCount];

    Random rand = new Random();

    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(LeftRenge, rightRange);
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
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

void SummaNumbersVerticaliMassive(double[,] matrix, double Verticale)
{
    double sum = 0;

    for (int i = 0; i < matrix.GetLength(1); i++)
    {

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum = sum + matrix[i, j];

        }
        Console.WriteLine(sum / Verticale);
    }


}
