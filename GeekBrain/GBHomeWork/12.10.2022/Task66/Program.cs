// // Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// // M = 1; N = 15 -> 120
// // M = 4; N = 8. -> 30

Console.Write("Введите M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());

SumFromMToNOutput(m, n);


void SumFromMToNOutput(int m, int n)
{
    if (m < n) Console.Write(CountNaturalSum(m - 1, n));

    else Console.Write(CountNaturalSum(m, n - 1));
}


int CountNaturalSum(int m, int n)
{
    int res = m;
    if (m == n)
        return 0;
    else
    {
        if (m<n)
        {
        m++;
        res = m + CountNaturalSum(m, n);
        return res;
        }
        else
        n++;
        res = n+CountNaturalSum(n, m);
        return res;
    }
}