# Задана натуральная степень k. Сформировать случайным образом список 
# коэффициентов (значения от 0 до 100) многочлена и записать в файл многочлен степени k.
# Пример:
# - k=2 => 2*x² + 4*x + 5 = 0 или x² + 5 = 0 или 10*x² = 0
# - k=4 => 8*(x**4) + 9*(x**3) + 1*(x**2) + 5*x + 4 = 0 или 8*(x**4) + 5*x + 4 = 0 и т.д.

import random
import pathlib


k = int(input('Введите коэффициент: '))
a = int(random.randint(0,100))
b = int(random.randint(0,100))
c = int(random.randint(0,100))
if a != 0:
    first = (str(a) + "x^" + str(k) + " + ")
else:
    first = (str())
if b != 0:
    second = (str(b) + "x" + " + ")
else:
    second = (str())
if c != 0:
    third = (str(c) + " = 0")
else:
    third = (str())

with open('poly.txt', 'w', encoding='utf-8') as file:
    file.write(f'{first}{second}{third}')

print(f'{first}{second}{third}')
