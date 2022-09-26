// Задача 27: Напишите программу, которая 
// принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int DidgSum(int num)
{
    int remainder = 0;
    
    while (num > 0)
    {
        remainder = remainder + num % 10; 
        num = num / 10;
        
    }
    return remainder;
}
int result = DidgSum(Math.Abs(number));
Console.WriteLine($"Сумма цифр в числе {number} равна {result}");
