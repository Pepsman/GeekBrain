// Задача 47. Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Создание матрицы заполненой случайными числами

double[,] CreateMatrixRndDbl(int rows, int colums, int min, int max)
{
    double[,] matrix = new double[rows, colums];
    var rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }

    }
    return matrix;
}

//печать матрицы с отступами и |
void PrintMatrix(double[,] matr)
{
    
    for (int i = 0; i < matr.GetLength(0); i++)
  
    {
        Console.Write("|");
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (j < matr.GetLength(1) - 1) Console.Write($"{matr[i, j], 4}, ");
            else Console.Write($"{matr[i, j], 4} ");
        }
        Console.WriteLine(" |");
    }
}

Console.WriteLine("Ведите колличество строк матрицы");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите колличество столбцов матрицы");
int colum = Convert.ToInt32(Console.ReadLine());
double [,] myMatrix = CreateMatrixRndDbl(row, colum, -9, 9);
PrintMatrix(myMatrix);

