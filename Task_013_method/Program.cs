// Задача 13: Напишите программу, которая выводит
// третью цифру заданного числа или сообщает, что третьей
// цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int Prompt(string message)// Метод запроса числа и конвертация в int
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;// возврат значения типа int
}

int GetThirdRank(int number)// Определение метода 
{
    while (number > 999)// цикл пока число больше 999 сокращать 1 разряд за проход
    {
        number /= 10;
    }
    return number % 10;// возврат третьей цифры

}

bool ValidateNumber(int number)// проверка трехзначности числа
{
    if (number < 100)
    {
        Console.WriteLine("Третьей цифры нет");// если число меньше 100 вывод сообщения
        return false;
    }
    return true;
}

int number = Prompt("Введите число > ");// реализация методов
if (ValidateNumber(number))
{
    Console.WriteLine(GetThirdRank(number));
}