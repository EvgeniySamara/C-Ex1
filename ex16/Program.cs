//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

int [] fillarray (int len, int minint,int maxint)
{
    int [] newarray = new int[len];
    Random rand = new Random();
    for (int i=0;i<len;i++)
        {
            newarray[i] = rand.Next(minint,maxint+1);
        }
    return newarray;
}

void printarr (int [] array)
{
int len = array.Length;
System.Console.Write('[');
for (int i=0;i<len;i++)
{
    System.Console.Write($"{array[i]}");
    if (i!= len-1) System.Console.Write(',');
}
System.Console.Write(']');
}


System.Console.WriteLine("Введите размерность массива");
int len =Convert.ToInt32(Console.ReadLine());
int [] array = fillarray(len,1,10);
printarr(array);

