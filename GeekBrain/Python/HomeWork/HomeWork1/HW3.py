# Напишите программу, которая принимает на вход координаты
# точки (X и Y), причём X ≠ 0 и Y ≠ 0 и
# выдаёт номер четверти плоскости,
# в которой находится эта точка.

x = int(input("Введите координату X: "))
y = int(input("Введите координату Y: "))
text = 4
if x > 0 and y > 0:
    text = 1
elif x < 0 and y > 0:
    text = 2
elif x < 0 and y < 0:
    text = 3
print(f"Точка находится в {text} четверти плоскости")