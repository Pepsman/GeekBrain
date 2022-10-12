// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void PrintMatrix(int[,] matr)
{

    for (int i = 0; i < matr.GetLength(0); i++)

    {
        Console.Write("| ");
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i, j] < 10)
            {
                Console.Write("0" + matr[i, j]);
                Console.Write(" ");
            }
            else Console.Write(matr[i, j] + " ");
        }
        Console.WriteLine(" |");
    }
}

void FillMatrixSpiral(int[,] array, int lenght)
// Некоректно работает для матриц с нечетным lenght 
// центральный элемент равен 00  надо сделать автозамену 00 -> size^2  
{
    int i = 0, j = 0;
    int value = 1;
    for (int e = 0; e < lenght * lenght; e++)
    {
        int k = 0;
        do { array[i, j++] = value++; } while (++k < lenght - 1);
        for (k = 0; k < lenght - 1; k++) array[i++, j] = value++;
        for (k = 0; k < lenght - 1; k++) array[i, j--] = value++;
        for (k = 0; k < lenght - 1; k++) array[i--, j] = value++;
        ++i; ++j;
        lenght = lenght < 2 ? 0 : lenght - 2;
    }
}

int size = 4;
int[,] matrix = new int[size, size];
FillMatrixSpiral(matrix, size);
PrintMatrix(matrix);
