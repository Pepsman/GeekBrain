// Задача 13: Напишите программу, которая выводит
// третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int ThirdDig (int dig)
{
    while(dig >1000)
    {
    dig = dig / 10;
    }
    return dig = dig % 10;
}

Console.WriteLine("Введите число, ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 99) Console.WriteLine("третьей цифры нет");
else 
{
int thirdDigital = ThirdDig(number);  
Console.Write($"{number} -> {thirdDigital}"); 
}
