// Задача 13: Напишите программу, которая выводит
// третью цифру заданного числа или сообщает, что третьей
// цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine()!);
int b = a % 10;
int c = a / 100 % 10;

if (a >= 32679)
{
    Console.WriteLine(c);
}
else

if (a == a % 100)
{
    Console.WriteLine("третьей цифры нет");
}
else
{
    Console.WriteLine(b);
}


// if (a / 100 == 0)
// {
//     
// }
// else
// {
//     Console.WriteLine(b);
// }