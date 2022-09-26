// Задача 25: Напишите цикл, который принимает на вход два числа 
// (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


double Exponentiation(double num, int exp)
{
    double res = default;
    if (exp == 0) res = 1;
    else if (exp < 0)
    {
        res = 1 / num;
        exp = -exp;
        for (int i = 1; i < exp; i++)
            res = res / num;
    }

     else if (exp > 0)
    {
        res = num;
        for (int i = 1; i < exp; i++)
            res = res * num;
    }
    return res;
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("В какую степень будем возводить: ");
int exponentiation  = Convert.ToInt32(Console.ReadLine());

double result = Exponentiation(number, exponentiation);
Console.WriteLine($"Число {number} в степени {exponentiation} равна {result}");