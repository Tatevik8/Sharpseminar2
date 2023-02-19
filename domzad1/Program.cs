// **Задача 10:** Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает **вторую** цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

System.Console.WriteLine("Введите трехзначное число");
int number1 = Convert.ToInt32(Console.ReadLine());
if (number1<100 || number1>1000)
{
    System.Console.WriteLine("Введено не трехзначное число.");
}
else if (number1 > 0)
{
    int number2 = (number1%100-number1%10)/10;  
    System.Console.WriteLine("Вторая цифра числа = " + number2); 
}