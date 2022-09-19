// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

bool Multiplicity (int num)
{
  {
    return num % 7 == 0 && num % 23 == 0;
}

}



Console.WriteLine("Введите первое число, ");
bool number = Multiplicity(Console.ReadLine());
//if (number % 7 == 0 && number % 23 == 0) Console.WriteLine($"{number}, кратно ");
else Console.WriteLine($"{number},  не кратно ");

