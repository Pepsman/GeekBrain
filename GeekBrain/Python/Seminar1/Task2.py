#Найти максимальное из пяти чисел

#a = int(input("Введите первое число: "))
#b = int(input("Введите второе число: "))
#c = int(input("Введите третье число: "))
#d = int(input("Введите четвертое число: "))
#e = int(input("Введите пятое число: "))

a = []
for _ in range(5):
    k = int(input("Введите число: "))
    a.append(k)

maxx = a[0]

for i in a:
    if i > maxx:
        maxx = i

print (f'Наибольшее число {maxx}')
