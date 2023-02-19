// **Задача 13:** Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

System.Console.WriteLine("Введите число");
int number1 = Convert.ToInt32(Console.ReadLine());
if (number1<100)
{
    System.Console.WriteLine("Третьего числа нет.");
}
else if (number1 > 99 && number1 < 999)
{
    int digit3 = number1%10;
    System.Console.WriteLine("Третья цифра числа = " + digit3); 
}
else if (number1 > 999 && number1 < 9999)
{
    int digit3 = (number1/10)%10;
    System.Console.WriteLine("Третья цифра числа = " + digit3); 
}
else if (number1 > 9999 && number1 < 999999)
{
    int digit3 = (number1%10000-number1%1000)/1000;
    System.Console.WriteLine("Третья цифра числа = " + digit3); 
}