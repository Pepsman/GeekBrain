// Задача 10: Напишите программу, которая принимает на вход трёхзначное число
//  и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int SecondDig (int dig)
{
    int thirdDig = dig/10;
    int secondDig = thirdDig%10;
    return secondDig;
}

Console.WriteLine("Введите число, ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 99|| number >999) 
Console.WriteLine("Введенное число не трёхзначное. Введите трёхзначное число");
else 
{
    int secondDigit = SecondDig(number);
    Console.WriteLine($"{number} -> {secondDigit}");
}

