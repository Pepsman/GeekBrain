# Вывести на экран числа от -N до N

n = int(input("Введите число: "))
# for i in range(-n,n+1):
#    print(i, end =' ')
print(*range(-n, n+1))
