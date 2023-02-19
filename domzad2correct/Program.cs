// **Задача 13:** Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

System.Console.WriteLine("Введите число");
string? number = Console.ReadLine();
if (number!.Length < 3)
{
    System.Console.WriteLine("Нет третьей цифры");
}
else
{
    System.Console.WriteLine(number[2]);
}