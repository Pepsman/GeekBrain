// Печать элементов многомерного массива

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}


//Заполнение многомерного массива случайными числами
void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}

// Создание матрицы заполненой случайными числами

int[,] CreateMatrixRndInt(int rows, int colums, int min, int max)
{
    int[] matrix = new int[rows, colums];
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
void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        Console.WriteLine("|");
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matr[i, j], 4}, ");
            else Console.Write($"{matr[i, j], 4} ");
        }
        Console.WriteLine(" |");
    }
}

int[,] matrix = new int[3, 4];
PrintArray(matrix);
Console.WriteLine();
FillArray(matrix);
PrintArray(matrix);


