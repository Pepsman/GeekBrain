// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
}


double DigitalsMoreZero(double[] array)
{
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) sum = sum + 1;
    }

    return sum;
}


Console.WriteLine("Введите числа через пробел: ");
double[] dig = Console.ReadLine().Split(' ').Select(e => Convert.ToDouble(e)).ToArray();

double digitalsMoreZero = DigitalsMoreZero(dig);
PrintArray(dig);
Console.Write($" Вы ввели {digitalsMoreZero} чисел больше нуля");



