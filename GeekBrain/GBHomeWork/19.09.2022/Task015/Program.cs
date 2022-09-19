// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

bool WeekEnd(int wknd)
{
    return wknd ==6 || wknd ==7;
}

Console.WriteLine("Введите число соответствующее дню недели, ");
int number = Convert.ToInt32(Console.ReadLine());
if (number <1  || number > 7) Console.WriteLine("Нет такого дня недели");
else 
{
 if  (WeekEnd(number))Console.Write("Да"); 
 else Console.Write("Нет");
}
