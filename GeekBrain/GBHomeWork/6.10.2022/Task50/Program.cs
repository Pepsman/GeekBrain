// Задача 50. Напишите программу, которая на вход принимает
// позиции элемента в двумерном массиве, и возвращает 
// значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

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

Console.WriteLine("Ведите позицию строки элемента");
int xRow = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите позицию столбца элемента");
int yColum = Convert.ToInt32(Console.ReadLine());

int row = xRow -1;
int colum =yColum - 1;

double [,] myMatrix = CreateMatrixRndDbl(10,10, -9, 9);
PrintMatrix(myMatrix);
if (row > myMatrix.GetLength(0)|| colum> myMatrix.GetLength(1)) Console.WriteLine("такого элемента в массиве нет");
else Console.WriteLine($"На строке {xRow} столбец {yColum} находится элемент {myMatrix[row,colum]}");
