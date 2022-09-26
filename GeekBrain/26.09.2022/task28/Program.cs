// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120


Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int GetFact(int num)
{
    int counter = 1;
    int res = 1;
    while (counter <= num)
    {
        res = res * counter;
        counter++;
    }
    return res;
}
int result = GetFact(Math.Abs(number));
Console.WriteLine(result);
