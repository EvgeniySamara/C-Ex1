int firstNumber = new Random().Next(1,10);
int secondNumber = new Random().Next(1,10);

Console.WriteLine(firstNumber);
Console.WriteLine(secondNumber);

if  (firstNumber>secondNumber) 
{
    System.Console.Write($"Первое число `{firstNumber}` больше чем второе число `{secondNumber}`");
    } else {

    if  (firstNumber<secondNumber) 
    { 
        System.Console.Write($"Первое число `{firstNumber}` меньше чем второе число `{secondNumber}`");
        } else {
        System.Console.Write($"Первое число `{firstNumber}` равно второму числу `{secondNumber}`");       
        }
    }    
    



