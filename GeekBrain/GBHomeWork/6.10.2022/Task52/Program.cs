// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


// Печать массива 
void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{Math.Round(array[i], 1, MidpointRounding.ToEven)}, ");
        else Console.Write($"{Math.Round(array[i], 1, MidpointRounding.ToEven)}");
    }
}

// Создание матрицы заполненой случайными числами

int[,] CreateMatrixRndInt(int rows, int colums, int min, int max)
{
    int[,] matrix = new int[rows, colums];
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
        Console.Write("|");
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (j < matr.GetLength(1) - 1) Console.Write($"{matr[i, j],4}, ");
            else Console.Write($"{matr[i, j],4} ");
        }
        Console.WriteLine(" |");
    }
}

double[] ArithmeticMeanColumsMatrix(int[,] matrix)
{
    double[] array = new double[matrix.GetLength(1)];
    int ind = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double variable = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            
            variable = (variable + matrix[i, j]);
            
        }
            variable = variable / matrix.GetLength(0);
            array[ind] = variable;
            ind++;
    }
        return array;
}

int[,] myMatryx = CreateMatrixRndInt(3, 4, 0, 9);
PrintMatrix(myMatryx);
Console.WriteLine();
double[] arrayAMC = ArithmeticMeanColumsMatrix(myMatryx);
System.Console.Write("Среднее арифметическое по каждому столбцу: ");
PrintArray(arrayAMC);

