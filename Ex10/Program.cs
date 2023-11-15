using System;

public class Answer
{
    static bool IsPalindrome(int number){
      // Введите свое решение ниже
       string str = number.ToString();
       if (number>99999||number<10000)
       {
          
        Console.WriteLine("Число не пятизначное");
        return  false;
        
       }
       else if (str[0]==str[4]&&str[1]==str[3])
       {
         
         return true;
          
       }
       else
       {
         return  false;
       }
       
    }
  
  // Не удаляйте и не меняйте метод Main! 
      static public void Main(string[] args) {
        int number;

        if (args.Length >= 1) {
            number = int.Parse(args[0]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            number = 64546;
        }

        // Не удаляйте строки ниже
        bool result = IsPalindrome(number);
        System.Console.WriteLine($"{result}");
    }
}