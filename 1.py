# создать новый массив который содержит попарную сумму элементов
import random
a = (int(input('Введите размерность массива ')))
arr = [random.randint(1,10) for i in range(a)]
newarr = []
if a%2 == 0:
   for i in range(1,a//2+1):
      
      newarr.append((arr[i-1]+arr[-i]))
else:
      for i in range(1,a//2+1):
         newarr.append((arr[i-1]+arr[-i]))
      newarr.append((arr[a//2]))
        

print (arr)
print (newarr)



s=input()
s= '10+25 - 12'
s1 = ''
for c in s:
    if c!=' ':
        s1 +=c
s1 = s1.replace('+',' + ')
s1 = s1.replace('-',' - ')
l = s1.split()
if l[0].isdigit:
    res = int(l[0])
    st = 1
else:
    res = l[0]+l[1]
    st = 2
for i in range(st,len(l),2):
    if l[i]=='+':
        res += int(l[i+1])
    else:
        res -= int(l[i+1])
print(res)
