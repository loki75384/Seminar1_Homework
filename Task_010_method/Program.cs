﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int Prompt(string message)// Метод запроса сообщения и конветрации из string в int
{
    System.Console.Write(message);// Стандартная команда для вывода текста 
    string value = Console.ReadLine();// считывание сообщения в строчном типе
    int result = Convert.ToInt32(value);// конвертация из строки (string value) в целочисленное (int result)
    return result;// возвращает переменную
}

int number = Prompt("Введите трехзначное число > ");// слева задаем переменную, справа вызываем метод
if (number < 100 || number >= 1000)// || - логический оператор ИЛИ "Замыкание" (если хотя бы одна из сторон true), в противном случае (если обе стороны true, то вывод false)
{
    Console.WriteLine("Вы ввели не трехзначное число, пожалуйста повторите ввод");// если число не трехзначное , метод возвращает вначало.
    return;
}
Console.WriteLine($"Введенное число '{number}'");// вывод 
int secondRank = number / 10 % 10;
Console.WriteLine($"Вторая цифра '{secondRank}' ");// вывод