int calcnum (int len)
{
int counter = 0;
  for (int i=0;i<len;i++)
    {
        System.Console.Write($"Введите число №{i+1}:");
        int num = Convert.ToInt32(Console.ReadLine());
        if (num>0) counter++;
    }
  return counter;  
}

System.Console.Write("Введите количество чисел: ");
int len = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"Количество чисел больше ноля: {calcnum(len)}");