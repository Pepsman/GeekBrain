# Напишите программу, которая найдёт произведение пар чисел списка.
# Парой считаем первый и последний элемент, второй и предпоследний и т.д.
# Пример:
# - [2, 3, 4, 5, 6] => [12, 15, 16];
# - [2, 3, 5, 6] => [12, 15]

a = (input('Введите через пробел целые числа: '))
list = []
for i in a.split(" "):
    list.append(int(i))

print(list, '=>', end=" ")


def pairsnum(list):
    mult = []
    for i in range((len(list)+1)//2):
        mult.append(list[i]*list[len(list)-1-i])
    return mult


print(pairsnum(list))
