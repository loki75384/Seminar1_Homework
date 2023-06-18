// Задача 15: Напишите программу, которая принимает на вход
// цифру, обозначающую день недели, и проверяет, является ли
// этот день выходным.

int Prompt(string message)// Метод запроса числа и конвертация в int
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result; // возврат значения типа int
}

bool IsWeekend(int weekDay)// Заданный день недели выходной?
{
    if (weekDay > 5)// если день недели больше 5
    {
        return true;// истина
    }
    return false;// ложь
}

bool ValidateWeekday(int number)// день недели  ли? интервал между 0 и 7
{
    if (number > 0 && number <= 7)
    {
        return true;
    }
    Console.WriteLine("Это не день недели!");
    return false;
}

int weekDay = Prompt("Введите день недели > ");// реализация методов описанных выше 
if (ValidateWeekday(weekDay))// день недели?
{
    if (IsWeekend(weekDay))// этот день недели выходной?
    {
        Console.WriteLine("Наконец-то выходной");// вывод истина
    }
    else
    {
        Console.WriteLine("Придется работать");// вывод ложь
    }
}