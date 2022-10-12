// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки
// с наименьшей суммой элементов: 1 строка

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

void RowMinSumNum(int[,] matrix)
{
    
    int minRow = 0;
    int indexLine = 0;
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        minRow += matrix[0, i];
    }
    for (int j = 0; j < matrix.GetLength(0); j++)
    {
        for (int k = 0; k < matrix.GetLength(1); k++) sum += matrix[j, k];
        if (sum < minRow)
        {
            minRow = sum;
            indexLine = j;
        }
        sum = 0;
    }
    Console.WriteLine($"Наименьшая сумма элементов в {indexLine + 1} строке ");
}


int[,] myMatrix = CreateMatrixRndInt(6, 5, 1, 9);
PrintMatrix(myMatrix);
Console.WriteLine();
RowMinSumNum(myMatrix);
