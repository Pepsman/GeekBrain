// Печать элементов многомерного массива

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr [i, j]} ");
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
          matr [i, j] = new Random().Next (1, 10); 
        }
    }
}

int [,] matrix = new int [3, 4];
PrintArray(matrix);
Console.WriteLine();
FillArray(matrix);
PrintArray(matrix);


