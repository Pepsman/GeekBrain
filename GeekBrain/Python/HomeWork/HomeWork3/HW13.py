# Задайте список из вещественных чисел. Напишите программу,
# которая найдёт разницу между максимальным и минимальным значением дробной части элементов.
# Пример:
# - [1.1, 1.2, 3.1, 10.01] => 0.19


a = (input('Введите через пробел вещественные числа: '))
list = []
for i in a.split(" "):
    list.append(float(i))

print(list, '=>', end=" ")


def dif(listt):
    dif_max_min = []
    for i in range(len(listt)):
        dif_max_min.append(listt[i] % 1)
    return max(dif_max_min) - min(dif_max_min)


print(round(dif(list), 2))
