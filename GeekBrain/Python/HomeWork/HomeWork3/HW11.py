# Задайте список из нескольких чисел. Напишите программу,
# которая найдёт сумму элементов списка, стоящих на нечётной идексах.
# Пример:
# [2, 3, 5, 9, 3] -> на нечётных идексах элементы 3 и 9, ответ: 12

a = (input('Введите через пробел целые числа: '))
list = []
for i in a.split(" "):
    list.append(int(i))


sum = 0
for i in range(len(list)):
    if i % 2 != 0:
        sum = sum + list[i]
print(f'сумма элементов списка, стоящих на нечётных идексах списка {list} равна', sum)
