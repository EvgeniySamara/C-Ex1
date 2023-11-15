﻿using System;

public class Answer
{
   static void ShowCube(int N)
    {
      // Введите свое решение ниже
    System.Console.WriteLine($"N = {N}");
    System.Console.WriteLine($"/*");
      for (int i=1;i<=N;i++)
     {
       System.Console.WriteLine(Math.Pow(i, 3));
     }
      System.Console.WriteLine($"*/");
    }

  // Не удаляйте и не меняйте метод Main! 
      static public void Main(string[] args) {
        int N;

        if (args.Length >= 1) {
            N = int.Parse(args[0]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            N = 6;
        }

        // Не удаляйте строки ниже
        ShowCube(N);
    }
}

