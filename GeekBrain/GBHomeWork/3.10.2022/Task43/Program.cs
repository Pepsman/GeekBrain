// Задача 43: Напишите программу, которая найдёт точку пересечения
// двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
//  значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void IntersectionLine(double coordb1, double coordk1, double coordb2, double coordk2)
{
    if ((coordk1 == coordk2) && (coordb1 == coordb2))

    Console.WriteLine("Прямые совпадают");

else if (coordk1 == coordk2)

    Console.WriteLine("Прямые параллельны");

else 
    {

    double x = (-coordb2 + coordb1) / (-coordk1 + coordk2);
    double y = coordk2 * x + coordb2;

        Console.WriteLine($"две прямые пересекутся в точке с координатами X: {x}, Y: {y}");
    }
}


Console.WriteLine("введите значение b1");
double coorb1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("введите значение k1");
double coork1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("введите значение b2");
double coorb2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("введите значение k2");
double coork2 = Convert.ToDouble(Console.ReadLine());


IntersectionLine(coorb1, coork1, coorb2, coork2);


