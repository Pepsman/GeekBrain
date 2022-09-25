// Задача 19
// Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да



Console.WriteLine("Введите число, ");
int number = Convert.ToInt32(Console.ReadLine());

bool Palindrome(int num)
{
    int temp1 = num / 10000 % 10;
    int temp2 = num  / 1000 % 10;
    int temp4 = num / 10 % 10;
    int temp5 = num % 10;
    return temp1 == temp5 && temp2 == temp4;
}

if (number <10000 || number > 99999) Console.WriteLine("Это не пятизначное число");
else 
{
 if  (Palindrome(number))Console.Write($"Да число {number} палиндром"); 
 else Console.Write($"Нет число {number} не палиндром");
}
