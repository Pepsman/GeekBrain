// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0)
{
    int result = DigitMultiplication(number);
    Console.WriteLine($"Произведение числе от 1 до {number} = {result}");
}
else Console.WriteLine("Введено некорректное значение");

int DigitMultiplication(int num)
{
    int multiplic = 1;
    for (int i = 1; i <= num; i++)
    {
        multiplic = multiplic * i;
    } 
    return multiplic;
}