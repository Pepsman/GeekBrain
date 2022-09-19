int MaxDigit(int num)
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    // if (firstDigit > secondDigit) return firstDigit;
    // return secondDigit;
    if(IsEqualDigits(firstDigit, secondDigit)) return 0;
    return firstDigit > secondDigit ? firstDigit : secondDigit;
}

bool IsEqualDigits(int num1, int num2)
{
    return num1 == num2;
}

int number = new Random().Next(10, 100);
int maxDigit = MaxDigit (number);

string result = maxDigit > 0 ? maxDigit.ToString() : "Цифры равны";
Console.WriteLine($"Наибольшая цифра числа {number} = {maxDigit}");
