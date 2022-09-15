// Задача 8: Напишите программу, 
// которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число, ");
int number = Convert.ToInt32(Console.ReadLine());

int firsteven = 2;

while (firsteven < number)
{
   Console.Write($"{firsteven} ");
   firsteven = firsteven + 2;
}