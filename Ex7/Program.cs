Console.Write("Введите число: ");
string? num= Console.ReadLine();

if(num.Length == 3)
{
    Console.WriteLine (num[1]);
}
else
{
    Console.Write("Число не трехзначное");
}   
