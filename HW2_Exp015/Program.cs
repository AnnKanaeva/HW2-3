/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/
Console.Write("Введите число:");
string day = Console.ReadLine();
if (day == "1")
{
    Console.Write("Понедельник");
}
else if (day == "2")
{
    Console.Write("Вторник");
}
else if (day == "3")
{
    Console.Write("Среда");
}
else if (day == "4")
{
    Console.Write("Четверг");
}
else if (day == "5")
{
    Console.Write("Пятница");
}
else if (day == "6")
{
    Console.Write("Суббота");
}
else if (day == "7")
{
    Console.Write("Воскресенье");
}

else 
{
    Console.WriteLine("Такого дня недели нет");
}
if (day == "1"|| day =="2"|| day =="3"|| day =="4"|| day =="5")
{
    Console.WriteLine("-Это рабочий день");
}
else if (day == "6" || day == "7")
{
    Console.WriteLine("-Это выходной день");
}

// как это можно записать короче?