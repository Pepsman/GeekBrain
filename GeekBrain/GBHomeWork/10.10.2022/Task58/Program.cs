// Задача 58: Задайте две матрицы. Напишите программу, 
//которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


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

int[,] MultiplyingMatrix(int[,] firstMatrix, int[,] secondMatrix)
{
    int[,] resultMatrix = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < secondMatrix.GetLength(1); j++)
        {
            resultMatrix[i, j] = 0;
            for (int k = 0; k < firstMatrix.GetLength(1); k++)
            {
                resultMatrix[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
            }
        }
    }
    return resultMatrix;

}

int[,] matrixFirst = CreateMatrixRndInt(2, 2, 1, 9);
PrintMatrix(matrixFirst);
Console.WriteLine();
int[,] matrixSecond = CreateMatrixRndInt(2, 2, 1, 9);
PrintMatrix(matrixSecond);
Console.WriteLine();

if (matrixFirst.GetLength(0) == matrixSecond.GetLength(1))
{
    int[,] matrixResult = MultiplyingMatrix(matrixFirst, matrixSecond);
    PrintMatrix(matrixResult);
}
else Console.WriteLine(" Нельзя перемножить ");
