// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2


double[] CreateArrayRndInt(Int64 size, double min, double max)
{
    double[] array = new double[size];
    var rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.NextDouble() * (max - min) + min;
    }
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{Math.Round(array[i], 1, MidpointRounding.ToEven)}, ");
        else Console.Write($"{Math.Round(array[i], 1, MidpointRounding.ToEven)}");
    }
    Console.WriteLine("]");
}


double MaxDeduMin(double[] array)
{
    double max = array[1];
    double min = array[1];
    double res = default;
    

    for (int i = 0; i < array.Length; i++)
    {
      if ( array[i] > max) max = array[i];
    }
    for (int j = 0; j < array.Length; j++)
    {
       if ( array[j] < min) min = array[j]; 
    
    }
    res = max - min;
    return res;
}

double[] arr = CreateArrayRndInt (5, -100 , 100);
PrintArray(arr);
double maxDeduMins = MaxDeduMin(arr);
Console.WriteLine($"Разница между максимальным и минимальным элементом массива составляет: {Math.Round(maxDeduMins, 1, MidpointRounding.ToEven)}");