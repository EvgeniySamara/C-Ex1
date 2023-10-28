using System;

public class Answer
{
    public static double FindMax(double[] array)
    {     // Введите свое решение ниже
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
       if (array[i]>max)
       {
        max = array[i];
       } 
   
    }
    return max;
       
    }

    public static double FindMin(double[] array)
    {     // Введите свое решение ниже
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
       if (array[i]<min)
       {
        min = array[i];
       } 
   
    }
    return min;

    }

    public static double CalcDifferenceBetweenMaxMin(double[] array)
    {// Введите свое решение ниже
    return FindMax(array)-FindMin(array);


    }

    public static void PrintArray(double[] array)
    {// Введите свое решение ниже
    for (int i=0;i<array.Length;i++)
    {
        if (i<array.Length-1) 
        {
        System.Console.Write($"{Math.Round(array[i],2)}\t");
       
        }
    else  
    {
        System.Console.Write($"{Math.Round(array[i],2)}");}
    }
    System.Console.WriteLine();

    }
 // Не удаляйте и не меняйте метод Main! 


    public static void Main(string[] args)
    {
        double[] array;
        if (args.Length == 0)
        {
            array = new double[] { 3.17, 8.94, 2.36, 5.72, 0.85};
        }
        else
        {
            // Иначе, парсим аргументы в массив чисел
            string[] argStrings = args[0].Split(", ");
            array = new double[argStrings.Length];
            for (int i = 0; i < argStrings.Length; i++)
            {
                if (double.TryParse(argStrings[i], out double number))
                {
                    array[i] = number;
                }
                else
                {
                    Console.WriteLine($"Ошибка при парсинге аргумента {argStrings[i]}.");
                    return;
                }
            }
        }

        Console.WriteLine("Массив:");
        PrintArray(array);
        double diff = CalcDifferenceBetweenMaxMin(array);
        Console.WriteLine($"Разность между максимальным и минимальным элементом = {diff:f2}");
    }
}