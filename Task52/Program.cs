// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,7; 5,7; 3,7; 3.

Console.WriteLine("Введите количество строк вашего двумерного массива ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов вашего двумерного массива ");
int m = Convert.ToInt32(Console.ReadLine());

double[,] ourMatrix = GetMatrix(n, m, 1, 10);
PrintMatrix(ourMatrix);
SummaNumbersVerticaliMassive(ourMatrix, n, m );





double[,] GetMatrix(int RowsCount, int columsCount, int LeftRenge, int rightRange)
{
    double[,] matrix = new double[RowsCount, columsCount];

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

void SummaNumbersVerticaliMassive(double[,] matrix,  double RowsCount, double columsCount)
{
   
  
    for (int i = 0; i <columsCount; i++)
    {
        double sum = 0;

        for (int j = 0; j < RowsCount ; j++)
        {
            sum = sum + matrix[j, i];

        }
        Console.WriteLine($"Сумма {i} столбца = {sum / RowsCount:f2}");
    }


}
