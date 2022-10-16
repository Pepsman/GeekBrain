// Задача 64: Задайте значения N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1.
// N = 5. -> "5, 4, 3, 2, 1"
// N = 8. -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Введите положительное число больше нуля: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 1) Console.WriteLine("Число должно быть больше нуля");
else NaturalNumber(number);


void NaturalNumber(int num)
{
    if (num == 0) return;
    Console.Write($"{num}, ");
    NaturalNumber(num - 1);
}

