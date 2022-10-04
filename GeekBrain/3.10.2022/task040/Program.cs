// Задача 40  Напишите программу которая принимает на вход три числа и 
// проверяет может ли существовать треугольник с сторонами
// такой длины  
//Каждая сторона треугольника меньше суммы других сторон

bool TriangleInequality(int a, int b, int c)
{
    return a < b + c && b < a + c && c < b + a;
}


Console.WriteLine("Введите первую сторону треугольника: ");
int sideA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите вторую  сторону треугольника: ");
int sideB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третью сторону треугольника: ");
int sideC = Convert.ToInt32(Console.ReadLine());
if (TriangleInequality(sideA, sideB, sideC))
{
     Console.WriteLine("треугольник может существовать");
}
else Console.WriteLine("треугольник не может существовать");