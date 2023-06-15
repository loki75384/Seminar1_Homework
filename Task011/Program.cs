// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

Console.Clear();
int number = new Random().Next(100, 1000);
int firstValue = number / 100;
int secondValue = number % 10;
int thirdValue = number % 10;
Console.WriteLine(number + " " + firstValue + thirdValue);

