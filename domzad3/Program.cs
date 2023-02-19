// **Задача 15:** Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да7 -> да1 -> нет

System.Console.Write("Введите число дня недели. ");
int N = Convert.ToInt32(Console.ReadLine());
if (N == 1)
{
    System.Console.WriteLine("Понедельник рабочий день ");
}
else if (N == 2)
{
    System.Console.WriteLine("Вторник рабочий день ");
}
else if (N == 3)
{
    System.Console.WriteLine("Среда рабочий день ");
}
else if (N == 4)
{
    System.Console.WriteLine("Четверг рабочий день ");
}
else if (N == 5)
{
    System.Console.WriteLine("Пятница рабочий день ");
}
else if (N == 6)
{
    System.Console.WriteLine("Суббота рабочий день ");
}
else if (N == 7)
{
    System.Console.WriteLine("Воскресенье рабочий день ");
}
else
{
Console.WriteLine("Такого дня не существует");
}